using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ReScene.SRR;
using ReScene.Core;
using ReScene.Core.Cryptography;
using ReScene.Core.IO;

namespace WinRARRed.Forms;

public partial class SRRReconstructionForm : Form
{
    private readonly string srrFilePath;
    private readonly string? initialReleaseDir;
    private readonly string? initialOutputDir;
    private readonly string? initialVerificationFile;

    private CancellationTokenSource? cts;
    private bool isRunning;

    // Log colors (same palette as MainForm)
    private static readonly Color ColorTimestamp = Color.FromArgb(128, 128, 128);
    private static readonly Color ColorDebug = Color.FromArgb(128, 128, 128);
    private static readonly Color ColorInfo = Color.FromArgb(212, 212, 212);
    private static readonly Color ColorWarning = Color.FromArgb(255, 193, 7);
    private static readonly Color ColorError = Color.FromArgb(244, 67, 54);
    private static readonly Color ColorSuccess = Color.FromArgb(76, 175, 80);

    public SRRReconstructionForm(string srrFilePath, string? releaseDir, string? outputDir, string? verificationFile)
    {
        InitializeComponent();

        this.srrFilePath = srrFilePath;
        initialReleaseDir = releaseDir;
        initialOutputDir = outputDir;
        initialVerificationFile = verificationFile;

        btnStart.Click += BtnStart_Click;
        btnClose.Click += BtnClose_Click;
        btnBrowseReleaseDir.Click += BtnBrowseReleaseDir_Click;
        btnBrowseOutputDir.Click += BtnBrowseOutputDir_Click;
        btnBrowseVerificationFile.Click += BtnBrowseVerificationFile_Click;
        FormClosing += SRRReconstructionForm_FormClosing;
        Load += SRRReconstructionForm_Load;
    }

    private void SRRReconstructionForm_Load(object? sender, EventArgs e)
    {
        CenterToParent();

        // Pre-fill textboxes
        if (!string.IsNullOrEmpty(initialReleaseDir))
            tbReleaseDir.Text = initialReleaseDir;
        if (!string.IsNullOrEmpty(initialOutputDir))
            tbOutputDir.Text = initialOutputDir;
        if (!string.IsNullOrEmpty(initialVerificationFile))
            tbVerificationFile.Text = initialVerificationFile;

        // Parse and display SRR info
        try
        {
            var srr = SRRFile.Load(srrFilePath);
            PopulateSrrInfo(srr);
        }
        catch (Exception ex)
        {
            lblPackerType.Text = "Failed to load SRR";
            Log.Error(this, $"Failed to load SRR for info display: {ex.Message}");
        }
    }

    private void PopulateSrrInfo(SRRFile srr)
    {
        // Packer type
        lblPackerType.Text = srr.CustomPackerDetected switch
        {
            CustomPackerType.AllOnesWithLargeFlag => "Custom packer (RELOADED, HI2U, 0x0007, 0x0815)",
            CustomPackerType.MaxUint32WithoutLargeFlag => "Custom packer (QCF)",
            CustomPackerType.None => "Standard (WinRAR)",
            _ => $"Custom packer ({srr.CustomPackerDetected})"
        };

        // RAR volumes
        int volumeCount = srr.RarFiles.Count;
        if (volumeCount > 0)
        {
            var fileNames = srr.RarFiles.Select(r => r.FileName).ToList();
            string nameList = fileNames.Count <= 3
                ? string.Join(", ", fileNames)
                : string.Join(", ", fileNames.Take(3)) + $" ... (+{fileNames.Count - 3} more)";
            lblRarVolumes.Text = $"{volumeCount} volume(s): {nameList}";
        }
        else
        {
            lblRarVolumes.Text = "0 volumes";
        }

        // Archived files/directories
        int fileCount = srr.ArchivedFiles.Count;
        int dirCount = srr.ArchivedDirectories.Count;
        string dirSuffix = dirCount > 0 ? $", {dirCount} directory(ies)" : "";
        lblArchivedFiles.Text = $"{fileCount} file(s){dirSuffix}";

        // SRR file path
        lblSrrPath.Text = Path.GetFileName(srrFilePath);
        var toolTip = new ToolTip();
        toolTip.SetToolTip(lblSrrPath, srrFilePath);
    }

