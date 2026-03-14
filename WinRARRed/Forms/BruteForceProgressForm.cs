using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ReScene.Core;
using ReScene.Core.Diagnostics;

namespace WinRARRed.Forms;

public partial class BruteForceProgressForm : Form
{
    /// <summary>
    /// Raised when the user clicks the Stop button.
    /// </summary>
    public event EventHandler? StopRequested;

    private bool isCompleted;

    private readonly List<VersionEntry> versionEntries = [];
    private string lastPhaseDescription = "";
    private int activeVersionIndex = -1;
    private string activeKey = "";

    [GeneratedRegex(@"(?:win)?(?:rar|wr)(?:-x64|-x32)?-?(\d+)(b\d+)?", RegexOptions.IgnoreCase)]
    private static partial Regex VersionLabelRegex();

    private class VersionEntry
    {
        public required string VersionName { get; init; }
        public required string Arguments { get; init; }
        public string Status { get; set; } = "Testing";
    }

    public BruteForceProgressForm()
    {
        InitializeComponent();
        btnStop.Click += BtnStop_Click;
        FormClosing += BruteForceProgressForm_FormClosing;
        Load += (_, _) => CenterToParent();
        lvVersions.RetrieveVirtualItem += LvVersions_RetrieveVirtualItem;
    }

    private void LvVersions_RetrieveVirtualItem(object? sender, RetrieveVirtualItemEventArgs e)
    {
        if (e.ItemIndex < 0 || e.ItemIndex >= versionEntries.Count)
            return;

        var entry = versionEntries[e.ItemIndex];
        var item = new ListViewItem(entry.VersionName);
        item.SubItems.Add(entry.Status);
        item.SubItems.Add(entry.Arguments);
        e.Item = item;
    }

    /// <summary>
    /// Updates the overall brute-force progress (phase label, progress bar, timing, current version info).
    /// </summary>
    public void UpdateOverallProgress(BruteForceProgressEventArgs e)
    {
        if (InvokeRequired)
        {
            try { Invoke(() => UpdateOverallProgress(e)); } catch { }
            return;
        }

        // Phase label
        if (!string.IsNullOrEmpty(e.PhaseDescription))
        {
            lblPhase.Text = e.PhaseDescription;
        }

        // Overall progress bar
        int percent = (int)Math.Min(e.Progress, 100);
        pbOverall.Value = percent;
        lblOverallPercent.Text = $"{e.Progress:F1}%";
        lblOverallText.Text = $"Test {e.OperationProgressed:N0} of {e.OperationSize:N0}";

        // Current version detail
        string versionDirName = System.IO.Path.GetFileName(e.RARVersionDirectoryPath);
        string versionLabel = FormatVersionLabel(versionDirName);
        lblCurrentDetail.Text = $"{versionLabel}  \u2014  {e.RARCommandLineArguments}";

        // Version list tracking
        string phaseDesc = e.PhaseDescription ?? "";
        if (phaseDesc != lastPhaseDescription)
        {
            // Phase changed — reset version list
            versionEntries.Clear();
            activeVersionIndex = -1;
            activeKey = "";
            lastPhaseDescription = phaseDesc;
            lvVersions.VirtualListSize = 0;
        }

        string key = string.Concat(e.RARVersionDirectoryPath, "|", e.RARCommandLineArguments);
        if (key != activeKey)
        {
            // New test — mark previous as complete, add new entry
            if (activeVersionIndex >= 0 && activeVersionIndex < versionEntries.Count)
            {
                versionEntries[activeVersionIndex].Status = "Complete";
            }

            versionEntries.Add(new VersionEntry
            {
                VersionName = versionLabel,
                Arguments = e.RARCommandLineArguments,
            });
            activeVersionIndex = versionEntries.Count - 1;
            activeKey = key;
            lvVersions.VirtualListSize = versionEntries.Count;
            lvVersions.Invalidate();
            lvVersions.EnsureVisible(activeVersionIndex);
        }

        // Timing
        lblElapsed.Text = FormatTimeSpan(e.TimeElapsed);

        if (e.OperationProgressed > 0)
        {
            lblRemaining.Text = FormatTimeSpan(e.TimeRemaining);
            lblSpeed.Text = $"{e.OperationSpeed:N0} tests/s";
            lblETA.Text = e.EstimatedFinishDateTime.ToString("HH:mm:ss");
        }
    }

    /// <summary>
    /// Updates the sub-progress bar for file compression within a single RAR creation.
    /// </summary>
    public void UpdateSubProgress(RARCompressionProgressEventArgs e)
    {
        if (InvokeRequired)
        {
            try { Invoke(() => UpdateSubProgress(e)); } catch { }
            return;
        }

        int percent = (int)Math.Min(e.Progress, 100);
        pbSub.Value = percent;
        lblSubPercent.Text = $"{e.Progress:F1}%";

        string fileName = System.IO.Path.GetFileName(e.FilePath);
        int doubleSpace = fileName.IndexOf("  ", StringComparison.Ordinal);
        if (doubleSpace >= 0)
            fileName = fileName[..doubleSpace];
        if (fileName.Contains('.'))
        {
            lblSubText.Text = fileName;
        }
    }

    /// <summary>
    /// Shows the completed state (success or failure). Changes Stop button to Close.
    /// </summary>
    public void SetCompleted(bool success)
    {
        if (InvokeRequired)
        {
            try { Invoke(() => SetCompleted(success)); } catch { }
            return;
        }

        isCompleted = true;

        if (activeVersionIndex >= 0 && activeVersionIndex < versionEntries.Count)
        {
            versionEntries[activeVersionIndex].Status = "Complete";
            lvVersions.Invalidate();
        }

        if (success)
        {
            lblPhase.Text = "Complete — Match Found!";
            pbOverall.Value = 100;
            lblOverallPercent.Text = "100%";
        }
        else
        {
            lblPhase.Text = "Complete — No Match";
        }

        btnStop.Text = "Close";
    }

    private void BtnStop_Click(object? sender, EventArgs e)
    {
        if (isCompleted)
        {
            Close();
            return;
        }

        btnStop.Enabled = false;
        btnStop.Text = "Stopping...";
        StopRequested?.Invoke(this, EventArgs.Empty);
    }

    private void BruteForceProgressForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // If operation is still running, treat close as Stop request
        if (!isCompleted && e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            btnStop.Enabled = false;
            btnStop.Text = "Stopping...";
            StopRequested?.Invoke(this, EventArgs.Empty);
        }
    }

    private static string FormatVersionLabel(string dirName)
    {
        Match m = VersionLabelRegex().Match(dirName);
        if (!m.Success)
            return dirName;

        string digits = m.Groups[1].Value;
        string beta = m.Groups[2].Value; // e.g. "b3" or ""
        string versionStr = digits.Length >= 3
            ? $"{digits[..^2]}.{digits[^2..]}"
            : $"{digits[..^1]}.{digits[^1..]}";

        return $"WinRAR {versionStr}{beta}";
    }

    private static string FormatTimeSpan(TimeSpan ts)
    {
        if (ts.TotalHours >= 1)
        {
            return $"{(int)ts.TotalHours}:{ts.Minutes:D2}:{ts.Seconds:D2}";
        }
        return $"{ts.Minutes:D2}:{ts.Seconds:D2}";
    }
}
