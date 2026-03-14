namespace WinRARRed.Forms;

partial class SettingsOptionsForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsOptionsForm));
        panelTop = new System.Windows.Forms.Panel();
        gbCheckboxLegend = new System.Windows.Forms.GroupBox();
        cbLegendNever = new System.Windows.Forms.CheckBox();
        cbLegendAlways = new System.Windows.Forms.CheckBox();
        cbLegendSometimes = new System.Windows.Forms.CheckBox();
        lblDescription = new System.Windows.Forms.Label();
        panelBottom = new System.Windows.Forms.Panel();
        flowBottomRight = new System.Windows.Forms.FlowLayoutPanel();
        btnSave = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        btnImportSrr = new System.Windows.Forms.Button();
        flowBottomLeft = new System.Windows.Forms.FlowLayoutPanel();
        cbDeleteRARFiles = new System.Windows.Forms.CheckBox();
        cbStopOnFirstMatch = new System.Windows.Forms.CheckBox();
        cbRenameToOriginal = new System.Windows.Forms.CheckBox();
        cbDeleteDuplicateCRCFiles = new System.Windows.Forms.CheckBox();
        cbCompleteAllVolumes = new System.Windows.Forms.CheckBox();
        panelContent = new System.Windows.Forms.Panel();
        gbSwitches = new System.Windows.Forms.GroupBox();
        gbFileTime = new System.Windows.Forms.GroupBox();
        gbAccessTime = new System.Windows.Forms.GroupBox();
        cbSwitchTSA4 = new System.Windows.Forms.CheckBox();
        cbSwitchTSA3 = new System.Windows.Forms.CheckBox();
        cbSwitchTSA2 = new System.Windows.Forms.CheckBox();
        cbSwitchTSA1 = new System.Windows.Forms.CheckBox();
        cbSwitchTSA0 = new System.Windows.Forms.CheckBox();
        gbCreationTime = new System.Windows.Forms.GroupBox();
        cbSwitchTSC4 = new System.Windows.Forms.CheckBox();
        cbSwitchTSC3 = new System.Windows.Forms.CheckBox();
        cbSwitchTSC2 = new System.Windows.Forms.CheckBox();
        cbSwitchTSC1 = new System.Windows.Forms.CheckBox();
        cbSwitchTSC0 = new System.Windows.Forms.CheckBox();
        gbModificationTime = new System.Windows.Forms.GroupBox();
        cbSwitchTSM4 = new System.Windows.Forms.CheckBox();
        cbSwitchTSM3 = new System.Windows.Forms.CheckBox();
        cbSwitchTSM2 = new System.Windows.Forms.CheckBox();
        cbSwitchTSM1 = new System.Windows.Forms.CheckBox();
        cbSwitchTSM0 = new System.Windows.Forms.CheckBox();
        cbSwitchSDash = new System.Windows.Forms.CheckBox();
        cbSwitchDS = new System.Windows.Forms.CheckBox();
        gbThreads = new System.Windows.Forms.GroupBox();
        cbSwitchMT = new System.Windows.Forms.CheckBox();
        lblMTInclusive = new System.Windows.Forms.Label();
        lblMTTo = new System.Windows.Forms.Label();
        nupSwitchMTEnd = new System.Windows.Forms.NumericUpDown();
        lblMTFrom = new System.Windows.Forms.Label();
        lblMTNote = new System.Windows.Forms.Label();
        nupSwitchMTStart = new System.Windows.Forms.NumericUpDown();
        cbSwitchAI = new System.Windows.Forms.CheckBox();
        lblSwitchesInfo = new System.Windows.Forms.Label();
        gbVolumes = new System.Windows.Forms.GroupBox();
        gbSplit = new System.Windows.Forms.GroupBox();
        tbSwitchSize = new System.Windows.Forms.TextBox();
        rbSwitchSizeBytes = new System.Windows.Forms.RadioButton();
        rbSwitchSizeGiB = new System.Windows.Forms.RadioButton();
        rbSwitchSizeMiB = new System.Windows.Forms.RadioButton();
        rbSwitchSizeKiB = new System.Windows.Forms.RadioButton();
        rbSwitchSizeKB = new System.Windows.Forms.RadioButton();
        cbSwitchV = new System.Windows.Forms.CheckBox();
        rbSwitchSizeGB = new System.Windows.Forms.RadioButton();
        rbSwitchSizeMB = new System.Windows.Forms.RadioButton();
        cbUseOldVolumeNaming = new System.Windows.Forms.CheckBox();
        cbSwitchR = new System.Windows.Forms.CheckBox();
        gbDictionarySizes = new System.Windows.Forms.GroupBox();
        cbSwitchMD1G = new System.Windows.Forms.CheckBox();
        cbSwitchMD512M = new System.Windows.Forms.CheckBox();
        cbSwitchMD256M = new System.Windows.Forms.CheckBox();
        cbSwitchMD128M = new System.Windows.Forms.CheckBox();
        cbSwitchMD64M = new System.Windows.Forms.CheckBox();
        cbSwitchMD32M = new System.Windows.Forms.CheckBox();
        cbSwitchMD16M = new System.Windows.Forms.CheckBox();
        cbSwitchMD8M = new System.Windows.Forms.CheckBox();
        cbSwitchMD4096K = new System.Windows.Forms.CheckBox();
        cbSwitchMD2048K = new System.Windows.Forms.CheckBox();
        cbSwitchMD1024K = new System.Windows.Forms.CheckBox();
        cbSwitchMD512K = new System.Windows.Forms.CheckBox();
        cbSwitchMD256K = new System.Windows.Forms.CheckBox();
        cbSwitchMD128K = new System.Windows.Forms.CheckBox();
        cbSwitchMD64K = new System.Windows.Forms.CheckBox();
        gbArchiveFormat = new System.Windows.Forms.GroupBox();
        cbSwitchMA5 = new System.Windows.Forms.CheckBox();
        cbSwitchMA4 = new System.Windows.Forms.CheckBox();
        gbCompressionLevels = new System.Windows.Forms.GroupBox();
        cbSwitchM5 = new System.Windows.Forms.CheckBox();
        cbSwitchM4 = new System.Windows.Forms.CheckBox();
        cbSwitchM3 = new System.Windows.Forms.CheckBox();
        cbSwitchM2 = new System.Windows.Forms.CheckBox();
        cbSwitchM1 = new System.Windows.Forms.CheckBox();
        cbSwitchM0 = new System.Windows.Forms.CheckBox();
        gbHostOSOverride = new System.Windows.Forms.GroupBox();
        lblPatchDetails = new System.Windows.Forms.Label();
        lblHostOSInfo = new System.Windows.Forms.Label();
        cbEnableHostOSPatching = new System.Windows.Forms.CheckBox();
        gbFileOptions = new System.Windows.Forms.GroupBox();
        cbFileI = new System.Windows.Forms.CheckBox();
        lblFileOptionsInfo = new System.Windows.Forms.Label();
        cbFileA = new System.Windows.Forms.CheckBox();
        gbRARVersion = new System.Windows.Forms.GroupBox();
        lblRARVersionInfo = new System.Windows.Forms.Label();
        cbRARVersion7 = new System.Windows.Forms.CheckBox();
        cbRARVersion6 = new System.Windows.Forms.CheckBox();
        cbRARVersion5 = new System.Windows.Forms.CheckBox();
        cbRARVersion4 = new System.Windows.Forms.CheckBox();
        cbRARVersion3 = new System.Windows.Forms.CheckBox();
        cbRARVersion2 = new System.Windows.Forms.CheckBox();
        panelTop.SuspendLayout();
        gbCheckboxLegend.SuspendLayout();
        panelBottom.SuspendLayout();
        flowBottomRight.SuspendLayout();
        flowBottomLeft.SuspendLayout();
        panelContent.SuspendLayout();
        gbSwitches.SuspendLayout();
        gbFileTime.SuspendLayout();
        gbAccessTime.SuspendLayout();
        gbCreationTime.SuspendLayout();
        gbModificationTime.SuspendLayout();
        gbThreads.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nupSwitchMTEnd).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nupSwitchMTStart).BeginInit();
        gbVolumes.SuspendLayout();
        gbSplit.SuspendLayout();
        gbDictionarySizes.SuspendLayout();
        gbArchiveFormat.SuspendLayout();
        gbCompressionLevels.SuspendLayout();
        gbHostOSOverride.SuspendLayout();
        gbFileOptions.SuspendLayout();
        gbRARVersion.SuspendLayout();
        SuspendLayout();
        // 
        // panelTop
        // 
        panelTop.Controls.Add(gbCheckboxLegend);
        panelTop.Controls.Add(lblDescription);
        panelTop.Dock = System.Windows.Forms.DockStyle.Top;
        panelTop.Location = new System.Drawing.Point(0, 0);
        panelTop.Name = "panelTop";
        panelTop.Padding = new System.Windows.Forms.Padding(12, 9, 12, 3);
        panelTop.Size = new System.Drawing.Size(1154, 117);
        panelTop.TabIndex = 100;
        // 
        // gbCheckboxLegend
        // 
        gbCheckboxLegend.Controls.Add(cbLegendNever);
        gbCheckboxLegend.Controls.Add(cbLegendAlways);
        gbCheckboxLegend.Controls.Add(cbLegendSometimes);
        gbCheckboxLegend.Location = new System.Drawing.Point(908, 12);
        gbCheckboxLegend.Name = "gbCheckboxLegend";
        gbCheckboxLegend.Size = new System.Drawing.Size(234, 100);
        gbCheckboxLegend.TabIndex = 43;
        gbCheckboxLegend.TabStop = false;
        gbCheckboxLegend.Text = "Checkbox legend";
        // 
        // cbLegendNever
        // 
        cbLegendNever.AutoCheck = false;
        cbLegendNever.AutoSize = true;
        cbLegendNever.Location = new System.Drawing.Point(6, 22);
        cbLegendNever.Name = "cbLegendNever";
        cbLegendNever.Size = new System.Drawing.Size(124, 19);
        cbLegendNever.TabIndex = 40;
        cbLegendNever.Text = "Option is never set";
        cbLegendNever.UseVisualStyleBackColor = true;
        // 
        // cbLegendAlways
        // 
        cbLegendAlways.AutoCheck = false;
        cbLegendAlways.AutoSize = true;
        cbLegendAlways.Checked = true;
        cbLegendAlways.CheckState = System.Windows.Forms.CheckState.Indeterminate;
        cbLegendAlways.Location = new System.Drawing.Point(6, 72);
        cbLegendAlways.Name = "cbLegendAlways";
        cbLegendAlways.Size = new System.Drawing.Size(130, 19);
        cbLegendAlways.TabIndex = 42;
        cbLegendAlways.Text = "Option is always set";
        cbLegendAlways.UseVisualStyleBackColor = true;
        // 
        // cbLegendSometimes
        // 
        cbLegendSometimes.AutoCheck = false;
        cbLegendSometimes.AutoSize = true;
        cbLegendSometimes.Checked = true;
        cbLegendSometimes.CheckState = System.Windows.Forms.CheckState.Checked;
        cbLegendSometimes.Location = new System.Drawing.Point(6, 47);
        cbLegendSometimes.Name = "cbLegendSometimes";
        cbLegendSometimes.Size = new System.Drawing.Size(217, 19);
        cbLegendSometimes.TabIndex = 41;
        cbLegendSometimes.Text = "Test with and without this option set";
        cbLegendSometimes.UseVisualStyleBackColor = true;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new System.Drawing.Point(12, 9);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new System.Drawing.Size(630, 60);
        lblDescription.TabIndex = 5;
        lblDescription.Text = resources.GetString("lblDescription.Text");
        // 
        // panelBottom
        // 
        panelBottom.Controls.Add(flowBottomRight);
        panelBottom.Controls.Add(flowBottomLeft);
        panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        panelBottom.Location = new System.Drawing.Point(0, 809);
        panelBottom.Name = "panelBottom";
        panelBottom.Size = new System.Drawing.Size(1154, 67);
        panelBottom.TabIndex = 101;
        // 
        // flowBottomRight
        // 
        flowBottomRight.Controls.Add(btnSave);
        flowBottomRight.Controls.Add(btnCancel);
        flowBottomRight.Controls.Add(btnImportSrr);
        flowBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
        flowBottomRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        flowBottomRight.Location = new System.Drawing.Point(770, 0);
        flowBottomRight.Name = "flowBottomRight";
        flowBottomRight.Padding = new System.Windows.Forms.Padding(0, 6, 9, 0);
        flowBottomRight.Size = new System.Drawing.Size(384, 67);
        flowBottomRight.TabIndex = 1;
        // 
        // btnSave
        // 
        btnSave.Location = new System.Drawing.Point(297, 12);
        btnSave.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(75, 23);
        btnSave.TabIndex = 35;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        btnCancel.Location = new System.Drawing.Point(216, 12);
        btnCancel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(75, 23);
        btnCancel.TabIndex = 36;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnImportSrr
        // 
        btnImportSrr.Location = new System.Drawing.Point(90, 12);
        btnImportSrr.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        btnImportSrr.Name = "btnImportSrr";
        btnImportSrr.Size = new System.Drawing.Size(120, 23);
        btnImportSrr.TabIndex = 44;
        btnImportSrr.Text = "Import from SRR";
        btnImportSrr.UseVisualStyleBackColor = true;
        // 
        // flowBottomLeft
        // 
        flowBottomLeft.Controls.Add(cbDeleteRARFiles);
        flowBottomLeft.Controls.Add(cbStopOnFirstMatch);
        flowBottomLeft.Controls.Add(cbRenameToOriginal);
        flowBottomLeft.Controls.Add(cbDeleteDuplicateCRCFiles);
        flowBottomLeft.Controls.Add(cbCompleteAllVolumes);
        flowBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
        flowBottomLeft.Location = new System.Drawing.Point(0, 0);
        flowBottomLeft.Name = "flowBottomLeft";
        flowBottomLeft.Padding = new System.Windows.Forms.Padding(9, 6, 0, 0);
        flowBottomLeft.Size = new System.Drawing.Size(770, 67);
        flowBottomLeft.TabIndex = 0;
        // 
        // cbDeleteRARFiles
        // 
        cbDeleteRARFiles.AutoSize = true;
        cbDeleteRARFiles.Checked = true;
        cbDeleteRARFiles.CheckState = System.Windows.Forms.CheckState.Checked;
        cbDeleteRARFiles.Location = new System.Drawing.Point(12, 12);
        cbDeleteRARFiles.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        cbDeleteRARFiles.Name = "cbDeleteRARFiles";
        cbDeleteRARFiles.Size = new System.Drawing.Size(261, 19);
        cbDeleteRARFiles.TabIndex = 26;
        cbDeleteRARFiles.Text = "Delete RAR files if checksum does not match";
        cbDeleteRARFiles.UseVisualStyleBackColor = true;
        cbDeleteRARFiles.CheckedChanged += CbDeleteRARFiles_CheckedChanged;
        // 
        // cbStopOnFirstMatch
        // 
        cbStopOnFirstMatch.AutoSize = true;
        cbStopOnFirstMatch.Checked = true;
        cbStopOnFirstMatch.CheckState = System.Windows.Forms.CheckState.Checked;
        cbStopOnFirstMatch.Location = new System.Drawing.Point(279, 12);
        cbStopOnFirstMatch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        cbStopOnFirstMatch.Name = "cbStopOnFirstMatch";
        cbStopOnFirstMatch.Size = new System.Drawing.Size(127, 19);
        cbStopOnFirstMatch.TabIndex = 46;
        cbStopOnFirstMatch.Text = "Stop on first match";
        cbStopOnFirstMatch.UseVisualStyleBackColor = true;
        cbStopOnFirstMatch.CheckedChanged += CbStopOnFirstMatch_CheckedChanged;
        // 
        // cbRenameToOriginal
        // 
        cbRenameToOriginal.AutoSize = true;
        cbRenameToOriginal.Location = new System.Drawing.Point(412, 12);
        cbRenameToOriginal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        cbRenameToOriginal.Name = "cbRenameToOriginal";
        cbRenameToOriginal.Size = new System.Drawing.Size(217, 19);
        cbRenameToOriginal.TabIndex = 49;
        cbRenameToOriginal.Text = "Rename match to original filenames";
        cbRenameToOriginal.UseVisualStyleBackColor = true;
        // 
        // cbDeleteDuplicateCRCFiles
        // 
        cbDeleteDuplicateCRCFiles.AutoSize = true;
        cbDeleteDuplicateCRCFiles.Checked = true;
        cbDeleteDuplicateCRCFiles.CheckState = System.Windows.Forms.CheckState.Checked;
        cbDeleteDuplicateCRCFiles.Location = new System.Drawing.Point(12, 40);
        cbDeleteDuplicateCRCFiles.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        cbDeleteDuplicateCRCFiles.Name = "cbDeleteDuplicateCRCFiles";
        cbDeleteDuplicateCRCFiles.Size = new System.Drawing.Size(263, 19);
        cbDeleteDuplicateCRCFiles.TabIndex = 47;
        cbDeleteDuplicateCRCFiles.Text = "Delete duplicate CRC files (keep only unique)";
        cbDeleteDuplicateCRCFiles.UseVisualStyleBackColor = true;
        // 
        // cbCompleteAllVolumes
        // 
        cbCompleteAllVolumes.AutoSize = true;
        cbCompleteAllVolumes.Location = new System.Drawing.Point(281, 40);
        cbCompleteAllVolumes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
        cbCompleteAllVolumes.Name = "cbCompleteAllVolumes";
        cbCompleteAllVolumes.Size = new System.Drawing.Size(195, 19);
        cbCompleteAllVolumes.TabIndex = 48;
        cbCompleteAllVolumes.Text = "Complete all volumes on match";
        cbCompleteAllVolumes.UseVisualStyleBackColor = true;
        // 
        // panelContent
        // 
        panelContent.AutoScroll = true;
        panelContent.Controls.Add(gbSwitches);
        panelContent.Controls.Add(gbHostOSOverride);
        panelContent.Controls.Add(gbFileOptions);
        panelContent.Controls.Add(gbRARVersion);
        panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
        panelContent.Location = new System.Drawing.Point(0, 117);
        panelContent.Name = "panelContent";
        panelContent.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
        panelContent.Size = new System.Drawing.Size(1154, 692);
        panelContent.TabIndex = 102;
        // 
        // gbSwitches
        // 
        gbSwitches.Controls.Add(gbFileTime);
        gbSwitches.Controls.Add(cbSwitchSDash);
        gbSwitches.Controls.Add(cbSwitchDS);
        gbSwitches.Controls.Add(gbThreads);
        gbSwitches.Controls.Add(cbSwitchAI);
        gbSwitches.Controls.Add(lblSwitchesInfo);
        gbSwitches.Controls.Add(gbVolumes);
        gbSwitches.Controls.Add(cbSwitchR);
        gbSwitches.Controls.Add(gbDictionarySizes);
        gbSwitches.Controls.Add(gbArchiveFormat);
        gbSwitches.Controls.Add(gbCompressionLevels);
        gbSwitches.Dock = System.Windows.Forms.DockStyle.Top;
        gbSwitches.Location = new System.Drawing.Point(12, 290);
        gbSwitches.Name = "gbSwitches";
        gbSwitches.Size = new System.Drawing.Size(1113, 562);
        gbSwitches.TabIndex = 32;
        gbSwitches.TabStop = false;
        gbSwitches.Text = "Switches for archiving";
        // 
        // gbFileTime
        // 
        gbFileTime.Controls.Add(gbAccessTime);
        gbFileTime.Controls.Add(gbCreationTime);
        gbFileTime.Controls.Add(gbModificationTime);
        gbFileTime.Location = new System.Drawing.Point(704, 22);
        gbFileTime.Name = "gbFileTime";
        gbFileTime.Size = new System.Drawing.Size(417, 488);
        gbFileTime.TabIndex = 37;
        gbFileTime.TabStop = false;
        gbFileTime.Text = "File time";
        // 
        // gbAccessTime
        // 
        gbAccessTime.Controls.Add(cbSwitchTSA4);
        gbAccessTime.Controls.Add(cbSwitchTSA3);
        gbAccessTime.Controls.Add(cbSwitchTSA2);
        gbAccessTime.Controls.Add(cbSwitchTSA1);
        gbAccessTime.Controls.Add(cbSwitchTSA0);
        gbAccessTime.Location = new System.Drawing.Point(6, 332);
        gbAccessTime.Name = "gbAccessTime";
        gbAccessTime.Size = new System.Drawing.Size(402, 149);
        gbAccessTime.TabIndex = 2;
        gbAccessTime.TabStop = false;
        gbAccessTime.Text = "Access time";
        // 
        // cbSwitchTSA4
        // 
        cbSwitchTSA4.AutoSize = true;
        cbSwitchTSA4.Location = new System.Drawing.Point(6, 122);
        cbSwitchTSA4.Name = "cbSwitchTSA4";
        cbSwitchTSA4.Size = new System.Drawing.Size(375, 19);
        cbSwitchTSA4.TabIndex = 4;
        cbSwitchTSA4.Text = "tsa4 - Maximum NTFS time precision (0.0000001 second precision)";
        cbSwitchTSA4.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSA3
        // 
        cbSwitchTSA3.AutoSize = true;
        cbSwitchTSA3.Location = new System.Drawing.Point(6, 97);
        cbSwitchTSA3.Name = "cbSwitchTSA3";
        cbSwitchTSA3.Size = new System.Drawing.Size(201, 19);
        cbSwitchTSA3.TabIndex = 3;
        cbSwitchTSA3.Text = "tsa3 - 0.0000256 second precision";
        cbSwitchTSA3.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSA2
        // 
        cbSwitchTSA2.AutoSize = true;
        cbSwitchTSA2.Location = new System.Drawing.Point(6, 72);
        cbSwitchTSA2.Name = "cbSwitchTSA2";
        cbSwitchTSA2.Size = new System.Drawing.Size(201, 19);
        cbSwitchTSA2.TabIndex = 2;
        cbSwitchTSA2.Text = "tsa2 - 0.0065536 second precision";
        cbSwitchTSA2.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSA1
        // 
        cbSwitchTSA1.AutoSize = true;
        cbSwitchTSA1.Location = new System.Drawing.Point(6, 47);
        cbSwitchTSA1.Name = "cbSwitchTSA1";
        cbSwitchTSA1.Size = new System.Drawing.Size(156, 19);
        cbSwitchTSA1.TabIndex = 1;
        cbSwitchTSA1.Text = "tsa1 - 1 second precision";
        cbSwitchTSA1.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSA0
        // 
        cbSwitchTSA0.AutoSize = true;
        cbSwitchTSA0.Checked = true;
        cbSwitchTSA0.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchTSA0.Location = new System.Drawing.Point(6, 22);
        cbSwitchTSA0.Name = "cbSwitchTSA0";
        cbSwitchTSA0.Size = new System.Drawing.Size(175, 19);
        cbSwitchTSA0.TabIndex = 0;
        cbSwitchTSA0.Text = "tsa0 - Access time not saved";
        cbSwitchTSA0.UseVisualStyleBackColor = true;
        // 
        // gbCreationTime
        // 
        gbCreationTime.Controls.Add(cbSwitchTSC4);
        gbCreationTime.Controls.Add(cbSwitchTSC3);
        gbCreationTime.Controls.Add(cbSwitchTSC2);
        gbCreationTime.Controls.Add(cbSwitchTSC1);
        gbCreationTime.Controls.Add(cbSwitchTSC0);
        gbCreationTime.Location = new System.Drawing.Point(6, 177);
        gbCreationTime.Name = "gbCreationTime";
        gbCreationTime.Size = new System.Drawing.Size(402, 149);
        gbCreationTime.TabIndex = 1;
        gbCreationTime.TabStop = false;
        gbCreationTime.Text = "Creation time";
        // 
        // cbSwitchTSC4
        // 
        cbSwitchTSC4.AutoSize = true;
        cbSwitchTSC4.Location = new System.Drawing.Point(6, 122);
        cbSwitchTSC4.Name = "cbSwitchTSC4";
        cbSwitchTSC4.Size = new System.Drawing.Size(375, 19);
        cbSwitchTSC4.TabIndex = 4;
        cbSwitchTSC4.Text = "tsc4 - Maximum NTFS time precision (0.0000001 second precision)";
        cbSwitchTSC4.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSC3
        // 
        cbSwitchTSC3.AutoSize = true;
        cbSwitchTSC3.Location = new System.Drawing.Point(6, 97);
        cbSwitchTSC3.Name = "cbSwitchTSC3";
        cbSwitchTSC3.Size = new System.Drawing.Size(201, 19);
        cbSwitchTSC3.TabIndex = 3;
        cbSwitchTSC3.Text = "tsc3 - 0.0000256 second precision";
        cbSwitchTSC3.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSC2
        // 
        cbSwitchTSC2.AutoSize = true;
        cbSwitchTSC2.Location = new System.Drawing.Point(6, 72);
        cbSwitchTSC2.Name = "cbSwitchTSC2";
        cbSwitchTSC2.Size = new System.Drawing.Size(201, 19);
        cbSwitchTSC2.TabIndex = 2;
        cbSwitchTSC2.Text = "tsc2 - 0.0065536 second precision";
        cbSwitchTSC2.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSC1
        // 
        cbSwitchTSC1.AutoSize = true;
        cbSwitchTSC1.Location = new System.Drawing.Point(6, 47);
        cbSwitchTSC1.Name = "cbSwitchTSC1";
        cbSwitchTSC1.Size = new System.Drawing.Size(156, 19);
        cbSwitchTSC1.TabIndex = 1;
        cbSwitchTSC1.Text = "tsc1 - 1 second precision";
        cbSwitchTSC1.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSC0
        // 
        cbSwitchTSC0.AutoSize = true;
        cbSwitchTSC0.Checked = true;
        cbSwitchTSC0.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchTSC0.Location = new System.Drawing.Point(6, 22);
        cbSwitchTSC0.Name = "cbSwitchTSC0";
        cbSwitchTSC0.Size = new System.Drawing.Size(184, 19);
        cbSwitchTSC0.TabIndex = 0;
        cbSwitchTSC0.Text = "tsc0 - Creation time not saved";
        cbSwitchTSC0.UseVisualStyleBackColor = true;
        // 
        // gbModificationTime
        // 
        gbModificationTime.Controls.Add(cbSwitchTSM4);
        gbModificationTime.Controls.Add(cbSwitchTSM3);
        gbModificationTime.Controls.Add(cbSwitchTSM2);
        gbModificationTime.Controls.Add(cbSwitchTSM1);
        gbModificationTime.Controls.Add(cbSwitchTSM0);
        gbModificationTime.Location = new System.Drawing.Point(6, 22);
        gbModificationTime.Name = "gbModificationTime";
        gbModificationTime.Size = new System.Drawing.Size(402, 149);
        gbModificationTime.TabIndex = 0;
        gbModificationTime.TabStop = false;
        gbModificationTime.Text = "Modification time";
        // 
        // cbSwitchTSM4
        // 
        cbSwitchTSM4.AutoSize = true;
        cbSwitchTSM4.Checked = true;
        cbSwitchTSM4.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchTSM4.Location = new System.Drawing.Point(6, 122);
        cbSwitchTSM4.Name = "cbSwitchTSM4";
        cbSwitchTSM4.Size = new System.Drawing.Size(380, 19);
        cbSwitchTSM4.TabIndex = 4;
        cbSwitchTSM4.Text = "tsm4 - Maximum NTFS time precision (0.0000001 second precision)";
        cbSwitchTSM4.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSM3
        // 
        cbSwitchTSM3.AutoSize = true;
        cbSwitchTSM3.Location = new System.Drawing.Point(6, 97);
        cbSwitchTSM3.Name = "cbSwitchTSM3";
        cbSwitchTSM3.Size = new System.Drawing.Size(206, 19);
        cbSwitchTSM3.TabIndex = 3;
        cbSwitchTSM3.Text = "tsm3 - 0.0000256 second precision";
        cbSwitchTSM3.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSM2
        // 
        cbSwitchTSM2.AutoSize = true;
        cbSwitchTSM2.Location = new System.Drawing.Point(6, 72);
        cbSwitchTSM2.Name = "cbSwitchTSM2";
        cbSwitchTSM2.Size = new System.Drawing.Size(206, 19);
        cbSwitchTSM2.TabIndex = 2;
        cbSwitchTSM2.Text = "tsm2 - 0.0065536 second precision";
        cbSwitchTSM2.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSM1
        // 
        cbSwitchTSM1.AutoSize = true;
        cbSwitchTSM1.Location = new System.Drawing.Point(6, 47);
        cbSwitchTSM1.Name = "cbSwitchTSM1";
        cbSwitchTSM1.Size = new System.Drawing.Size(161, 19);
        cbSwitchTSM1.TabIndex = 1;
        cbSwitchTSM1.Text = "tsm1 - 1 second precision";
        cbSwitchTSM1.UseVisualStyleBackColor = true;
        // 
        // cbSwitchTSM0
        // 
        cbSwitchTSM0.AutoSize = true;
        cbSwitchTSM0.Location = new System.Drawing.Point(6, 22);
        cbSwitchTSM0.Name = "cbSwitchTSM0";
        cbSwitchTSM0.Size = new System.Drawing.Size(212, 19);
        cbSwitchTSM0.TabIndex = 0;
        cbSwitchTSM0.Text = "tsm0 - Modification time not saved";
        cbSwitchTSM0.UseVisualStyleBackColor = true;
        // 
        // cbSwitchSDash
        // 
        cbSwitchSDash.AutoSize = true;
        cbSwitchSDash.Checked = true;
        cbSwitchSDash.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchSDash.Location = new System.Drawing.Point(407, 397);
        cbSwitchSDash.Name = "cbSwitchSDash";
        cbSwitchSDash.Size = new System.Drawing.Size(165, 19);
        cbSwitchSDash.TabIndex = 27;
        cbSwitchSDash.Text = "s- - Disable solid archiving";
        cbSwitchSDash.UseVisualStyleBackColor = true;
        // 
        // cbSwitchDS
        // 
        cbSwitchDS.AutoSize = true;
        cbSwitchDS.Checked = true;
        cbSwitchDS.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchDS.Location = new System.Drawing.Point(171, 397);
        cbSwitchDS.Name = "cbSwitchDS";
        cbSwitchDS.Size = new System.Drawing.Size(230, 19);
        cbSwitchDS.TabIndex = 26;
        cbSwitchDS.Text = "ds - Disable name sort for solid archive";
        cbSwitchDS.UseVisualStyleBackColor = true;
        // 
        // gbThreads
        // 
        gbThreads.Controls.Add(cbSwitchMT);
        gbThreads.Controls.Add(lblMTInclusive);
        gbThreads.Controls.Add(lblMTTo);
        gbThreads.Controls.Add(nupSwitchMTEnd);
        gbThreads.Controls.Add(lblMTFrom);
        gbThreads.Controls.Add(lblMTNote);
        gbThreads.Controls.Add(nupSwitchMTStart);
        gbThreads.Location = new System.Drawing.Point(6, 303);
        gbThreads.Name = "gbThreads";
        gbThreads.Size = new System.Drawing.Size(692, 88);
        gbThreads.TabIndex = 25;
        gbThreads.TabStop = false;
        gbThreads.Text = "Threads";
        // 
        // cbSwitchMT
        // 
        cbSwitchMT.AutoSize = true;
        cbSwitchMT.Location = new System.Drawing.Point(6, 22);
        cbSwitchMT.Name = "cbSwitchMT";
        cbSwitchMT.Size = new System.Drawing.Size(152, 19);
        cbSwitchMT.TabIndex = 30;
        cbSwitchMT.Text = "mt - Number of threads";
        cbSwitchMT.UseVisualStyleBackColor = true;
        // 
        // lblMTInclusive
        // 
        lblMTInclusive.AutoSize = true;
        lblMTInclusive.Location = new System.Drawing.Point(350, 24);
        lblMTInclusive.Name = "lblMTInclusive";
        lblMTInclusive.Size = new System.Drawing.Size(61, 15);
        lblMTInclusive.TabIndex = 29;
        lblMTInclusive.Text = "(inclusive)";
        // 
        // lblMTTo
        // 
        lblMTTo.AutoSize = true;
        lblMTTo.Location = new System.Drawing.Point(273, 24);
        lblMTTo.Name = "lblMTTo";
        lblMTTo.Size = new System.Drawing.Size(19, 15);
        lblMTTo.TabIndex = 28;
        lblMTTo.Text = "To";
        // 
        // nupSwitchMTEnd
        // 
        nupSwitchMTEnd.Enabled = false;
        nupSwitchMTEnd.Location = new System.Drawing.Point(298, 22);
        nupSwitchMTEnd.Name = "nupSwitchMTEnd";
        nupSwitchMTEnd.Size = new System.Drawing.Size(46, 23);
        nupSwitchMTEnd.TabIndex = 27;
        nupSwitchMTEnd.Value = new decimal(new int[] { 16, 0, 0, 0 });
        // 
        // lblMTFrom
        // 
        lblMTFrom.AutoSize = true;
        lblMTFrom.Location = new System.Drawing.Point(177, 24);
        lblMTFrom.Name = "lblMTFrom";
        lblMTFrom.Size = new System.Drawing.Size(35, 15);
        lblMTFrom.TabIndex = 26;
        lblMTFrom.Text = "From";
        // 
        // lblMTNote
        // 
        lblMTNote.AutoSize = true;
        lblMTNote.Location = new System.Drawing.Point(6, 48);
        lblMTNote.Name = "lblMTNote";
        lblMTNote.Size = new System.Drawing.Size(654, 30);
        lblMTNote.TabIndex = 14;
        lblMTNote.Text = "Change of <threads> parameter slightly affects the compression ratio,\r\nso archives created with different -mt switches will not be exactly the same even if all other compression settings are equal.";
        // 
        // nupSwitchMTStart
        // 
        nupSwitchMTStart.Enabled = false;
        nupSwitchMTStart.Location = new System.Drawing.Point(218, 22);
        nupSwitchMTStart.Name = "nupSwitchMTStart";
        nupSwitchMTStart.Size = new System.Drawing.Size(46, 23);
        nupSwitchMTStart.TabIndex = 12;
        nupSwitchMTStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // cbSwitchAI
        // 
        cbSwitchAI.AutoSize = true;
        cbSwitchAI.Enabled = false;
        cbSwitchAI.Location = new System.Drawing.Point(6, 52);
        cbSwitchAI.Name = "cbSwitchAI";
        cbSwitchAI.Size = new System.Drawing.Size(152, 19);
        cbSwitchAI.TabIndex = 24;
        cbSwitchAI.Text = "ai - Ignore file attributes";
        cbSwitchAI.UseVisualStyleBackColor = true;
        // 
        // lblSwitchesInfo
        // 
        lblSwitchesInfo.AutoSize = true;
        lblSwitchesInfo.Location = new System.Drawing.Point(6, 19);
        lblSwitchesInfo.Name = "lblSwitchesInfo";
        lblSwitchesInfo.Size = new System.Drawing.Size(533, 30);
        lblSwitchesInfo.TabIndex = 23;
        lblSwitchesInfo.Text = "Select the switches to pass on to the RAR process.\r\nIf a switch is not supported by a RAR version, it will not be supplied as argument to the RAR process.";
        // 
        // gbVolumes
        // 
        gbVolumes.Controls.Add(gbSplit);
        gbVolumes.Location = new System.Drawing.Point(6, 422);
        gbVolumes.Name = "gbVolumes";
        gbVolumes.Size = new System.Drawing.Size(692, 131);
        gbVolumes.TabIndex = 22;
        gbVolumes.TabStop = false;
        gbVolumes.Text = "Volumes";
        // 
        // gbSplit
        // 
        gbSplit.Controls.Add(tbSwitchSize);
        gbSplit.Controls.Add(rbSwitchSizeBytes);
        gbSplit.Controls.Add(rbSwitchSizeGiB);
        gbSplit.Controls.Add(rbSwitchSizeMiB);
        gbSplit.Controls.Add(rbSwitchSizeKiB);
        gbSplit.Controls.Add(rbSwitchSizeKB);
        gbSplit.Controls.Add(cbSwitchV);
        gbSplit.Controls.Add(rbSwitchSizeGB);
        gbSplit.Controls.Add(rbSwitchSizeMB);
        gbSplit.Controls.Add(cbUseOldVolumeNaming);
        gbSplit.Location = new System.Drawing.Point(6, 22);
        gbSplit.Name = "gbSplit";
        gbSplit.Size = new System.Drawing.Size(680, 101);
        gbSplit.TabIndex = 21;
        gbSplit.TabStop = false;
        gbSplit.Text = "Split";
        // 
        // tbSwitchSize
        // 
        tbSwitchSize.Location = new System.Drawing.Point(314, 20);
        tbSwitchSize.Name = "tbSwitchSize";
        tbSwitchSize.Size = new System.Drawing.Size(75, 23);
        tbSwitchSize.TabIndex = 26;
        tbSwitchSize.Text = "1";
        // 
        // rbSwitchSizeBytes
        // 
        rbSwitchSizeBytes.AutoSize = true;
        rbSwitchSizeBytes.Enabled = false;
        rbSwitchSizeBytes.Location = new System.Drawing.Point(395, 22);
        rbSwitchSizeBytes.Name = "rbSwitchSizeBytes";
        rbSwitchSizeBytes.Size = new System.Drawing.Size(53, 19);
        rbSwitchSizeBytes.TabIndex = 25;
        rbSwitchSizeBytes.Text = "bytes";
        rbSwitchSizeBytes.UseVisualStyleBackColor = true;
        // 
        // rbSwitchSizeGiB
        // 
        rbSwitchSizeGiB.AutoSize = true;
        rbSwitchSizeGiB.Enabled = false;
        rbSwitchSizeGiB.Location = new System.Drawing.Point(565, 72);
        rbSwitchSizeGiB.Name = "rbSwitchSizeGiB";
        rbSwitchSizeGiB.Size = new System.Drawing.Size(102, 19);
        rbSwitchSizeGiB.TabIndex = 24;
        rbSwitchSizeGiB.Text = "GiB - 1024 MiB";
        rbSwitchSizeGiB.UseVisualStyleBackColor = true;
        // 
        // rbSwitchSizeMiB
        // 
        rbSwitchSizeMiB.AutoSize = true;
        rbSwitchSizeMiB.Enabled = false;
        rbSwitchSizeMiB.Location = new System.Drawing.Point(565, 47);
        rbSwitchSizeMiB.Name = "rbSwitchSizeMiB";
        rbSwitchSizeMiB.Size = new System.Drawing.Size(101, 19);
        rbSwitchSizeMiB.TabIndex = 23;
        rbSwitchSizeMiB.Text = "MiB - 1024 KiB";
        rbSwitchSizeMiB.UseVisualStyleBackColor = true;
        // 
        // rbSwitchSizeKiB
        // 
        rbSwitchSizeKiB.AutoSize = true;
        rbSwitchSizeKiB.Enabled = false;
        rbSwitchSizeKiB.Location = new System.Drawing.Point(565, 22);
        rbSwitchSizeKiB.Name = "rbSwitchSizeKiB";
        rbSwitchSizeKiB.Size = new System.Drawing.Size(108, 19);
        rbSwitchSizeKiB.TabIndex = 22;
        rbSwitchSizeKiB.Text = "KiB - 1024 bytes";
        rbSwitchSizeKiB.UseVisualStyleBackColor = true;
        // 
        // rbSwitchSizeKB
        // 
        rbSwitchSizeKB.AutoSize = true;
        rbSwitchSizeKB.Enabled = false;
        rbSwitchSizeKB.Location = new System.Drawing.Point(454, 22);
        rbSwitchSizeKB.Name = "rbSwitchSizeKB";
        rbSwitchSizeKB.Size = new System.Drawing.Size(105, 19);
        rbSwitchSizeKB.TabIndex = 21;
        rbSwitchSizeKB.Text = "KB - 1000 bytes";
        rbSwitchSizeKB.UseVisualStyleBackColor = true;
        // 
        // cbSwitchV
        // 
        cbSwitchV.AutoSize = true;
        cbSwitchV.Location = new System.Drawing.Point(6, 22);
        cbSwitchV.Name = "cbSwitchV";
        cbSwitchV.Size = new System.Drawing.Size(302, 19);
        cbSwitchV.TabIndex = 16;
        cbSwitchV.Text = "v - Create volumes with size=<size>*1000 [*1024, *1]";
        cbSwitchV.UseVisualStyleBackColor = true;
        // 
        // rbSwitchSizeGB
        // 
        rbSwitchSizeGB.AutoSize = true;
        rbSwitchSizeGB.Enabled = false;
        rbSwitchSizeGB.Location = new System.Drawing.Point(454, 72);
        rbSwitchSizeGB.Name = "rbSwitchSizeGB";
        rbSwitchSizeGB.Size = new System.Drawing.Size(96, 19);
        rbSwitchSizeGB.TabIndex = 20;
        rbSwitchSizeGB.Text = "GB - 1000 MB";
        rbSwitchSizeGB.UseVisualStyleBackColor = true;
        // 
        // rbSwitchSizeMB
        // 
        rbSwitchSizeMB.AutoSize = true;
        rbSwitchSizeMB.Checked = true;
        rbSwitchSizeMB.Enabled = false;
        rbSwitchSizeMB.Location = new System.Drawing.Point(454, 47);
        rbSwitchSizeMB.Name = "rbSwitchSizeMB";
        rbSwitchSizeMB.Size = new System.Drawing.Size(95, 19);
        rbSwitchSizeMB.TabIndex = 18;
        rbSwitchSizeMB.TabStop = true;
        rbSwitchSizeMB.Text = "MB - 1000 KB";
        rbSwitchSizeMB.UseVisualStyleBackColor = true;
        // 
        // cbUseOldVolumeNaming
        // 
        cbUseOldVolumeNaming.AutoSize = true;
        cbUseOldVolumeNaming.Enabled = false;
        cbUseOldVolumeNaming.Location = new System.Drawing.Point(6, 47);
        cbUseOldVolumeNaming.Name = "cbUseOldVolumeNaming";
        cbUseOldVolumeNaming.Size = new System.Drawing.Size(325, 19);
        cbUseOldVolumeNaming.TabIndex = 27;
        cbUseOldVolumeNaming.Text = "vn - Use old volume naming (.rar, .r00 instead of .partXX)";
        cbUseOldVolumeNaming.UseVisualStyleBackColor = true;
        // 
        // cbSwitchR
        // 
        cbSwitchR.AutoSize = true;
        cbSwitchR.Checked = true;
        cbSwitchR.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchR.Location = new System.Drawing.Point(6, 397);
        cbSwitchR.Name = "cbSwitchR";
        cbSwitchR.Size = new System.Drawing.Size(159, 19);
        cbSwitchR.TabIndex = 14;
        cbSwitchR.Text = "r - Recurse subdirectories";
        cbSwitchR.UseVisualStyleBackColor = true;
        // 
        // gbDictionarySizes
        // 
        gbDictionarySizes.Controls.Add(cbSwitchMD1G);
        gbDictionarySizes.Controls.Add(cbSwitchMD512M);
        gbDictionarySizes.Controls.Add(cbSwitchMD256M);
        gbDictionarySizes.Controls.Add(cbSwitchMD128M);
        gbDictionarySizes.Controls.Add(cbSwitchMD64M);
        gbDictionarySizes.Controls.Add(cbSwitchMD32M);
        gbDictionarySizes.Controls.Add(cbSwitchMD16M);
        gbDictionarySizes.Controls.Add(cbSwitchMD8M);
        gbDictionarySizes.Controls.Add(cbSwitchMD4096K);
        gbDictionarySizes.Controls.Add(cbSwitchMD2048K);
        gbDictionarySizes.Controls.Add(cbSwitchMD1024K);
        gbDictionarySizes.Controls.Add(cbSwitchMD512K);
        gbDictionarySizes.Controls.Add(cbSwitchMD256K);
        gbDictionarySizes.Controls.Add(cbSwitchMD128K);
        gbDictionarySizes.Controls.Add(cbSwitchMD64K);
        gbDictionarySizes.Location = new System.Drawing.Point(6, 189);
        gbDictionarySizes.Name = "gbDictionarySizes";
        gbDictionarySizes.Size = new System.Drawing.Size(692, 108);
        gbDictionarySizes.TabIndex = 7;
        gbDictionarySizes.TabStop = false;
        gbDictionarySizes.Text = "Dictionary sizes";
        // 
        // cbSwitchMD1G
        // 
        cbSwitchMD1G.AutoSize = true;
        cbSwitchMD1G.Location = new System.Drawing.Point(531, 72);
        cbSwitchMD1G.Name = "cbSwitchMD1G";
        cbSwitchMD1G.Size = new System.Drawing.Size(92, 19);
        cbSwitchMD1G.TabIndex = 19;
        cbSwitchMD1G.Text = "md1g - 1 GB";
        cbSwitchMD1G.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD512M
        // 
        cbSwitchMD512M.AutoSize = true;
        cbSwitchMD512M.Location = new System.Drawing.Point(531, 47);
        cbSwitchMD512M.Name = "cbSwitchMD512M";
        cbSwitchMD512M.Size = new System.Drawing.Size(123, 19);
        cbSwitchMD512M.TabIndex = 18;
        cbSwitchMD512M.Text = "md512m - 512 MB";
        cbSwitchMD512M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD256M
        // 
        cbSwitchMD256M.AutoSize = true;
        cbSwitchMD256M.Location = new System.Drawing.Point(531, 22);
        cbSwitchMD256M.Name = "cbSwitchMD256M";
        cbSwitchMD256M.Size = new System.Drawing.Size(123, 19);
        cbSwitchMD256M.TabIndex = 17;
        cbSwitchMD256M.Text = "md256m - 256 MB";
        cbSwitchMD256M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD128M
        // 
        cbSwitchMD128M.AutoSize = true;
        cbSwitchMD128M.Location = new System.Drawing.Point(390, 72);
        cbSwitchMD128M.Name = "cbSwitchMD128M";
        cbSwitchMD128M.Size = new System.Drawing.Size(123, 19);
        cbSwitchMD128M.TabIndex = 16;
        cbSwitchMD128M.Text = "md128m - 128 MB";
        cbSwitchMD128M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD64M
        // 
        cbSwitchMD64M.AutoSize = true;
        cbSwitchMD64M.Location = new System.Drawing.Point(390, 47);
        cbSwitchMD64M.Name = "cbSwitchMD64M";
        cbSwitchMD64M.Size = new System.Drawing.Size(111, 19);
        cbSwitchMD64M.TabIndex = 15;
        cbSwitchMD64M.Text = "md64m - 64 MB";
        cbSwitchMD64M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD32M
        // 
        cbSwitchMD32M.AutoSize = true;
        cbSwitchMD32M.Location = new System.Drawing.Point(390, 22);
        cbSwitchMD32M.Name = "cbSwitchMD32M";
        cbSwitchMD32M.Size = new System.Drawing.Size(111, 19);
        cbSwitchMD32M.TabIndex = 14;
        cbSwitchMD32M.Text = "md32m - 32 MB";
        cbSwitchMD32M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD16M
        // 
        cbSwitchMD16M.AutoSize = true;
        cbSwitchMD16M.Location = new System.Drawing.Point(258, 72);
        cbSwitchMD16M.Name = "cbSwitchMD16M";
        cbSwitchMD16M.Size = new System.Drawing.Size(111, 19);
        cbSwitchMD16M.TabIndex = 13;
        cbSwitchMD16M.Text = "md16m - 16 MB";
        cbSwitchMD16M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD8M
        // 
        cbSwitchMD8M.AutoSize = true;
        cbSwitchMD8M.Location = new System.Drawing.Point(258, 47);
        cbSwitchMD8M.Name = "cbSwitchMD8M";
        cbSwitchMD8M.Size = new System.Drawing.Size(99, 19);
        cbSwitchMD8M.TabIndex = 12;
        cbSwitchMD8M.Text = "md8m - 8 MB";
        cbSwitchMD8M.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD4096K
        // 
        cbSwitchMD4096K.AutoSize = true;
        cbSwitchMD4096K.Location = new System.Drawing.Point(258, 22);
        cbSwitchMD4096K.Name = "cbSwitchMD4096K";
        cbSwitchMD4096K.Size = new System.Drawing.Size(126, 19);
        cbSwitchMD4096K.TabIndex = 11;
        cbSwitchMD4096K.Text = "md4096k - 4096 KB";
        cbSwitchMD4096K.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD2048K
        // 
        cbSwitchMD2048K.AutoSize = true;
        cbSwitchMD2048K.Location = new System.Drawing.Point(126, 72);
        cbSwitchMD2048K.Name = "cbSwitchMD2048K";
        cbSwitchMD2048K.Size = new System.Drawing.Size(126, 19);
        cbSwitchMD2048K.TabIndex = 10;
        cbSwitchMD2048K.Text = "md2048k - 2048 KB";
        cbSwitchMD2048K.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD1024K
        // 
        cbSwitchMD1024K.AutoSize = true;
        cbSwitchMD1024K.Location = new System.Drawing.Point(126, 47);
        cbSwitchMD1024K.Name = "cbSwitchMD1024K";
        cbSwitchMD1024K.Size = new System.Drawing.Size(126, 19);
        cbSwitchMD1024K.TabIndex = 9;
        cbSwitchMD1024K.Text = "md1024k - 1024 KB";
        cbSwitchMD1024K.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD512K
        // 
        cbSwitchMD512K.AutoSize = true;
        cbSwitchMD512K.Location = new System.Drawing.Point(126, 22);
        cbSwitchMD512K.Name = "cbSwitchMD512K";
        cbSwitchMD512K.Size = new System.Drawing.Size(114, 19);
        cbSwitchMD512K.TabIndex = 8;
        cbSwitchMD512K.Text = "md512k - 512 KB";
        cbSwitchMD512K.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD256K
        // 
        cbSwitchMD256K.AutoSize = true;
        cbSwitchMD256K.Location = new System.Drawing.Point(6, 72);
        cbSwitchMD256K.Name = "cbSwitchMD256K";
        cbSwitchMD256K.Size = new System.Drawing.Size(114, 19);
        cbSwitchMD256K.TabIndex = 2;
        cbSwitchMD256K.Text = "md256k - 256 KB";
        cbSwitchMD256K.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD128K
        // 
        cbSwitchMD128K.AutoSize = true;
        cbSwitchMD128K.Location = new System.Drawing.Point(6, 47);
        cbSwitchMD128K.Name = "cbSwitchMD128K";
        cbSwitchMD128K.Size = new System.Drawing.Size(114, 19);
        cbSwitchMD128K.TabIndex = 1;
        cbSwitchMD128K.Text = "md128k - 128 KB";
        cbSwitchMD128K.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMD64K
        // 
        cbSwitchMD64K.AutoSize = true;
        cbSwitchMD64K.Location = new System.Drawing.Point(6, 22);
        cbSwitchMD64K.Name = "cbSwitchMD64K";
        cbSwitchMD64K.Size = new System.Drawing.Size(102, 19);
        cbSwitchMD64K.TabIndex = 0;
        cbSwitchMD64K.Text = "md64k - 64 KB";
        cbSwitchMD64K.UseVisualStyleBackColor = true;
        // 
        // gbArchiveFormat
        // 
        gbArchiveFormat.Controls.Add(cbSwitchMA5);
        gbArchiveFormat.Controls.Add(cbSwitchMA4);
        gbArchiveFormat.Location = new System.Drawing.Point(6, 132);
        gbArchiveFormat.Name = "gbArchiveFormat";
        gbArchiveFormat.Size = new System.Drawing.Size(234, 51);
        gbArchiveFormat.TabIndex = 6;
        gbArchiveFormat.TabStop = false;
        gbArchiveFormat.Text = "Version of archiving format";
        // 
        // cbSwitchMA5
        // 
        cbSwitchMA5.AutoSize = true;
        cbSwitchMA5.Location = new System.Drawing.Point(119, 22);
        cbSwitchMA5.Name = "cbSwitchMA5";
        cbSwitchMA5.Size = new System.Drawing.Size(107, 19);
        cbSwitchMA5.TabIndex = 1;
        cbSwitchMA5.Text = "ma5 - Version 5";
        cbSwitchMA5.UseVisualStyleBackColor = true;
        // 
        // cbSwitchMA4
        // 
        cbSwitchMA4.AutoSize = true;
        cbSwitchMA4.Checked = true;
        cbSwitchMA4.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchMA4.Location = new System.Drawing.Point(6, 22);
        cbSwitchMA4.Name = "cbSwitchMA4";
        cbSwitchMA4.Size = new System.Drawing.Size(107, 19);
        cbSwitchMA4.TabIndex = 0;
        cbSwitchMA4.Text = "ma4 - Version 4";
        cbSwitchMA4.UseVisualStyleBackColor = true;
        // 
        // gbCompressionLevels
        // 
        gbCompressionLevels.Controls.Add(cbSwitchM5);
        gbCompressionLevels.Controls.Add(cbSwitchM4);
        gbCompressionLevels.Controls.Add(cbSwitchM3);
        gbCompressionLevels.Controls.Add(cbSwitchM2);
        gbCompressionLevels.Controls.Add(cbSwitchM1);
        gbCompressionLevels.Controls.Add(cbSwitchM0);
        gbCompressionLevels.Location = new System.Drawing.Point(6, 77);
        gbCompressionLevels.Name = "gbCompressionLevels";
        gbCompressionLevels.Size = new System.Drawing.Size(538, 49);
        gbCompressionLevels.TabIndex = 1;
        gbCompressionLevels.TabStop = false;
        gbCompressionLevels.Text = "Compression levels";
        // 
        // cbSwitchM5
        // 
        cbSwitchM5.AutoSize = true;
        cbSwitchM5.Checked = true;
        cbSwitchM5.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchM5.Location = new System.Drawing.Point(459, 22);
        cbSwitchM5.Name = "cbSwitchM5";
        cbSwitchM5.Size = new System.Drawing.Size(76, 19);
        cbSwitchM5.TabIndex = 5;
        cbSwitchM5.Text = "m5 - Best";
        cbSwitchM5.UseVisualStyleBackColor = true;
        // 
        // cbSwitchM4
        // 
        cbSwitchM4.AutoSize = true;
        cbSwitchM4.Location = new System.Drawing.Point(370, 22);
        cbSwitchM4.Name = "cbSwitchM4";
        cbSwitchM4.Size = new System.Drawing.Size(83, 19);
        cbSwitchM4.TabIndex = 4;
        cbSwitchM4.Text = "m4 - Good";
        cbSwitchM4.UseVisualStyleBackColor = true;
        // 
        // cbSwitchM3
        // 
        cbSwitchM3.AutoSize = true;
        cbSwitchM3.Location = new System.Drawing.Point(270, 22);
        cbSwitchM3.Name = "cbSwitchM3";
        cbSwitchM3.Size = new System.Drawing.Size(94, 19);
        cbSwitchM3.TabIndex = 3;
        cbSwitchM3.Text = "m3 - Normal";
        cbSwitchM3.UseVisualStyleBackColor = true;
        // 
        // cbSwitchM2
        // 
        cbSwitchM2.AutoSize = true;
        cbSwitchM2.Location = new System.Drawing.Point(189, 22);
        cbSwitchM2.Name = "cbSwitchM2";
        cbSwitchM2.Size = new System.Drawing.Size(75, 19);
        cbSwitchM2.TabIndex = 2;
        cbSwitchM2.Text = "m2 - Fast";
        cbSwitchM2.UseVisualStyleBackColor = true;
        // 
        // cbSwitchM1
        // 
        cbSwitchM1.AutoSize = true;
        cbSwitchM1.Location = new System.Drawing.Point(93, 22);
        cbSwitchM1.Name = "cbSwitchM1";
        cbSwitchM1.Size = new System.Drawing.Size(90, 19);
        cbSwitchM1.TabIndex = 1;
        cbSwitchM1.Text = "m1 - Fastest";
        cbSwitchM1.UseVisualStyleBackColor = true;
        // 
        // cbSwitchM0
        // 
        cbSwitchM0.AutoSize = true;
        cbSwitchM0.Checked = true;
        cbSwitchM0.CheckState = System.Windows.Forms.CheckState.Checked;
        cbSwitchM0.Location = new System.Drawing.Point(6, 22);
        cbSwitchM0.Name = "cbSwitchM0";
        cbSwitchM0.Size = new System.Drawing.Size(81, 19);
        cbSwitchM0.TabIndex = 0;
        cbSwitchM0.Text = "m0 - Store";
        cbSwitchM0.UseVisualStyleBackColor = true;
        // 
        // gbHostOSOverride
        // 
        gbHostOSOverride.Controls.Add(lblPatchDetails);
        gbHostOSOverride.Controls.Add(lblHostOSInfo);
        gbHostOSOverride.Controls.Add(cbEnableHostOSPatching);
        gbHostOSOverride.Dock = System.Windows.Forms.DockStyle.Top;
        gbHostOSOverride.Location = new System.Drawing.Point(12, 167);
        gbHostOSOverride.Name = "gbHostOSOverride";
        gbHostOSOverride.Size = new System.Drawing.Size(1113, 123);
        gbHostOSOverride.TabIndex = 45;
        gbHostOSOverride.TabStop = false;
        gbHostOSOverride.Text = "Header Patching (post-processing)";
        // 
        // lblPatchDetails
        // 
        lblPatchDetails.Location = new System.Drawing.Point(382, 19);
        lblPatchDetails.Name = "lblPatchDetails";
        lblPatchDetails.Size = new System.Drawing.Size(278, 90);
        lblPatchDetails.TabIndex = 2;
        // 
        // lblHostOSInfo
        // 
        lblHostOSInfo.AutoSize = true;
        lblHostOSInfo.ForeColor = System.Drawing.SystemColors.GrayText;
        lblHostOSInfo.Location = new System.Drawing.Point(6, 59);
        lblHostOSInfo.Name = "lblHostOSInfo";
        lblHostOSInfo.Size = new System.Drawing.Size(270, 15);
        lblHostOSInfo.TabIndex = 1;
        lblHostOSInfo.Text = "Import an SRR to detect header fields for patching";
        // 
        // cbEnableHostOSPatching
        // 
        cbEnableHostOSPatching.Location = new System.Drawing.Point(6, 19);
        cbEnableHostOSPatching.Name = "cbEnableHostOSPatching";
        cbEnableHostOSPatching.Size = new System.Drawing.Size(270, 37);
        cbEnableHostOSPatching.TabIndex = 0;
        cbEnableHostOSPatching.Text = "Patch brute-forced RAR headers to match SRR\r\n(Host OS, attributes, LARGE flag)";
        cbEnableHostOSPatching.UseVisualStyleBackColor = true;
        // 
        // gbFileOptions
        // 
        gbFileOptions.Controls.Add(cbFileI);
        gbFileOptions.Controls.Add(lblFileOptionsInfo);
        gbFileOptions.Controls.Add(cbFileA);
        gbFileOptions.Dock = System.Windows.Forms.DockStyle.Top;
        gbFileOptions.Location = new System.Drawing.Point(12, 80);
        gbFileOptions.Name = "gbFileOptions";
        gbFileOptions.Size = new System.Drawing.Size(1113, 87);
        gbFileOptions.TabIndex = 34;
        gbFileOptions.TabStop = false;
        gbFileOptions.Text = "File options";
        // 
        // cbFileI
        // 
        cbFileI.AutoSize = true;
        cbFileI.Location = new System.Drawing.Point(6, 62);
        cbFileI.Name = "cbFileI";
        cbFileI.Size = new System.Drawing.Size(389, 19);
        cbFileI.TabIndex = 39;
        cbFileI.Text = "I - Set not content indexed attribute on each file before compressing.";
        cbFileI.ThreeState = true;
        cbFileI.UseVisualStyleBackColor = true;
        // 
        // lblFileOptionsInfo
        // 
        lblFileOptionsInfo.AutoSize = true;
        lblFileOptionsInfo.Location = new System.Drawing.Point(6, 19);
        lblFileOptionsInfo.Name = "lblFileOptionsInfo";
        lblFileOptionsInfo.Size = new System.Drawing.Size(456, 15);
        lblFileOptionsInfo.TabIndex = 38;
        lblFileOptionsInfo.Text = "Set the given attribute(s) on the files before archiving. This does not affect directories.";
        // 
        // cbFileA
        // 
        cbFileA.AutoSize = true;
        cbFileA.Checked = true;
        cbFileA.CheckState = System.Windows.Forms.CheckState.Checked;
        cbFileA.Location = new System.Drawing.Point(6, 37);
        cbFileA.Name = "cbFileA";
        cbFileA.Size = new System.Drawing.Size(172, 19);
        cbFileA.TabIndex = 37;
        cbFileA.Text = "A - Set archive file attribute.";
        cbFileA.ThreeState = true;
        cbFileA.UseVisualStyleBackColor = true;
        // 
        // gbRARVersion
        // 
        gbRARVersion.Controls.Add(lblRARVersionInfo);
        gbRARVersion.Controls.Add(cbRARVersion7);
        gbRARVersion.Controls.Add(cbRARVersion6);
        gbRARVersion.Controls.Add(cbRARVersion5);
        gbRARVersion.Controls.Add(cbRARVersion4);
        gbRARVersion.Controls.Add(cbRARVersion3);
        gbRARVersion.Controls.Add(cbRARVersion2);
        gbRARVersion.Dock = System.Windows.Forms.DockStyle.Top;
        gbRARVersion.Location = new System.Drawing.Point(12, 0);
        gbRARVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
        gbRARVersion.Name = "gbRARVersion";
        gbRARVersion.Size = new System.Drawing.Size(1113, 80);
        gbRARVersion.TabIndex = 33;
        gbRARVersion.TabStop = false;
        gbRARVersion.Text = "RAR version";
        // 
        // lblRARVersionInfo
        // 
        lblRARVersionInfo.AutoSize = true;
        lblRARVersionInfo.Location = new System.Drawing.Point(6, 19);
        lblRARVersionInfo.Name = "lblRARVersionInfo";
        lblRARVersionInfo.Size = new System.Drawing.Size(390, 30);
        lblRARVersionInfo.TabIndex = 5;
        lblRARVersionInfo.Text = "The RAR version to compress the release files with.\r\nOlder releases will have been compressed with older versions of WinRAR.";
        // 
        // cbRARVersion7
        // 
        cbRARVersion7.AutoSize = true;
        cbRARVersion7.Location = new System.Drawing.Point(321, 52);
        cbRARVersion7.Name = "cbRARVersion7";
        cbRARVersion7.Size = new System.Drawing.Size(57, 19);
        cbRARVersion7.TabIndex = 6;
        cbRARVersion7.Text = "RAR 7";
        cbRARVersion7.UseVisualStyleBackColor = true;
        // 
        // cbRARVersion6
        // 
        cbRARVersion6.AutoSize = true;
        cbRARVersion6.Location = new System.Drawing.Point(258, 52);
        cbRARVersion6.Name = "cbRARVersion6";
        cbRARVersion6.Size = new System.Drawing.Size(57, 19);
        cbRARVersion6.TabIndex = 4;
        cbRARVersion6.Text = "RAR 6";
        cbRARVersion6.UseVisualStyleBackColor = true;
        // 
        // cbRARVersion5
        // 
        cbRARVersion5.AutoSize = true;
        cbRARVersion5.Location = new System.Drawing.Point(195, 52);
        cbRARVersion5.Name = "cbRARVersion5";
        cbRARVersion5.Size = new System.Drawing.Size(57, 19);
        cbRARVersion5.TabIndex = 3;
        cbRARVersion5.Text = "RAR 5";
        cbRARVersion5.UseVisualStyleBackColor = true;
        // 
        // cbRARVersion4
        // 
        cbRARVersion4.AutoSize = true;
        cbRARVersion4.Checked = true;
        cbRARVersion4.CheckState = System.Windows.Forms.CheckState.Checked;
        cbRARVersion4.Location = new System.Drawing.Point(132, 52);
        cbRARVersion4.Name = "cbRARVersion4";
        cbRARVersion4.Size = new System.Drawing.Size(57, 19);
        cbRARVersion4.TabIndex = 2;
        cbRARVersion4.Text = "RAR 4";
        cbRARVersion4.UseVisualStyleBackColor = true;
        // 
        // cbRARVersion3
        // 
        cbRARVersion3.AutoSize = true;
        cbRARVersion3.Location = new System.Drawing.Point(69, 52);
        cbRARVersion3.Name = "cbRARVersion3";
        cbRARVersion3.Size = new System.Drawing.Size(57, 19);
        cbRARVersion3.TabIndex = 1;
        cbRARVersion3.Text = "RAR 3";
        cbRARVersion3.UseVisualStyleBackColor = true;
        // 
        // cbRARVersion2
        // 
        cbRARVersion2.AutoSize = true;
        cbRARVersion2.Location = new System.Drawing.Point(6, 52);
        cbRARVersion2.Name = "cbRARVersion2";
        cbRARVersion2.Size = new System.Drawing.Size(57, 19);
        cbRARVersion2.TabIndex = 0;
        cbRARVersion2.Text = "RAR 2";
        cbRARVersion2.UseVisualStyleBackColor = true;
        // 
        // SettingsOptionsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        ClientSize = new System.Drawing.Size(1154, 876);
        Controls.Add(panelContent);
        Controls.Add(panelBottom);
        Controls.Add(panelTop);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SettingsOptionsForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Options";
        panelTop.ResumeLayout(false);
        panelTop.PerformLayout();
        gbCheckboxLegend.ResumeLayout(false);
        gbCheckboxLegend.PerformLayout();
        panelBottom.ResumeLayout(false);
        flowBottomRight.ResumeLayout(false);
        flowBottomLeft.ResumeLayout(false);
        flowBottomLeft.PerformLayout();
        panelContent.ResumeLayout(false);
        gbSwitches.ResumeLayout(false);
        gbSwitches.PerformLayout();
        gbFileTime.ResumeLayout(false);
        gbAccessTime.ResumeLayout(false);
        gbAccessTime.PerformLayout();
        gbCreationTime.ResumeLayout(false);
        gbCreationTime.PerformLayout();
        gbModificationTime.ResumeLayout(false);
        gbModificationTime.PerformLayout();
        gbThreads.ResumeLayout(false);
        gbThreads.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nupSwitchMTEnd).EndInit();
        ((System.ComponentModel.ISupportInitialize)nupSwitchMTStart).EndInit();
        gbVolumes.ResumeLayout(false);
        gbSplit.ResumeLayout(false);
        gbSplit.PerformLayout();
        gbDictionarySizes.ResumeLayout(false);
        gbDictionarySizes.PerformLayout();
        gbArchiveFormat.ResumeLayout(false);
        gbArchiveFormat.PerformLayout();
        gbCompressionLevels.ResumeLayout(false);
        gbCompressionLevels.PerformLayout();
        gbHostOSOverride.ResumeLayout(false);
        gbHostOSOverride.PerformLayout();
        gbFileOptions.ResumeLayout(false);
        gbFileOptions.PerformLayout();
        gbRARVersion.ResumeLayout(false);
        gbRARVersion.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Panel panelBottom;
    private System.Windows.Forms.Panel panelContent;
    private System.Windows.Forms.FlowLayoutPanel flowBottomLeft;
    private System.Windows.Forms.FlowLayoutPanel flowBottomRight;
    private System.Windows.Forms.GroupBox gbFileOptions;
        private System.Windows.Forms.GroupBox gbRARVersion;
        private System.Windows.Forms.Label lblRARVersionInfo;
        private System.Windows.Forms.CheckBox cbRARVersion7;
        private System.Windows.Forms.CheckBox cbRARVersion6;
        private System.Windows.Forms.CheckBox cbRARVersion5;
        private System.Windows.Forms.CheckBox cbRARVersion4;
        private System.Windows.Forms.CheckBox cbRARVersion3;
        private System.Windows.Forms.CheckBox cbRARVersion2;
        private System.Windows.Forms.GroupBox gbSwitches;
        private System.Windows.Forms.GroupBox gbThreads;
        private System.Windows.Forms.CheckBox cbSwitchMT;
        private System.Windows.Forms.Label lblMTInclusive;
        private System.Windows.Forms.Label lblMTTo;
        private System.Windows.Forms.NumericUpDown nupSwitchMTEnd;
        private System.Windows.Forms.Label lblMTFrom;
        private System.Windows.Forms.Label lblMTNote;
        private System.Windows.Forms.NumericUpDown nupSwitchMTStart;
        private System.Windows.Forms.CheckBox cbSwitchAI;
        private System.Windows.Forms.Label lblSwitchesInfo;
        private System.Windows.Forms.GroupBox gbVolumes;
        private System.Windows.Forms.GroupBox gbSplit;
        private System.Windows.Forms.RadioButton rbSwitchSizeKB;
        private System.Windows.Forms.CheckBox cbSwitchV;
        private System.Windows.Forms.RadioButton rbSwitchSizeGB;
        private System.Windows.Forms.RadioButton rbSwitchSizeMB;
        private System.Windows.Forms.CheckBox cbSwitchR;
        private System.Windows.Forms.GroupBox gbDictionarySizes;
        private System.Windows.Forms.CheckBox cbSwitchMD1G;
        private System.Windows.Forms.CheckBox cbSwitchMD512M;
        private System.Windows.Forms.CheckBox cbSwitchMD256M;
        private System.Windows.Forms.CheckBox cbSwitchMD128M;
        private System.Windows.Forms.CheckBox cbSwitchMD64M;
        private System.Windows.Forms.CheckBox cbSwitchMD32M;
        private System.Windows.Forms.CheckBox cbSwitchMD16M;
        private System.Windows.Forms.CheckBox cbSwitchMD8M;
        private System.Windows.Forms.CheckBox cbSwitchMD4096K;
        private System.Windows.Forms.CheckBox cbSwitchMD2048K;
        private System.Windows.Forms.CheckBox cbSwitchMD1024K;
        private System.Windows.Forms.CheckBox cbSwitchMD512K;
        private System.Windows.Forms.CheckBox cbSwitchMD256K;
        private System.Windows.Forms.CheckBox cbSwitchMD128K;
        private System.Windows.Forms.CheckBox cbSwitchMD64K;
        private System.Windows.Forms.GroupBox gbArchiveFormat;
        private System.Windows.Forms.CheckBox cbSwitchMA5;
        private System.Windows.Forms.CheckBox cbSwitchMA4;
        private System.Windows.Forms.GroupBox gbCompressionLevels;
        private System.Windows.Forms.CheckBox cbSwitchM5;
        private System.Windows.Forms.CheckBox cbSwitchM4;
        private System.Windows.Forms.CheckBox cbSwitchM3;
        private System.Windows.Forms.CheckBox cbSwitchM2;
        private System.Windows.Forms.CheckBox cbSwitchM1;
        private System.Windows.Forms.CheckBox cbSwitchM0;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImportSrr;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbFileA;
        private System.Windows.Forms.Label lblFileOptionsInfo;
        private System.Windows.Forms.CheckBox cbDeleteRARFiles;
        private System.Windows.Forms.CheckBox cbDeleteDuplicateCRCFiles;
        private System.Windows.Forms.CheckBox cbSwitchSDash;
        private System.Windows.Forms.CheckBox cbSwitchDS;
        private System.Windows.Forms.GroupBox gbFileTime;
        private System.Windows.Forms.GroupBox gbAccessTime;
        private System.Windows.Forms.CheckBox cbSwitchTSA4;
        private System.Windows.Forms.CheckBox cbSwitchTSA3;
        private System.Windows.Forms.CheckBox cbSwitchTSA2;
        private System.Windows.Forms.CheckBox cbSwitchTSA1;
        private System.Windows.Forms.CheckBox cbSwitchTSA0;
        private System.Windows.Forms.GroupBox gbCreationTime;
        private System.Windows.Forms.CheckBox cbSwitchTSC4;
        private System.Windows.Forms.CheckBox cbSwitchTSC3;
        private System.Windows.Forms.CheckBox cbSwitchTSC2;
        private System.Windows.Forms.CheckBox cbSwitchTSC1;
        private System.Windows.Forms.CheckBox cbSwitchTSC0;
        private System.Windows.Forms.GroupBox gbModificationTime;
        private System.Windows.Forms.CheckBox cbSwitchTSM4;
        private System.Windows.Forms.CheckBox cbSwitchTSM3;
        private System.Windows.Forms.CheckBox cbSwitchTSM2;
        private System.Windows.Forms.CheckBox cbSwitchTSM1;
        private System.Windows.Forms.CheckBox cbSwitchTSM0;
        private System.Windows.Forms.CheckBox cbFileI;
        private System.Windows.Forms.CheckBox cbLegendNever;
        private System.Windows.Forms.CheckBox cbLegendSometimes;
        private System.Windows.Forms.CheckBox cbLegendAlways;
        private System.Windows.Forms.GroupBox gbCheckboxLegend;
        private System.Windows.Forms.RadioButton rbSwitchSizeBytes;
        private System.Windows.Forms.RadioButton rbSwitchSizeGiB;
        private System.Windows.Forms.RadioButton rbSwitchSizeMiB;
        private System.Windows.Forms.RadioButton rbSwitchSizeKiB;
        private System.Windows.Forms.TextBox tbSwitchSize;
        private System.Windows.Forms.GroupBox gbHostOSOverride;
        private System.Windows.Forms.CheckBox cbEnableHostOSPatching;
        private System.Windows.Forms.Label lblHostOSInfo;
        private System.Windows.Forms.Label lblPatchDetails;
        private System.Windows.Forms.CheckBox cbStopOnFirstMatch;
        private System.Windows.Forms.CheckBox cbCompleteAllVolumes;
        private System.Windows.Forms.CheckBox cbRenameToOriginal;
        private System.Windows.Forms.CheckBox cbUseOldVolumeNaming;
}