    private void BtnBrowseReleaseDir_Click(object? sender, EventArgs e)
    {
        GUIHelper.BrowseOpenDirectory(tbReleaseDir, "Select release directory");
    }

    private void BtnBrowseOutputDir_Click(object? sender, EventArgs e)
    {
        GUIHelper.BrowseOpenDirectory(tbOutputDir, "Select output directory");
    }

    private void BtnBrowseVerificationFile_Click(object? sender, EventArgs e)
    {
        GUIHelper.BrowseOpenFile(tbVerificationFile, "Select verification file",
            "Verification files (*.sha1;*.sfv)|*.sha1;*.sfv|All files (*.*)|*.*");
    }

    private void BtnClose_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private async void BtnStart_Click(object? sender, EventArgs e)
    {
        // If running, treat as Stop
        if (isRunning)
        {
            btnStart.Enabled = false;
            btnStart.Text = "Stopping...";
            cts?.Cancel();
            return;
        }

        // Validate release directory
        string releaseDir = tbReleaseDir.Text;
        if (string.IsNullOrEmpty(releaseDir) || !Directory.Exists(releaseDir))
        {
            GUIHelper.ShowError(tbReleaseDir, "Release directory does not exist.");
            return;
        }

        // Validate/create output directory
        string outputDir = tbOutputDir.Text;
        if (string.IsNullOrEmpty(outputDir))
        {
            GUIHelper.ShowError(tbOutputDir, "Output directory is required.");
            return;
        }
        if (!Directory.Exists(outputDir))
        {
            try
            {
                Directory.CreateDirectory(outputDir);
            }
            catch (Exception ex)
            {
                GUIHelper.ShowError(tbOutputDir, $"Failed to create output directory:{Environment.NewLine}{ex.Message}");
                return;
            }
        }

        // Validate verification file
        string verificationFilePath = tbVerificationFile.Text;
        if (string.IsNullOrEmpty(verificationFilePath) || !File.Exists(verificationFilePath))
        {
            GUIHelper.ShowError(tbVerificationFile, "Verification file does not exist.");
            return;
        }

        // Determine hash type
        HashType? hashType = Path.GetExtension(verificationFilePath).ToLower() switch
        {
            ".sfv" => HashType.CRC32,
            ".sha1" => HashType.SHA1,
            _ => null
        };
        if (hashType == null)
        {
            GUIHelper.ShowError(tbVerificationFile, "Invalid verification file type. Use .sfv or .sha1 files.");
            return;
        }

        // Parse hashes
        HashSet<string> hashes;
        try
        {
            hashes = ReadVerificationFile(verificationFilePath, hashType.Value);
        }
        catch (Exception ex)
        {
            GUIHelper.ShowError(tbVerificationFile, $"Failed to parse verification file:{Environment.NewLine}{ex.Message}");
            return;
        }
        if (hashes.Count == 0)
        {
            GUIHelper.ShowError(tbVerificationFile, "No hashes found in verification file.");
            return;
        }

        // Get original RAR filenames from SRR
        List<string> originalRarFileNames;
        try
        {
            var srr = SRRFile.Load(srrFilePath);
            originalRarFileNames = srr.RarFiles.Select(r => r.FileName).ToList();
        }
        catch (Exception ex)
        {
            GUIHelper.ShowError(this, $"Failed to load SRR file:{Environment.NewLine}{ex.Message}");
            return;
        }

        // Disable inputs, switch to running state
        isRunning = true;
        gbInput.Enabled = false;
        gbSrrInfo.Enabled = false;
        btnStart.Text = "Stop";
        btnClose.Enabled = false;
        rtbLog.Clear();

        // Subscribe to log events
        WinRARRed.Log.Logged += LogHandler;

        cts = new CancellationTokenSource();
        var reconstructor = new SRRReconstructor(new SerilogReSceneLogger());
        reconstructor.Progress += Reconstructor_Progress;

        try
        {
            bool success = await reconstructor.ReconstructAsync(
                srrFilePath,
                releaseDir,
                outputDir,
                originalRarFileNames,
                hashes,
                hashType.Value,
                cts.Token);

            isRunning = false;

            if (success)
            {
                lblHeader.Text = "Reconstruction Complete — All Matched!";
                lblHeader.ForeColor = ColorSuccess;
            }
            else
            {
                lblHeader.Text = "Reconstruction Complete — Mismatches";
                lblHeader.ForeColor = ColorWarning;
            }
        }
        catch (OperationCanceledException)
        {
            isRunning = false;
            lblHeader.Text = "Reconstruction Cancelled";
            lblHeader.ForeColor = ColorWarning;
        }
        catch (Exception ex)
        {
            isRunning = false;
            lblHeader.Text = "Reconstruction Failed";
            lblHeader.ForeColor = ColorError;
            Log.Error(this, $"Reconstruction failed: {ex.Message}");
        }
        finally
        {
            WinRARRed.Log.Logged -= LogHandler;
            reconstructor.Progress -= Reconstructor_Progress;
            cts.Dispose();
            cts = null;

            btnStart.Enabled = false;
            btnStart.Text = "Start";
            btnClose.Enabled = true;
        }
    }

