namespace WinRARRed.Forms;

partial class SRRReconstructionForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tlpMain = new System.Windows.Forms.TableLayoutPanel();
        lblHeader = new System.Windows.Forms.Label();
        gbSrrInfo = new System.Windows.Forms.GroupBox();
        tlpSrrInfo = new System.Windows.Forms.TableLayoutPanel();
        lblPackerTypeLabel = new System.Windows.Forms.Label();
        lblPackerType = new System.Windows.Forms.Label();
        lblRarVolumesLabel = new System.Windows.Forms.Label();
        lblRarVolumes = new System.Windows.Forms.Label();
        lblArchivedFilesLabel = new System.Windows.Forms.Label();
        lblArchivedFiles = new System.Windows.Forms.Label();
        lblSrrPathLabel = new System.Windows.Forms.Label();
        lblSrrPath = new System.Windows.Forms.Label();
        gbInput = new System.Windows.Forms.GroupBox();
        tlpInput = new System.Windows.Forms.TableLayoutPanel();
        lblReleaseDir = new System.Windows.Forms.Label();
        tbReleaseDir = new System.Windows.Forms.TextBox();
        btnBrowseReleaseDir = new System.Windows.Forms.Button();
        lblOutputDir = new System.Windows.Forms.Label();
        tbOutputDir = new System.Windows.Forms.TextBox();
        btnBrowseOutputDir = new System.Windows.Forms.Button();
        lblVerificationFile = new System.Windows.Forms.Label();
        tbVerificationFile = new System.Windows.Forms.TextBox();
        btnBrowseVerificationFile = new System.Windows.Forms.Button();
        tlpProgress = new System.Windows.Forms.TableLayoutPanel();
        lblProgressText = new System.Windows.Forms.Label();
        lblProgressPercent = new System.Windows.Forms.Label();
        pbOverall = new System.Windows.Forms.ProgressBar();
        lblCurrentDetail = new System.Windows.Forms.Label();
        rtbLog = new System.Windows.Forms.RichTextBox();
        tlpButtons = new System.Windows.Forms.TableLayoutPanel();
        btnStart = new System.Windows.Forms.Button();
        btnClose = new System.Windows.Forms.Button();
        tlpMain.SuspendLayout();
        gbSrrInfo.SuspendLayout();
        tlpSrrInfo.SuspendLayout();
        gbInput.SuspendLayout();
        tlpInput.SuspendLayout();
        tlpProgress.SuspendLayout();
        tlpButtons.SuspendLayout();
        SuspendLayout();
        //
        // tlpMain
        //
        tlpMain.ColumnCount = 1;
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.Controls.Add(lblHeader, 0, 0);
        tlpMain.Controls.Add(gbSrrInfo, 0, 1);
        tlpMain.Controls.Add(gbInput, 0, 2);
        tlpMain.Controls.Add(tlpProgress, 0, 3);
        tlpMain.Controls.Add(pbOverall, 0, 4);
        tlpMain.Controls.Add(lblCurrentDetail, 0, 5);
        tlpMain.Controls.Add(rtbLog, 0, 6);
        tlpMain.Controls.Add(tlpButtons, 0, 7);
        tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpMain.Location = new System.Drawing.Point(0, 0);
        tlpMain.Name = "tlpMain";
        tlpMain.Padding = new System.Windows.Forms.Padding(12);
        tlpMain.RowCount = 8;
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.Size = new System.Drawing.Size(700, 600);
        tlpMain.TabIndex = 0;
        //
        // lblHeader
        //
        lblHeader.AutoSize = true;
        lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblHeader.Location = new System.Drawing.Point(15, 12);
        lblHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new System.Drawing.Size(200, 19);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "Direct SRR Reconstruction";
        //
        // gbSrrInfo
        //
        gbSrrInfo.AutoSize = true;
        gbSrrInfo.Controls.Add(tlpSrrInfo);
        gbSrrInfo.Dock = System.Windows.Forms.DockStyle.Fill;
        gbSrrInfo.Location = new System.Drawing.Point(15, 40);
        gbSrrInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
        gbSrrInfo.Name = "gbSrrInfo";
        gbSrrInfo.Padding = new System.Windows.Forms.Padding(6);
        gbSrrInfo.Size = new System.Drawing.Size(670, 120);
        gbSrrInfo.TabIndex = 1;
        gbSrrInfo.TabStop = false;
        gbSrrInfo.Text = "SRR Information";
        //
        // tlpSrrInfo
        //
        tlpSrrInfo.AutoSize = true;
        tlpSrrInfo.ColumnCount = 2;
        tlpSrrInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSrrInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSrrInfo.Controls.Add(lblPackerTypeLabel, 0, 0);
        tlpSrrInfo.Controls.Add(lblPackerType, 1, 0);
        tlpSrrInfo.Controls.Add(lblRarVolumesLabel, 0, 1);
        tlpSrrInfo.Controls.Add(lblRarVolumes, 1, 1);
        tlpSrrInfo.Controls.Add(lblArchivedFilesLabel, 0, 2);
        tlpSrrInfo.Controls.Add(lblArchivedFiles, 1, 2);
        tlpSrrInfo.Controls.Add(lblSrrPathLabel, 0, 3);
        tlpSrrInfo.Controls.Add(lblSrrPath, 1, 3);
        tlpSrrInfo.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpSrrInfo.Location = new System.Drawing.Point(6, 22);
        tlpSrrInfo.Margin = new System.Windows.Forms.Padding(0);
        tlpSrrInfo.Name = "tlpSrrInfo";
        tlpSrrInfo.RowCount = 4;
        tlpSrrInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSrrInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSrrInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSrrInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSrrInfo.Size = new System.Drawing.Size(658, 68);
        tlpSrrInfo.TabIndex = 0;
        //
        // lblPackerTypeLabel
        //
        lblPackerTypeLabel.AutoSize = true;
        lblPackerTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblPackerTypeLabel.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblPackerTypeLabel.Name = "lblPackerTypeLabel";
        lblPackerTypeLabel.Size = new System.Drawing.Size(78, 15);
        lblPackerTypeLabel.TabIndex = 0;
        lblPackerTypeLabel.Text = "Packer Type:";
        //
        // lblPackerType
        //
        lblPackerType.AutoSize = true;
        lblPackerType.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        lblPackerType.Name = "lblPackerType";
        lblPackerType.Size = new System.Drawing.Size(16, 15);
        lblPackerType.TabIndex = 1;
        lblPackerType.Text = "—";
        //
        // lblRarVolumesLabel
        //
        lblRarVolumesLabel.AutoSize = true;
        lblRarVolumesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblRarVolumesLabel.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblRarVolumesLabel.Name = "lblRarVolumesLabel";
        lblRarVolumesLabel.Size = new System.Drawing.Size(82, 15);
        lblRarVolumesLabel.TabIndex = 2;
        lblRarVolumesLabel.Text = "RAR Volumes:";
        //
        // lblRarVolumes
        //
        lblRarVolumes.AutoSize = true;
        lblRarVolumes.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        lblRarVolumes.Name = "lblRarVolumes";
        lblRarVolumes.Size = new System.Drawing.Size(16, 15);
        lblRarVolumes.TabIndex = 3;
        lblRarVolumes.Text = "—";
        //
        // lblArchivedFilesLabel
        //
        lblArchivedFilesLabel.AutoSize = true;
        lblArchivedFilesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblArchivedFilesLabel.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblArchivedFilesLabel.Name = "lblArchivedFilesLabel";
        lblArchivedFilesLabel.Size = new System.Drawing.Size(92, 15);
        lblArchivedFilesLabel.TabIndex = 4;
        lblArchivedFilesLabel.Text = "Archived Files:";
        //
        // lblArchivedFiles
        //
        lblArchivedFiles.AutoSize = true;
        lblArchivedFiles.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        lblArchivedFiles.Name = "lblArchivedFiles";
        lblArchivedFiles.Size = new System.Drawing.Size(16, 15);
        lblArchivedFiles.TabIndex = 5;
        lblArchivedFiles.Text = "—";
        //
        // lblSrrPathLabel
        //
        lblSrrPathLabel.AutoSize = true;
        lblSrrPathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        lblSrrPathLabel.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblSrrPathLabel.Name = "lblSrrPathLabel";
        lblSrrPathLabel.Size = new System.Drawing.Size(53, 15);
        lblSrrPathLabel.TabIndex = 6;
        lblSrrPathLabel.Text = "SRR File:";
        //
        // lblSrrPath
        //
        lblSrrPath.AutoSize = true;
        lblSrrPath.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        lblSrrPath.Name = "lblSrrPath";
        lblSrrPath.Size = new System.Drawing.Size(16, 15);
        lblSrrPath.TabIndex = 7;
        lblSrrPath.Text = "—";
        //
        // gbInput
        //
        gbInput.AutoSize = true;
        gbInput.Controls.Add(tlpInput);
        gbInput.Dock = System.Windows.Forms.DockStyle.Fill;
        gbInput.Location = new System.Drawing.Point(15, 169);
        gbInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
        gbInput.Name = "gbInput";
        gbInput.Padding = new System.Windows.Forms.Padding(6);
        gbInput.Size = new System.Drawing.Size(670, 110);
        gbInput.TabIndex = 2;
        gbInput.TabStop = false;
        gbInput.Text = "Input";
        //
        // tlpInput
        //
        tlpInput.AutoSize = true;
        tlpInput.ColumnCount = 3;
        tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.Controls.Add(lblReleaseDir, 0, 0);
        tlpInput.Controls.Add(tbReleaseDir, 1, 0);
        tlpInput.Controls.Add(btnBrowseReleaseDir, 2, 0);
        tlpInput.Controls.Add(lblOutputDir, 0, 1);
        tlpInput.Controls.Add(tbOutputDir, 1, 1);
        tlpInput.Controls.Add(btnBrowseOutputDir, 2, 1);
        tlpInput.Controls.Add(lblVerificationFile, 0, 2);
        tlpInput.Controls.Add(tbVerificationFile, 1, 2);
        tlpInput.Controls.Add(btnBrowseVerificationFile, 2, 2);
        tlpInput.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpInput.Location = new System.Drawing.Point(6, 22);
        tlpInput.Margin = new System.Windows.Forms.Padding(0);
        tlpInput.Name = "tlpInput";
        tlpInput.RowCount = 3;
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.Size = new System.Drawing.Size(658, 84);
        tlpInput.TabIndex = 0;
        //
        // lblReleaseDir
        //
        lblReleaseDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblReleaseDir.AutoSize = true;
        lblReleaseDir.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblReleaseDir.Name = "lblReleaseDir";
        lblReleaseDir.Size = new System.Drawing.Size(101, 15);
        lblReleaseDir.TabIndex = 0;
        lblReleaseDir.Text = "Release Directory:";
        //
        // tbReleaseDir
        //
        tbReleaseDir.Dock = System.Windows.Forms.DockStyle.Fill;
        tbReleaseDir.Location = new System.Drawing.Point(112, 3);
        tbReleaseDir.Name = "tbReleaseDir";
        tbReleaseDir.Size = new System.Drawing.Size(506, 23);
        tbReleaseDir.TabIndex = 1;
        //
        // btnBrowseReleaseDir
        //
        btnBrowseReleaseDir.AutoSize = true;
        btnBrowseReleaseDir.Location = new System.Drawing.Point(624, 3);
        btnBrowseReleaseDir.Name = "btnBrowseReleaseDir";
        btnBrowseReleaseDir.Size = new System.Drawing.Size(31, 23);
        btnBrowseReleaseDir.TabIndex = 2;
        btnBrowseReleaseDir.Text = "...";
        btnBrowseReleaseDir.UseVisualStyleBackColor = true;
        //
        // lblOutputDir
        //
        lblOutputDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblOutputDir.AutoSize = true;
        lblOutputDir.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblOutputDir.Name = "lblOutputDir";
        lblOutputDir.Size = new System.Drawing.Size(100, 15);
        lblOutputDir.TabIndex = 3;
        lblOutputDir.Text = "Output Directory:";
        //
        // tbOutputDir
        //
        tbOutputDir.Dock = System.Windows.Forms.DockStyle.Fill;
        tbOutputDir.Location = new System.Drawing.Point(112, 32);
        tbOutputDir.Name = "tbOutputDir";
        tbOutputDir.Size = new System.Drawing.Size(506, 23);
        tbOutputDir.TabIndex = 4;
        //
        // btnBrowseOutputDir
        //
        btnBrowseOutputDir.AutoSize = true;
        btnBrowseOutputDir.Location = new System.Drawing.Point(624, 32);
        btnBrowseOutputDir.Name = "btnBrowseOutputDir";
        btnBrowseOutputDir.Size = new System.Drawing.Size(31, 23);
        btnBrowseOutputDir.TabIndex = 5;
        btnBrowseOutputDir.Text = "...";
        btnBrowseOutputDir.UseVisualStyleBackColor = true;
        //
        // lblVerificationFile
        //
        lblVerificationFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblVerificationFile.AutoSize = true;
        lblVerificationFile.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
        lblVerificationFile.Name = "lblVerificationFile";
        lblVerificationFile.Size = new System.Drawing.Size(96, 15);
        lblVerificationFile.TabIndex = 6;
        lblVerificationFile.Text = "Verification File:";
        //
        // tbVerificationFile
        //
        tbVerificationFile.Dock = System.Windows.Forms.DockStyle.Fill;
        tbVerificationFile.Location = new System.Drawing.Point(112, 61);
        tbVerificationFile.Name = "tbVerificationFile";
        tbVerificationFile.Size = new System.Drawing.Size(506, 23);
        tbVerificationFile.TabIndex = 7;
        //
        // btnBrowseVerificationFile
        //
        btnBrowseVerificationFile.AutoSize = true;
        btnBrowseVerificationFile.Location = new System.Drawing.Point(624, 61);
        btnBrowseVerificationFile.Name = "btnBrowseVerificationFile";
        btnBrowseVerificationFile.Size = new System.Drawing.Size(31, 23);
        btnBrowseVerificationFile.TabIndex = 8;
        btnBrowseVerificationFile.Text = "...";
        btnBrowseVerificationFile.UseVisualStyleBackColor = true;
        //
        // tlpProgress
        //
        tlpProgress.AutoSize = true;
        tlpProgress.ColumnCount = 2;
        tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpProgress.Controls.Add(lblProgressText, 0, 0);
        tlpProgress.Controls.Add(lblProgressPercent, 1, 0);
        tlpProgress.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpProgress.Location = new System.Drawing.Point(12, 288);
        tlpProgress.Margin = new System.Windows.Forms.Padding(0);
        tlpProgress.Name = "tlpProgress";
        tlpProgress.RowCount = 1;
        tlpProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpProgress.Size = new System.Drawing.Size(676, 15);
        tlpProgress.TabIndex = 3;
        //
        // lblProgressText
        //
        lblProgressText.AutoSize = true;
        lblProgressText.Location = new System.Drawing.Point(0, 0);
        lblProgressText.Margin = new System.Windows.Forms.Padding(0);
        lblProgressText.Name = "lblProgressText";
        lblProgressText.Size = new System.Drawing.Size(82, 15);
        lblProgressText.TabIndex = 0;
        lblProgressText.Text = "Volume 0 of 0";
        //
        // lblProgressPercent
        //
        lblProgressPercent.AutoSize = true;
        lblProgressPercent.Location = new System.Drawing.Point(643, 0);
        lblProgressPercent.Margin = new System.Windows.Forms.Padding(0);
        lblProgressPercent.Name = "lblProgressPercent";
        lblProgressPercent.Size = new System.Drawing.Size(33, 15);
        lblProgressPercent.TabIndex = 1;
        lblProgressPercent.Text = "0.0%";
        //
        // pbOverall
        //
        pbOverall.Dock = System.Windows.Forms.DockStyle.Fill;
        pbOverall.Location = new System.Drawing.Point(15, 306);
        pbOverall.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
        pbOverall.Name = "pbOverall";
        pbOverall.Size = new System.Drawing.Size(670, 23);
        pbOverall.TabIndex = 4;
        //
        // lblCurrentDetail
        //
        lblCurrentDetail.AutoSize = true;
        lblCurrentDetail.ForeColor = System.Drawing.SystemColors.GrayText;
        lblCurrentDetail.Location = new System.Drawing.Point(15, 337);
        lblCurrentDetail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
        lblCurrentDetail.Name = "lblCurrentDetail";
        lblCurrentDetail.Size = new System.Drawing.Size(16, 15);
        lblCurrentDetail.TabIndex = 5;
        lblCurrentDetail.Text = "\u2014";
        //
        // rtbLog
        //
        rtbLog.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
        rtbLog.Font = new System.Drawing.Font("Consolas", 9F);
        rtbLog.ForeColor = System.Drawing.Color.FromArgb(212, 212, 212);
        rtbLog.Location = new System.Drawing.Point(15, 361);
        rtbLog.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
        rtbLog.Name = "rtbLog";
        rtbLog.ReadOnly = true;
        rtbLog.Size = new System.Drawing.Size(670, 180);
        rtbLog.TabIndex = 6;
        rtbLog.Text = "";
        //
        // tlpButtons
        //
        tlpButtons.AutoSize = true;
        tlpButtons.ColumnCount = 3;
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpButtons.Controls.Add(btnStart, 1, 0);
        tlpButtons.Controls.Add(btnClose, 2, 0);
        tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpButtons.Location = new System.Drawing.Point(12, 550);
        tlpButtons.Margin = new System.Windows.Forms.Padding(0);
        tlpButtons.Name = "tlpButtons";
        tlpButtons.RowCount = 1;
        tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpButtons.Size = new System.Drawing.Size(676, 38);
        tlpButtons.TabIndex = 7;
        //
        // btnStart
        //
        btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnStart.Location = new System.Drawing.Point(504, 6);
        btnStart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(83, 29);
        btnStart.TabIndex = 0;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        //
        // btnClose
        //
        btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnClose.Enabled = false;
        btnClose.Location = new System.Drawing.Point(593, 6);
        btnClose.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new System.Drawing.Size(83, 29);
        btnClose.TabIndex = 1;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        //
        // SRRReconstructionForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        ClientSize = new System.Drawing.Size(700, 600);
        Controls.Add(tlpMain);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(550, 450);
        Name = "SRRReconstructionForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "SRR Reconstruction";
        tlpMain.ResumeLayout(false);
        tlpMain.PerformLayout();
        gbSrrInfo.ResumeLayout(false);
        gbSrrInfo.PerformLayout();
        tlpSrrInfo.ResumeLayout(false);
        tlpSrrInfo.PerformLayout();
        gbInput.ResumeLayout(false);
        gbInput.PerformLayout();
        tlpInput.ResumeLayout(false);
        tlpInput.PerformLayout();
        tlpProgress.ResumeLayout(false);
        tlpProgress.PerformLayout();
        tlpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.GroupBox gbSrrInfo;
    private System.Windows.Forms.TableLayoutPanel tlpSrrInfo;
    private System.Windows.Forms.Label lblPackerTypeLabel;
    private System.Windows.Forms.Label lblPackerType;
    private System.Windows.Forms.Label lblRarVolumesLabel;
    private System.Windows.Forms.Label lblRarVolumes;
    private System.Windows.Forms.Label lblArchivedFilesLabel;
    private System.Windows.Forms.Label lblArchivedFiles;
    private System.Windows.Forms.Label lblSrrPathLabel;
    private System.Windows.Forms.Label lblSrrPath;
    private System.Windows.Forms.GroupBox gbInput;
    private System.Windows.Forms.TableLayoutPanel tlpInput;
    private System.Windows.Forms.Label lblReleaseDir;
    private System.Windows.Forms.TextBox tbReleaseDir;
    private System.Windows.Forms.Button btnBrowseReleaseDir;
    private System.Windows.Forms.Label lblOutputDir;
    private System.Windows.Forms.TextBox tbOutputDir;
    private System.Windows.Forms.Button btnBrowseOutputDir;
    private System.Windows.Forms.Label lblVerificationFile;
    private System.Windows.Forms.TextBox tbVerificationFile;
    private System.Windows.Forms.Button btnBrowseVerificationFile;
    private System.Windows.Forms.TableLayoutPanel tlpProgress;
    private System.Windows.Forms.Label lblProgressText;
    private System.Windows.Forms.Label lblProgressPercent;
    private System.Windows.Forms.ProgressBar pbOverall;
    private System.Windows.Forms.Label lblCurrentDetail;
    private System.Windows.Forms.RichTextBox rtbLog;
    private System.Windows.Forms.TableLayoutPanel tlpButtons;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnClose;
}
