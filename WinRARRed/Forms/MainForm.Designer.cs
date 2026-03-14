namespace WinRARRed.Forms;

partial class MainForm
{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
        tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
        tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
        tsmiToolsFileInspector = new System.Windows.Forms.ToolStripMenuItem();
        tsmiToolsFileCompare = new System.Windows.Forms.ToolStripMenuItem();
        tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
        tsmiSettingsOptions = new System.Windows.Forms.ToolStripMenuItem();
        statusStrip = new System.Windows.Forms.StatusStrip();
        tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
        tsslProgress = new System.Windows.Forms.ToolStripStatusLabel();
        tsslElapsed = new System.Windows.Forms.ToolStripStatusLabel();
        panelInput = new System.Windows.Forms.Panel();
        tlpInput = new System.Windows.Forms.TableLayoutPanel();
        lblWinRARDirectory = new System.Windows.Forms.Label();
        tbWinRARDirectory = new System.Windows.Forms.TextBox();
        btnWinRARDirectoryBrowse = new System.Windows.Forms.Button();
        flpWinRARInfo = new System.Windows.Forms.FlowLayoutPanel();
        lblWinRARInfo = new System.Windows.Forms.Label();
        lblWinRARGet = new System.Windows.Forms.Label();
        linkLabel1 = new System.Windows.Forms.LinkLabel();
        linkLabel2 = new System.Windows.Forms.LinkLabel();
        lblReleaseDirectory = new System.Windows.Forms.Label();
        tbReleaseDirectory = new System.Windows.Forms.TextBox();
        btnReleaseDirectoryBrowse = new System.Windows.Forms.Button();
        lblVerificationFile = new System.Windows.Forms.Label();
        tbVerificationFilePath = new System.Windows.Forms.TextBox();
        btnVerificationFileBrowse = new System.Windows.Forms.Button();
        lblOutputDirectory = new System.Windows.Forms.Label();
        tbOutputDirectory = new System.Windows.Forms.TextBox();
        btnTemporaryDirectoryBrowse = new System.Windows.Forms.Button();
        lblOutputWarning = new System.Windows.Forms.Label();
        btnStart = new System.Windows.Forms.Button();
        gbLog = new System.Windows.Forms.GroupBox();
        tabControlLogs = new System.Windows.Forms.TabControl();
        tabPageSystem = new System.Windows.Forms.TabPage();
        rtbLogSystem = new System.Windows.Forms.RichTextBox();
        tabPagePhase1 = new System.Windows.Forms.TabPage();
        rtbLogPhase1 = new System.Windows.Forms.RichTextBox();
        tabPagePhase2 = new System.Windows.Forms.TabPage();
        rtbLogPhase2 = new System.Windows.Forms.RichTextBox();
        panelLogToolbar = new System.Windows.Forms.Panel();
        btnClearLog = new System.Windows.Forms.Button();
        cbAutoScroll = new System.Windows.Forms.CheckBox();
        menuStrip1.SuspendLayout();
        statusStrip.SuspendLayout();
        panelInput.SuspendLayout();
        tlpInput.SuspendLayout();
        flpWinRARInfo.SuspendLayout();
        gbLog.SuspendLayout();
        tabControlLogs.SuspendLayout();
        tabPageSystem.SuspendLayout();
        tabPagePhase1.SuspendLayout();
        tabPagePhase2.SuspendLayout();
        panelLogToolbar.SuspendLayout();
        SuspendLayout();
        //
        // menuStrip1
        //
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiFile, tsmiTools, tsmiSettings });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(1488, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        //
        // tsmiFile
        //
        tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiFileExit });
        tsmiFile.Name = "tsmiFile";
        tsmiFile.Size = new System.Drawing.Size(37, 20);
        tsmiFile.Text = "&File";
        //
        // tsmiFileExit
        //
        tsmiFileExit.Name = "tsmiFileExit";
        tsmiFileExit.Size = new System.Drawing.Size(93, 22);
        tsmiFileExit.Text = "E&xit";
        //
        // tsmiTools
        //
        tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiToolsFileInspector, tsmiToolsFileCompare });
        tsmiTools.Name = "tsmiTools";
        tsmiTools.Size = new System.Drawing.Size(46, 20);
        tsmiTools.Text = "&Tools";
        //
        // tsmiToolsFileInspector
        //
        tsmiToolsFileInspector.Name = "tsmiToolsFileInspector";
        tsmiToolsFileInspector.ShortcutKeys = System.Windows.Forms.Keys.F12;
        tsmiToolsFileInspector.Size = new System.Drawing.Size(195, 22);
        tsmiToolsFileInspector.Text = "File &Inspector...";
        tsmiToolsFileInspector.Click += tsmiToolsFileInspector_Click;
        //
        // tsmiToolsFileCompare
        //
        tsmiToolsFileCompare.Name = "tsmiToolsFileCompare";
        tsmiToolsFileCompare.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D;
        tsmiToolsFileCompare.Size = new System.Drawing.Size(195, 22);
        tsmiToolsFileCompare.Text = "File &Compare...";
        tsmiToolsFileCompare.Click += tsmiToolsFileCompare_Click;
        //
        // tsmiSettings
        //
        tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiSettingsOptions });
        tsmiSettings.Name = "tsmiSettings";
        tsmiSettings.Size = new System.Drawing.Size(61, 20);
        tsmiSettings.Text = "&Settings";
        //
        // tsmiSettingsOptions
        //
        tsmiSettingsOptions.Name = "tsmiSettingsOptions";
        tsmiSettingsOptions.Size = new System.Drawing.Size(116, 22);
        tsmiSettingsOptions.Text = "&Options";
        //
        // statusStrip
        //
        statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsslStatus, tsslProgress, tsslElapsed });
        statusStrip.Location = new System.Drawing.Point(0, 784);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(1488, 22);
        statusStrip.TabIndex = 2;
        //
        // tsslStatus
        //
        tsslStatus.Name = "tsslStatus";
        tsslStatus.Size = new System.Drawing.Size(39, 17);
        tsslStatus.Text = "Ready";
        //
        // tsslProgress
        //
        tsslProgress.Name = "tsslProgress";
        tsslProgress.Size = new System.Drawing.Size(1385, 17);
        tsslProgress.Spring = true;
        tsslProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // tsslElapsed
        //
        tsslElapsed.Name = "tsslElapsed";
        tsslElapsed.Size = new System.Drawing.Size(49, 17);
        tsslElapsed.Text = "00:00:00";
        //
        // panelInput
        //
        panelInput.Controls.Add(tlpInput);
        panelInput.Dock = System.Windows.Forms.DockStyle.Top;
        panelInput.Location = new System.Drawing.Point(0, 24);
        panelInput.Name = "panelInput";
        panelInput.Size = new System.Drawing.Size(1488, 175);
        panelInput.TabIndex = 1;
        //
        // tlpInput
        //
        tlpInput.ColumnCount = 3;
        tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.Controls.Add(lblWinRARDirectory, 0, 0);
        tlpInput.Controls.Add(tbWinRARDirectory, 1, 0);
        tlpInput.Controls.Add(btnWinRARDirectoryBrowse, 2, 0);
        tlpInput.Controls.Add(flpWinRARInfo, 0, 1);
        tlpInput.Controls.Add(lblReleaseDirectory, 0, 2);
        tlpInput.Controls.Add(tbReleaseDirectory, 1, 2);
        tlpInput.Controls.Add(btnReleaseDirectoryBrowse, 2, 2);
        tlpInput.Controls.Add(lblVerificationFile, 0, 3);
        tlpInput.Controls.Add(tbVerificationFilePath, 1, 3);
        tlpInput.Controls.Add(btnVerificationFileBrowse, 2, 3);
        tlpInput.Controls.Add(lblOutputDirectory, 0, 4);
        tlpInput.Controls.Add(tbOutputDirectory, 1, 4);
        tlpInput.Controls.Add(btnTemporaryDirectoryBrowse, 2, 4);
        tlpInput.Controls.Add(lblOutputWarning, 0, 5);
        tlpInput.Controls.Add(btnStart, 2, 5);
        tlpInput.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpInput.Location = new System.Drawing.Point(0, 0);
        tlpInput.Name = "tlpInput";
        tlpInput.Padding = new System.Windows.Forms.Padding(8);
        tlpInput.RowCount = 6;
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpInput.Size = new System.Drawing.Size(1488, 175);
        tlpInput.TabIndex = 0;
        tlpInput.SetColumnSpan(flpWinRARInfo, 3);
        tlpInput.SetColumnSpan(lblOutputWarning, 2);
        //
        // lblWinRARDirectory
        //
        lblWinRARDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblWinRARDirectory.AutoSize = true;
        lblWinRARDirectory.Location = new System.Drawing.Point(11, 14);
        lblWinRARDirectory.Name = "lblWinRARDirectory";
        lblWinRARDirectory.Size = new System.Drawing.Size(110, 15);
        lblWinRARDirectory.TabIndex = 0;
        lblWinRARDirectory.Text = "WinRAR Directory:";
        //
        // tbWinRARDirectory
        //
        tbWinRARDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tbWinRARDirectory.Location = new System.Drawing.Point(127, 11);
        tbWinRARDirectory.Name = "tbWinRARDirectory";
        tbWinRARDirectory.Size = new System.Drawing.Size(1265, 23);
        tbWinRARDirectory.TabIndex = 1;
        tbWinRARDirectory.Text = "G:\\WinRAR\\extracted";
        //
        // btnWinRARDirectoryBrowse
        //
        btnWinRARDirectoryBrowse.Location = new System.Drawing.Point(1398, 11);
        btnWinRARDirectoryBrowse.Name = "btnWinRARDirectoryBrowse";
        btnWinRARDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
        btnWinRARDirectoryBrowse.TabIndex = 2;
        btnWinRARDirectoryBrowse.Text = "Browse";
        btnWinRARDirectoryBrowse.UseVisualStyleBackColor = true;
        //
        // flpWinRARInfo
        //
        flpWinRARInfo.AutoSize = true;
        flpWinRARInfo.Controls.Add(lblWinRARInfo);
        flpWinRARInfo.Controls.Add(lblWinRARGet);
        flpWinRARInfo.Controls.Add(linkLabel1);
        flpWinRARInfo.Controls.Add(linkLabel2);
        flpWinRARInfo.Location = new System.Drawing.Point(11, 37);
        flpWinRARInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
        flpWinRARInfo.Name = "flpWinRARInfo";
        flpWinRARInfo.Size = new System.Drawing.Size(556, 15);
        flpWinRARInfo.TabIndex = 3;
        //
        // lblWinRARInfo
        //
        lblWinRARInfo.AutoSize = true;
        lblWinRARInfo.Location = new System.Drawing.Point(0, 0);
        lblWinRARInfo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
        lblWinRARInfo.Name = "lblWinRARInfo";
        lblWinRARInfo.Size = new System.Drawing.Size(248, 15);
        lblWinRARInfo.TabIndex = 0;
        lblWinRARInfo.Text = "Directory with extracted WinRAR installations.";
        //
        // lblWinRARGet
        //
        lblWinRARGet.AutoSize = true;
        lblWinRARGet.Location = new System.Drawing.Point(254, 0);
        lblWinRARGet.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
        lblWinRARGet.Name = "lblWinRARGet";
        lblWinRARGet.Size = new System.Drawing.Size(28, 15);
        lblWinRARGet.TabIndex = 1;
        lblWinRARGet.Text = "Get:";
        //
        // linkLabel1
        //
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new System.Drawing.Point(285, 0);
        linkLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new System.Drawing.Size(80, 15);
        linkLabel1.TabIndex = 2;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "extracted files";
        linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
        //
        // linkLabel2
        //
        linkLabel2.AutoSize = true;
        linkLabel2.Location = new System.Drawing.Point(368, 0);
        linkLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
        linkLabel2.Name = "linkLabel2";
        linkLabel2.Size = new System.Drawing.Size(147, 15);
        linkLabel2.TabIndex = 3;
        linkLabel2.TabStop = true;
        linkLabel2.Text = "(original files from rar FTP)";
        linkLabel2.LinkClicked += LinkLabel2_LinkClicked;
        //
        // lblReleaseDirectory
        //
        lblReleaseDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblReleaseDirectory.AutoSize = true;
        lblReleaseDirectory.Location = new System.Drawing.Point(11, 61);
        lblReleaseDirectory.Name = "lblReleaseDirectory";
        lblReleaseDirectory.Size = new System.Drawing.Size(106, 15);
        lblReleaseDirectory.TabIndex = 4;
        lblReleaseDirectory.Text = "Release Directory:";
        //
        // tbReleaseDirectory
        //
        tbReleaseDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tbReleaseDirectory.Location = new System.Drawing.Point(127, 58);
        tbReleaseDirectory.Name = "tbReleaseDirectory";
        tbReleaseDirectory.Size = new System.Drawing.Size(1265, 23);
        tbReleaseDirectory.TabIndex = 5;
        tbReleaseDirectory.Text = "G:\\WinRAR\\release";
        //
        // btnReleaseDirectoryBrowse
        //
        btnReleaseDirectoryBrowse.Location = new System.Drawing.Point(1398, 57);
        btnReleaseDirectoryBrowse.Name = "btnReleaseDirectoryBrowse";
        btnReleaseDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
        btnReleaseDirectoryBrowse.TabIndex = 6;
        btnReleaseDirectoryBrowse.Text = "Browse";
        btnReleaseDirectoryBrowse.UseVisualStyleBackColor = true;
        //
        // lblVerificationFile
        //
        lblVerificationFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblVerificationFile.AutoSize = true;
        lblVerificationFile.Location = new System.Drawing.Point(11, 90);
        lblVerificationFile.Name = "lblVerificationFile";
        lblVerificationFile.Size = new System.Drawing.Size(95, 15);
        lblVerificationFile.TabIndex = 7;
        lblVerificationFile.Text = "Verification File:";
        //
        // tbVerificationFilePath
        //
        tbVerificationFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tbVerificationFilePath.Location = new System.Drawing.Point(127, 87);
        tbVerificationFilePath.Name = "tbVerificationFilePath";
        tbVerificationFilePath.Size = new System.Drawing.Size(1265, 23);
        tbVerificationFilePath.TabIndex = 8;
        tbVerificationFilePath.Text = "D:\\ali.g-dmt.sfv";
        //
        // btnVerificationFileBrowse
        //
        btnVerificationFileBrowse.Location = new System.Drawing.Point(1398, 86);
        btnVerificationFileBrowse.Name = "btnVerificationFileBrowse";
        btnVerificationFileBrowse.Size = new System.Drawing.Size(75, 23);
        btnVerificationFileBrowse.TabIndex = 9;
        btnVerificationFileBrowse.Text = "Browse";
        btnVerificationFileBrowse.UseVisualStyleBackColor = true;
        //
        // lblOutputDirectory
        //
        lblOutputDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblOutputDirectory.AutoSize = true;
        lblOutputDirectory.Location = new System.Drawing.Point(11, 119);
        lblOutputDirectory.Name = "lblOutputDirectory";
        lblOutputDirectory.Size = new System.Drawing.Size(104, 15);
        lblOutputDirectory.TabIndex = 10;
        lblOutputDirectory.Text = "Output Directory:";
        //
        // tbOutputDirectory
        //
        tbOutputDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tbOutputDirectory.Location = new System.Drawing.Point(127, 116);
        tbOutputDirectory.Name = "tbOutputDirectory";
        tbOutputDirectory.Size = new System.Drawing.Size(1265, 23);
        tbOutputDirectory.TabIndex = 11;
        tbOutputDirectory.Text = "G:\\Temp";
        //
        // btnTemporaryDirectoryBrowse
        //
        btnTemporaryDirectoryBrowse.Location = new System.Drawing.Point(1398, 115);
        btnTemporaryDirectoryBrowse.Name = "btnTemporaryDirectoryBrowse";
        btnTemporaryDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
        btnTemporaryDirectoryBrowse.TabIndex = 12;
        btnTemporaryDirectoryBrowse.Text = "Browse";
        btnTemporaryDirectoryBrowse.UseVisualStyleBackColor = true;
        //
        // lblOutputWarning
        //
        lblOutputWarning.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblOutputWarning.AutoSize = true;
        lblOutputWarning.ForeColor = System.Drawing.Color.FromArgb(200, 40, 40);
        lblOutputWarning.Location = new System.Drawing.Point(11, 147);
        lblOutputWarning.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
        lblOutputWarning.Name = "lblOutputWarning";
        lblOutputWarning.Size = new System.Drawing.Size(394, 15);
        lblOutputWarning.TabIndex = 13;
        lblOutputWarning.Text = "WARNING: All existing data in this directory will be deleted when starting!";
        //
        // btnStart
        //
        btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
        btnStart.Location = new System.Drawing.Point(1398, 143);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(75, 28);
        btnStart.TabIndex = 14;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        //
        // gbLog
        //
        gbLog.Controls.Add(tabControlLogs);
        gbLog.Controls.Add(panelLogToolbar);
        gbLog.Dock = System.Windows.Forms.DockStyle.Fill;
        gbLog.Location = new System.Drawing.Point(0, 199);
        gbLog.Name = "gbLog";
        gbLog.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
        gbLog.Size = new System.Drawing.Size(1488, 585);
        gbLog.TabIndex = 3;
        gbLog.TabStop = false;
        gbLog.Text = "Log";
        //
        // panelLogToolbar
        //
        panelLogToolbar.Controls.Add(cbAutoScroll);
        panelLogToolbar.Controls.Add(btnClearLog);
        panelLogToolbar.Dock = System.Windows.Forms.DockStyle.Top;
        panelLogToolbar.Name = "panelLogToolbar";
        panelLogToolbar.Size = new System.Drawing.Size(1476, 28);
        panelLogToolbar.TabIndex = 0;
        //
        // cbAutoScroll
        //
        cbAutoScroll.AutoSize = true;
        cbAutoScroll.Checked = true;
        cbAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
        cbAutoScroll.Location = new System.Drawing.Point(3, 4);
        cbAutoScroll.Name = "cbAutoScroll";
        cbAutoScroll.Size = new System.Drawing.Size(83, 19);
        cbAutoScroll.TabIndex = 0;
        cbAutoScroll.Text = "Auto scroll";
        cbAutoScroll.UseVisualStyleBackColor = true;
        //
        // btnClearLog
        //
        btnClearLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnClearLog.Location = new System.Drawing.Point(1398, 2);
        btnClearLog.Name = "btnClearLog";
        btnClearLog.Size = new System.Drawing.Size(75, 23);
        btnClearLog.TabIndex = 1;
        btnClearLog.Text = "Clear log";
        btnClearLog.UseVisualStyleBackColor = true;
        //
        // tabControlLogs
        //
        tabControlLogs.Controls.Add(tabPageSystem);
        tabControlLogs.Controls.Add(tabPagePhase1);
        tabControlLogs.Controls.Add(tabPagePhase2);
        tabControlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControlLogs.Name = "tabControlLogs";
        tabControlLogs.SelectedIndex = 0;
        tabControlLogs.TabIndex = 1;
        //
        // tabPageSystem
        //
        tabPageSystem.Controls.Add(rtbLogSystem);
        tabPageSystem.Location = new System.Drawing.Point(4, 24);
        tabPageSystem.Name = "tabPageSystem";
        tabPageSystem.Padding = new System.Windows.Forms.Padding(3);
        tabPageSystem.Size = new System.Drawing.Size(1468, 535);
        tabPageSystem.TabIndex = 0;
        tabPageSystem.Text = "System";
        tabPageSystem.UseVisualStyleBackColor = true;
        //
        // rtbLogSystem
        //
        rtbLogSystem.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        rtbLogSystem.Dock = System.Windows.Forms.DockStyle.Fill;
        rtbLogSystem.Font = new System.Drawing.Font("Consolas", 9F);
        rtbLogSystem.ForeColor = System.Drawing.Color.FromArgb(212, 212, 212);
        rtbLogSystem.Location = new System.Drawing.Point(3, 3);
        rtbLogSystem.Name = "rtbLogSystem";
        rtbLogSystem.ReadOnly = true;
        rtbLogSystem.Size = new System.Drawing.Size(1462, 529);
        rtbLogSystem.TabIndex = 0;
        rtbLogSystem.Text = "";
        rtbLogSystem.WordWrap = false;
        //
        // tabPagePhase1
        //
        tabPagePhase1.Controls.Add(rtbLogPhase1);
        tabPagePhase1.Location = new System.Drawing.Point(4, 24);
        tabPagePhase1.Name = "tabPagePhase1";
        tabPagePhase1.Padding = new System.Windows.Forms.Padding(3);
        tabPagePhase1.Size = new System.Drawing.Size(1468, 535);
        tabPagePhase1.TabIndex = 1;
        tabPagePhase1.Text = "Phase 1 (Comment)";
        tabPagePhase1.UseVisualStyleBackColor = true;
        //
        // rtbLogPhase1
        //
        rtbLogPhase1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        rtbLogPhase1.Dock = System.Windows.Forms.DockStyle.Fill;
        rtbLogPhase1.Font = new System.Drawing.Font("Consolas", 9F);
        rtbLogPhase1.ForeColor = System.Drawing.Color.FromArgb(212, 212, 212);
        rtbLogPhase1.Location = new System.Drawing.Point(3, 3);
        rtbLogPhase1.Name = "rtbLogPhase1";
        rtbLogPhase1.ReadOnly = true;
        rtbLogPhase1.Size = new System.Drawing.Size(1462, 529);
        rtbLogPhase1.TabIndex = 0;
        rtbLogPhase1.Text = "";
        rtbLogPhase1.WordWrap = false;
        //
        // tabPagePhase2
        //
        tabPagePhase2.Controls.Add(rtbLogPhase2);
        tabPagePhase2.Location = new System.Drawing.Point(4, 24);
        tabPagePhase2.Name = "tabPagePhase2";
        tabPagePhase2.Padding = new System.Windows.Forms.Padding(3);
        tabPagePhase2.Size = new System.Drawing.Size(1468, 535);
        tabPagePhase2.TabIndex = 2;
        tabPagePhase2.Text = "Phase 2 (Full RAR)";
        tabPagePhase2.UseVisualStyleBackColor = true;
        //
        // rtbLogPhase2
        //
        rtbLogPhase2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        rtbLogPhase2.Dock = System.Windows.Forms.DockStyle.Fill;
        rtbLogPhase2.Font = new System.Drawing.Font("Consolas", 9F);
        rtbLogPhase2.ForeColor = System.Drawing.Color.FromArgb(212, 212, 212);
        rtbLogPhase2.Location = new System.Drawing.Point(3, 3);
        rtbLogPhase2.Name = "rtbLogPhase2";
        rtbLogPhase2.ReadOnly = true;
        rtbLogPhase2.Size = new System.Drawing.Size(1462, 529);
        rtbLogPhase2.TabIndex = 0;
        rtbLogPhase2.Text = "";
        rtbLogPhase2.WordWrap = false;
        //
        // MainForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        ClientSize = new System.Drawing.Size(1488, 806);
        Controls.Add(gbLog);
        Controls.Add(panelInput);
        Controls.Add(statusStrip);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "MainForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "WinRARRed";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        panelInput.ResumeLayout(false);
        tlpInput.ResumeLayout(false);
        tlpInput.PerformLayout();
        flpWinRARInfo.ResumeLayout(false);
        flpWinRARInfo.PerformLayout();
        gbLog.ResumeLayout(false);
        panelLogToolbar.ResumeLayout(false);
        panelLogToolbar.PerformLayout();
        tabControlLogs.ResumeLayout(false);
        tabPageSystem.ResumeLayout(false);
        tabPagePhase1.ResumeLayout(false);
        tabPagePhase2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem tsmiFile;
    private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
    private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
    private System.Windows.Forms.ToolStripMenuItem tsmiSettingsOptions;
    private System.Windows.Forms.ToolStripMenuItem tsmiTools;
    private System.Windows.Forms.ToolStripMenuItem tsmiToolsFileInspector;
    private System.Windows.Forms.ToolStripMenuItem tsmiToolsFileCompare;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    private System.Windows.Forms.ToolStripStatusLabel tsslProgress;
    private System.Windows.Forms.ToolStripStatusLabel tsslElapsed;
    private System.Windows.Forms.Panel panelInput;
    private System.Windows.Forms.TableLayoutPanel tlpInput;
    private System.Windows.Forms.Label lblWinRARDirectory;
    private System.Windows.Forms.TextBox tbWinRARDirectory;
    private System.Windows.Forms.Button btnWinRARDirectoryBrowse;
    private System.Windows.Forms.FlowLayoutPanel flpWinRARInfo;
    private System.Windows.Forms.Label lblWinRARInfo;
    private System.Windows.Forms.Label lblWinRARGet;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.Label lblReleaseDirectory;
    private System.Windows.Forms.TextBox tbReleaseDirectory;
    private System.Windows.Forms.Button btnReleaseDirectoryBrowse;
    private System.Windows.Forms.Label lblVerificationFile;
    private System.Windows.Forms.TextBox tbVerificationFilePath;
    private System.Windows.Forms.Button btnVerificationFileBrowse;
    private System.Windows.Forms.Label lblOutputDirectory;
    private System.Windows.Forms.TextBox tbOutputDirectory;
    private System.Windows.Forms.Button btnTemporaryDirectoryBrowse;
    private System.Windows.Forms.Label lblOutputWarning;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.GroupBox gbLog;
    private System.Windows.Forms.Panel panelLogToolbar;
    private System.Windows.Forms.CheckBox cbAutoScroll;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.TabControl tabControlLogs;
    private System.Windows.Forms.TabPage tabPageSystem;
    private System.Windows.Forms.RichTextBox rtbLogSystem;
    private System.Windows.Forms.TabPage tabPagePhase1;
    private System.Windows.Forms.RichTextBox rtbLogPhase1;
    private System.Windows.Forms.TabPage tabPagePhase2;
    private System.Windows.Forms.RichTextBox rtbLogPhase2;
}