    private void Reconstructor_Progress(object? sender, BruteForceProgressEventArgs e)
    {
        if (InvokeRequired)
        {
            try { Invoke(() => Reconstructor_Progress(sender, e)); } catch { }
            return;
        }

        int total = (int)e.OperationSize;
        int completed = (int)e.OperationProgressed;

        lblProgressText.Text = $"Volume {completed} of {total}";
        double percent = total > 0 ? (double)completed / total * 100 : 0;
        lblProgressPercent.Text = $"{percent:F1}%";
        pbOverall.Value = (int)Math.Min(percent, 100);
        lblCurrentDetail.Text = e.RARCommandLineArguments;
    }

    private void LogHandler(object? sender, LogEventArgs e)
    {
        AppendLog(e.Message);
    }

    private void AppendLog(string text)
    {
        if (InvokeRequired)
        {
            try { BeginInvoke(() => AppendLog(text)); } catch { }
            return;
        }

        Color logColor = ColorInfo;
        if (text.Contains("[DEBUG]"))
            logColor = ColorDebug;
        else if (text.Contains("[WARNING]"))
            logColor = ColorWarning;
        else if (text.Contains("[ERROR]") || text.Contains("[FATAL]"))
            logColor = ColorError;
        else if (text.Contains("MATCH") || text.Contains("SUCCESS"))
            logColor = ColorSuccess;

        string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");

        rtbLog.SelectionStart = rtbLog.TextLength;
        rtbLog.SelectionColor = ColorTimestamp;
        rtbLog.AppendText($"[{timestamp}] ");

        rtbLog.SelectionStart = rtbLog.TextLength;
        rtbLog.SelectionColor = logColor;
        rtbLog.AppendText(text + Environment.NewLine);

        rtbLog.SelectionColor = rtbLog.ForeColor;
        rtbLog.SelectionStart = rtbLog.TextLength;
        rtbLog.ScrollToCaret();
    }

    private void SRRReconstructionForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (isRunning && e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            btnStart.Enabled = false;
            btnStart.Text = "Stopping...";
            cts?.Cancel();
        }
    }

    private static HashSet<string> ReadVerificationFile(string filePath, HashType type)
    {
        HashSet<string> hashes = [];

        switch (type)
        {
            case HashType.SHA1:
                {
                    SHA1File sha1File = SHA1File.ReadFile(filePath);
                    foreach (SHA1FileEntry entry in sha1File.Entries)
                    {
                        hashes.Add(entry.SHA1);
                    }
                }
                break;

            case HashType.CRC32:
                {
                    SFVFile sfvFile = SFVFile.ReadFile(filePath);
                    foreach (SFVFileEntry entry in sfvFile.Entries)
                    {
                        hashes.Add(entry.CRC);
                    }
                }
                break;
        }

        return hashes;
    }
}
