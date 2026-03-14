namespace WinRARRed.Controls;

partial class OperationProgressStatusUserControl
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        gbStatus = new System.Windows.Forms.GroupBox();
        tlpMain = new System.Windows.Forms.TableLayoutPanel();
        lblProgressLabel = new System.Windows.Forms.Label();
        pbProgress = new System.Windows.Forms.ProgressBar();
        lblProgress = new System.Windows.Forms.Label();
        tlpDetails = new System.Windows.Forms.TableLayoutPanel();
        lblOperationSizeLabel = new System.Windows.Forms.Label();
        lblStatusOperationSize = new System.Windows.Forms.Label();
        lblOperationProgressedLabel = new System.Windows.Forms.Label();
        lblStatusOperationProgressed = new System.Windows.Forms.Label();
        lblOperationRemainingLabel = new System.Windows.Forms.Label();
        lblStatusOperationRemaining = new System.Windows.Forms.Label();
        lblStartDateTimeLabel = new System.Windows.Forms.Label();
        lblStatusOperationStartDateTime = new System.Windows.Forms.Label();
        lblTimeElapsedLabel = new System.Windows.Forms.Label();
        lblStatusOperationTimeElapsed = new System.Windows.Forms.Label();
        lblTimeRemainingLabel = new System.Windows.Forms.Label();
        lblStatusOperationTimeRemaining = new System.Windows.Forms.Label();
        lblOperationSpeedLabel = new System.Windows.Forms.Label();
        lblStatusOperationSpeed = new System.Windows.Forms.Label();
        lblEstimatedFinishLabel = new System.Windows.Forms.Label();
        lblStatusOperationEstimatedFinishDateTime = new System.Windows.Forms.Label();
        lblProgressPercentLabel = new System.Windows.Forms.Label();
        lblStatusOperationProgress = new System.Windows.Forms.Label();
        lblStatusLabel = new System.Windows.Forms.Label();
        tbStatus = new System.Windows.Forms.TextBox();
        gbStatus.SuspendLayout();
        tlpMain.SuspendLayout();
        tlpDetails.SuspendLayout();
        SuspendLayout();
        //
        // gbStatus
        //
        gbStatus.Controls.Add(tlpMain);
        gbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
        gbStatus.Location = new System.Drawing.Point(0, 0);
        gbStatus.Name = "gbStatus";
        gbStatus.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
        gbStatus.Size = new System.Drawing.Size(708, 199);
        gbStatus.TabIndex = 6;
        gbStatus.TabStop = false;
        gbStatus.Text = "Archiving release status";
        //
        // tlpMain
        //
        tlpMain.ColumnCount = 3;
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.Controls.Add(lblProgressLabel, 0, 0);
        tlpMain.Controls.Add(pbProgress, 1, 0);
        tlpMain.Controls.Add(lblProgress, 2, 0);
        tlpMain.Controls.Add(tlpDetails, 0, 1);
        tlpMain.Controls.Add(lblStatusLabel, 0, 2);
        tlpMain.Controls.Add(tbStatus, 1, 2);
        tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpMain.Location = new System.Drawing.Point(6, 19);
        tlpMain.Name = "tlpMain";
        tlpMain.RowCount = 3;
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.Size = new System.Drawing.Size(696, 177);
        tlpMain.TabIndex = 0;
        tlpMain.SetColumnSpan(tlpDetails, 3);
        tlpMain.SetColumnSpan(tbStatus, 2);
        //
        // lblProgressLabel
        //
        lblProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblProgressLabel.AutoSize = true;
        lblProgressLabel.Location = new System.Drawing.Point(3, 7);
        lblProgressLabel.Name = "lblProgressLabel";
        lblProgressLabel.Size = new System.Drawing.Size(55, 15);
        lblProgressLabel.TabIndex = 0;
        lblProgressLabel.Text = "Progress:";
        //
        // pbProgress
        //
        pbProgress.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        pbProgress.Location = new System.Drawing.Point(64, 3);
        pbProgress.Name = "pbProgress";
        pbProgress.Size = new System.Drawing.Size(590, 23);
        pbProgress.TabIndex = 1;
        //
        // lblProgress
        //
        lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblProgress.AutoSize = true;
        lblProgress.Location = new System.Drawing.Point(660, 7);
        lblProgress.Name = "lblProgress";
        lblProgress.Size = new System.Drawing.Size(35, 15);
        lblProgress.TabIndex = 2;
        lblProgress.Text = "100%";
        //
        // tlpDetails
        //
        tlpDetails.AutoSize = true;
        tlpDetails.ColumnCount = 6;
        tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.Controls.Add(lblOperationSizeLabel, 0, 0);
        tlpDetails.Controls.Add(lblStatusOperationSize, 1, 0);
        tlpDetails.Controls.Add(lblOperationProgressedLabel, 0, 1);
        tlpDetails.Controls.Add(lblStatusOperationProgressed, 1, 1);
        tlpDetails.Controls.Add(lblOperationRemainingLabel, 0, 2);
        tlpDetails.Controls.Add(lblStatusOperationRemaining, 1, 2);
        tlpDetails.Controls.Add(lblStartDateTimeLabel, 2, 0);
        tlpDetails.Controls.Add(lblStatusOperationStartDateTime, 3, 0);
        tlpDetails.Controls.Add(lblTimeElapsedLabel, 2, 1);
        tlpDetails.Controls.Add(lblStatusOperationTimeElapsed, 3, 1);
        tlpDetails.Controls.Add(lblTimeRemainingLabel, 2, 2);
        tlpDetails.Controls.Add(lblStatusOperationTimeRemaining, 3, 2);
        tlpDetails.Controls.Add(lblOperationSpeedLabel, 4, 0);
        tlpDetails.Controls.Add(lblStatusOperationSpeed, 5, 0);
        tlpDetails.Controls.Add(lblEstimatedFinishLabel, 4, 1);
        tlpDetails.Controls.Add(lblStatusOperationEstimatedFinishDateTime, 5, 1);
        tlpDetails.Controls.Add(lblProgressPercentLabel, 4, 2);
        tlpDetails.Controls.Add(lblStatusOperationProgress, 5, 2);
        tlpDetails.Dock = System.Windows.Forms.DockStyle.Top;
        tlpDetails.Location = new System.Drawing.Point(0, 29);
        tlpDetails.Margin = new System.Windows.Forms.Padding(0);
        tlpDetails.Name = "tlpDetails";
        tlpDetails.RowCount = 3;
        tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpDetails.Size = new System.Drawing.Size(696, 51);
        tlpDetails.TabIndex = 3;
        //
        // lblOperationSizeLabel
        //
        lblOperationSizeLabel.AutoSize = true;
        lblOperationSizeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblOperationSizeLabel.Name = "lblOperationSizeLabel";
        lblOperationSizeLabel.Size = new System.Drawing.Size(85, 15);
        lblOperationSizeLabel.TabIndex = 0;
        lblOperationSizeLabel.Text = "Operation size:";
        //
        // lblStatusOperationSize
        //
        lblStatusOperationSize.AutoSize = true;
        lblStatusOperationSize.Margin = new System.Windows.Forms.Padding(3, 2, 12, 0);
        lblStatusOperationSize.MinimumSize = new System.Drawing.Size(60, 0);
        lblStatusOperationSize.Name = "lblStatusOperationSize";
        lblStatusOperationSize.Size = new System.Drawing.Size(60, 15);
        lblStatusOperationSize.TabIndex = 1;
        lblStatusOperationSize.Text = "-";
        //
        // lblOperationProgressedLabel
        //
        lblOperationProgressedLabel.AutoSize = true;
        lblOperationProgressedLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblOperationProgressedLabel.Name = "lblOperationProgressedLabel";
        lblOperationProgressedLabel.Size = new System.Drawing.Size(124, 15);
        lblOperationProgressedLabel.TabIndex = 2;
        lblOperationProgressedLabel.Text = "Operation progressed:";
        //
        // lblStatusOperationProgressed
        //
        lblStatusOperationProgressed.AutoSize = true;
        lblStatusOperationProgressed.Margin = new System.Windows.Forms.Padding(3, 2, 12, 0);
        lblStatusOperationProgressed.MinimumSize = new System.Drawing.Size(60, 0);
        lblStatusOperationProgressed.Name = "lblStatusOperationProgressed";
        lblStatusOperationProgressed.Size = new System.Drawing.Size(60, 15);
        lblStatusOperationProgressed.TabIndex = 3;
        lblStatusOperationProgressed.Text = "-";
        //
        // lblOperationRemainingLabel
        //
        lblOperationRemainingLabel.AutoSize = true;
        lblOperationRemainingLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblOperationRemainingLabel.Name = "lblOperationRemainingLabel";
        lblOperationRemainingLabel.Size = new System.Drawing.Size(120, 15);
        lblOperationRemainingLabel.TabIndex = 4;
        lblOperationRemainingLabel.Text = "Operation remaining:";
        //
        // lblStatusOperationRemaining
        //
        lblStatusOperationRemaining.AutoSize = true;
        lblStatusOperationRemaining.Margin = new System.Windows.Forms.Padding(3, 2, 12, 0);
        lblStatusOperationRemaining.MinimumSize = new System.Drawing.Size(60, 0);
        lblStatusOperationRemaining.Name = "lblStatusOperationRemaining";
        lblStatusOperationRemaining.Size = new System.Drawing.Size(60, 15);
        lblStatusOperationRemaining.TabIndex = 5;
        lblStatusOperationRemaining.Text = "-";
        //
        // lblStartDateTimeLabel
        //
        lblStartDateTimeLabel.AutoSize = true;
        lblStartDateTimeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblStartDateTimeLabel.Name = "lblStartDateTimeLabel";
        lblStartDateTimeLabel.Size = new System.Drawing.Size(89, 15);
        lblStartDateTimeLabel.TabIndex = 6;
        lblStartDateTimeLabel.Text = "Start date/time:";
        //
        // lblStatusOperationStartDateTime
        //
        lblStatusOperationStartDateTime.AutoSize = true;
        lblStatusOperationStartDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 12, 0);
        lblStatusOperationStartDateTime.MinimumSize = new System.Drawing.Size(120, 0);
        lblStatusOperationStartDateTime.Name = "lblStatusOperationStartDateTime";
        lblStatusOperationStartDateTime.Size = new System.Drawing.Size(120, 15);
        lblStatusOperationStartDateTime.TabIndex = 7;
        lblStatusOperationStartDateTime.Text = "-";
        //
        // lblTimeElapsedLabel
        //
        lblTimeElapsedLabel.AutoSize = true;
        lblTimeElapsedLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblTimeElapsedLabel.Name = "lblTimeElapsedLabel";
        lblTimeElapsedLabel.Size = new System.Drawing.Size(79, 15);
        lblTimeElapsedLabel.TabIndex = 8;
        lblTimeElapsedLabel.Text = "Time elapsed:";
        //
        // lblStatusOperationTimeElapsed
        //
        lblStatusOperationTimeElapsed.AutoSize = true;
        lblStatusOperationTimeElapsed.Margin = new System.Windows.Forms.Padding(3, 2, 12, 0);
        lblStatusOperationTimeElapsed.MinimumSize = new System.Drawing.Size(120, 0);
        lblStatusOperationTimeElapsed.Name = "lblStatusOperationTimeElapsed";
        lblStatusOperationTimeElapsed.Size = new System.Drawing.Size(120, 15);
        lblStatusOperationTimeElapsed.TabIndex = 9;
        lblStatusOperationTimeElapsed.Text = "-";
        //
        // lblTimeRemainingLabel
        //
        lblTimeRemainingLabel.AutoSize = true;
        lblTimeRemainingLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblTimeRemainingLabel.Name = "lblTimeRemainingLabel";
        lblTimeRemainingLabel.Size = new System.Drawing.Size(93, 15);
        lblTimeRemainingLabel.TabIndex = 10;
        lblTimeRemainingLabel.Text = "Time remaining:";
        //
        // lblStatusOperationTimeRemaining
        //
        lblStatusOperationTimeRemaining.AutoSize = true;
        lblStatusOperationTimeRemaining.Margin = new System.Windows.Forms.Padding(3, 2, 12, 0);
        lblStatusOperationTimeRemaining.MinimumSize = new System.Drawing.Size(120, 0);
        lblStatusOperationTimeRemaining.Name = "lblStatusOperationTimeRemaining";
        lblStatusOperationTimeRemaining.Size = new System.Drawing.Size(120, 15);
        lblStatusOperationTimeRemaining.TabIndex = 11;
        lblStatusOperationTimeRemaining.Text = "-";
        //
        // lblOperationSpeedLabel
        //
        lblOperationSpeedLabel.AutoSize = true;
        lblOperationSpeedLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblOperationSpeedLabel.Name = "lblOperationSpeedLabel";
        lblOperationSpeedLabel.Size = new System.Drawing.Size(97, 15);
        lblOperationSpeedLabel.TabIndex = 12;
        lblOperationSpeedLabel.Text = "Operation speed:";
        //
        // lblStatusOperationSpeed
        //
        lblStatusOperationSpeed.AutoSize = true;
        lblStatusOperationSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblStatusOperationSpeed.MinimumSize = new System.Drawing.Size(120, 0);
        lblStatusOperationSpeed.Name = "lblStatusOperationSpeed";
        lblStatusOperationSpeed.Size = new System.Drawing.Size(120, 15);
        lblStatusOperationSpeed.TabIndex = 13;
        lblStatusOperationSpeed.Text = "-";
        //
        // lblEstimatedFinishLabel
        //
        lblEstimatedFinishLabel.AutoSize = true;
        lblEstimatedFinishLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblEstimatedFinishLabel.Name = "lblEstimatedFinishLabel";
        lblEstimatedFinishLabel.Size = new System.Drawing.Size(149, 15);
        lblEstimatedFinishLabel.TabIndex = 14;
        lblEstimatedFinishLabel.Text = "Estimated finish date/time:";
        //
        // lblStatusOperationEstimatedFinishDateTime
        //
        lblStatusOperationEstimatedFinishDateTime.AutoSize = true;
        lblStatusOperationEstimatedFinishDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblStatusOperationEstimatedFinishDateTime.MinimumSize = new System.Drawing.Size(120, 0);
        lblStatusOperationEstimatedFinishDateTime.Name = "lblStatusOperationEstimatedFinishDateTime";
        lblStatusOperationEstimatedFinishDateTime.Size = new System.Drawing.Size(120, 15);
        lblStatusOperationEstimatedFinishDateTime.TabIndex = 15;
        lblStatusOperationEstimatedFinishDateTime.Text = "-";
        //
        // lblProgressPercentLabel
        //
        lblProgressPercentLabel.AutoSize = true;
        lblProgressPercentLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblProgressPercentLabel.Name = "lblProgressPercentLabel";
        lblProgressPercentLabel.Size = new System.Drawing.Size(55, 15);
        lblProgressPercentLabel.TabIndex = 16;
        lblProgressPercentLabel.Text = "Progress:";
        //
        // lblStatusOperationProgress
        //
        lblStatusOperationProgress.AutoSize = true;
        lblStatusOperationProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblStatusOperationProgress.MinimumSize = new System.Drawing.Size(120, 0);
        lblStatusOperationProgress.Name = "lblStatusOperationProgress";
        lblStatusOperationProgress.Size = new System.Drawing.Size(120, 15);
        lblStatusOperationProgress.TabIndex = 17;
        lblStatusOperationProgress.Text = "-";
        //
        // lblStatusLabel
        //
        lblStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
        lblStatusLabel.AutoSize = true;
        lblStatusLabel.Location = new System.Drawing.Point(3, 82);
        lblStatusLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
        lblStatusLabel.Name = "lblStatusLabel";
        lblStatusLabel.Size = new System.Drawing.Size(42, 15);
        lblStatusLabel.TabIndex = 4;
        lblStatusLabel.Text = "Status:";
        //
        // tbStatus
        //
        tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
        tbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
        tbStatus.Multiline = true;
        tbStatus.Name = "tbStatus";
        tbStatus.ReadOnly = true;
        tbStatus.Size = new System.Drawing.Size(632, 97);
        tbStatus.TabIndex = 5;
        tbStatus.Text = "Waiting to start...";
        //
        // OperationProgressStatusUserControl
        //
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        Controls.Add(gbStatus);
        Name = "OperationProgressStatusUserControl";
        Size = new System.Drawing.Size(708, 199);
        gbStatus.ResumeLayout(false);
        tlpMain.ResumeLayout(false);
        tlpMain.PerformLayout();
        tlpDetails.ResumeLayout(false);
        tlpDetails.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox gbStatus;
    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.Label lblProgressLabel;
    private System.Windows.Forms.ProgressBar pbProgress;
    private System.Windows.Forms.Label lblProgress;
    private System.Windows.Forms.TableLayoutPanel tlpDetails;
    private System.Windows.Forms.Label lblOperationSizeLabel;
    private System.Windows.Forms.Label lblStatusOperationSize;
    private System.Windows.Forms.Label lblOperationProgressedLabel;
    private System.Windows.Forms.Label lblStatusOperationProgressed;
    private System.Windows.Forms.Label lblOperationRemainingLabel;
    private System.Windows.Forms.Label lblStatusOperationRemaining;
    private System.Windows.Forms.Label lblStartDateTimeLabel;
    private System.Windows.Forms.Label lblStatusOperationStartDateTime;
    private System.Windows.Forms.Label lblTimeElapsedLabel;
    private System.Windows.Forms.Label lblStatusOperationTimeElapsed;
    private System.Windows.Forms.Label lblTimeRemainingLabel;
    private System.Windows.Forms.Label lblStatusOperationTimeRemaining;
    private System.Windows.Forms.Label lblOperationSpeedLabel;
    private System.Windows.Forms.Label lblStatusOperationSpeed;
    private System.Windows.Forms.Label lblEstimatedFinishLabel;
    private System.Windows.Forms.Label lblStatusOperationEstimatedFinishDateTime;
    private System.Windows.Forms.Label lblProgressPercentLabel;
    private System.Windows.Forms.Label lblStatusOperationProgress;
    private System.Windows.Forms.Label lblStatusLabel;
    private System.Windows.Forms.TextBox tbStatus;
}
