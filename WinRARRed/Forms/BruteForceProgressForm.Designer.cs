namespace WinRARRed.Forms;

partial class BruteForceProgressForm
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
        lblPhase = new System.Windows.Forms.Label();
        tlpOverall = new System.Windows.Forms.TableLayoutPanel();
        lblOverallText = new System.Windows.Forms.Label();
        lblOverallPercent = new System.Windows.Forms.Label();
        pbOverall = new System.Windows.Forms.ProgressBar();
        lblCurrentDetail = new System.Windows.Forms.Label();
        tlpSub = new System.Windows.Forms.TableLayoutPanel();
        lblSubText = new System.Windows.Forms.Label();
        lblSubPercent = new System.Windows.Forms.Label();
        pbSub = new System.Windows.Forms.ProgressBar();
        tlpTiming = new System.Windows.Forms.TableLayoutPanel();
        lblElapsedLabel = new System.Windows.Forms.Label();
        lblElapsed = new System.Windows.Forms.Label();
        lblRemainingLabel = new System.Windows.Forms.Label();
        lblRemaining = new System.Windows.Forms.Label();
        lblSpeedLabel = new System.Windows.Forms.Label();
        lblSpeed = new System.Windows.Forms.Label();
        lblETALabel = new System.Windows.Forms.Label();
        lblETA = new System.Windows.Forms.Label();
        lvVersions = new System.Windows.Forms.ListView();
        colVersion = new System.Windows.Forms.ColumnHeader();
        colStatus = new System.Windows.Forms.ColumnHeader();
        colArguments = new System.Windows.Forms.ColumnHeader();
        tlpButtons = new System.Windows.Forms.TableLayoutPanel();
        btnStop = new System.Windows.Forms.Button();
        tlpMain.SuspendLayout();
        tlpOverall.SuspendLayout();
        tlpSub.SuspendLayout();
        tlpTiming.SuspendLayout();
        tlpButtons.SuspendLayout();
        SuspendLayout();
        //
        // tlpMain
        //
        tlpMain.ColumnCount = 1;
        tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.Controls.Add(lblPhase, 0, 0);
        tlpMain.Controls.Add(tlpOverall, 0, 1);
        tlpMain.Controls.Add(pbOverall, 0, 2);
        tlpMain.Controls.Add(lblCurrentDetail, 0, 3);
        tlpMain.Controls.Add(tlpSub, 0, 4);
        tlpMain.Controls.Add(pbSub, 0, 5);
        tlpMain.Controls.Add(tlpTiming, 0, 6);
        tlpMain.Controls.Add(lvVersions, 0, 7);
        tlpMain.Controls.Add(tlpButtons, 0, 8);
        tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpMain.Location = new System.Drawing.Point(0, 0);
        tlpMain.Name = "tlpMain";
        tlpMain.Padding = new System.Windows.Forms.Padding(12);
        tlpMain.RowCount = 9;
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpMain.Size = new System.Drawing.Size(650, 520);
        tlpMain.TabIndex = 0;
        //
        // lblPhase
        //
        lblPhase.AutoSize = true;
        lblPhase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblPhase.Location = new System.Drawing.Point(15, 12);
        lblPhase.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
        lblPhase.Name = "lblPhase";
        lblPhase.Size = new System.Drawing.Size(170, 19);
        lblPhase.TabIndex = 0;
        lblPhase.Text = "Waiting to start...";
        //
        // tlpOverall
        //
        tlpOverall.AutoSize = true;
        tlpOverall.ColumnCount = 2;
        tlpOverall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpOverall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpOverall.Controls.Add(lblOverallText, 0, 0);
        tlpOverall.Controls.Add(lblOverallPercent, 1, 0);
        tlpOverall.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpOverall.Location = new System.Drawing.Point(12, 37);
        tlpOverall.Margin = new System.Windows.Forms.Padding(0);
        tlpOverall.Name = "tlpOverall";
        tlpOverall.RowCount = 1;
        tlpOverall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpOverall.Size = new System.Drawing.Size(526, 15);
        tlpOverall.TabIndex = 1;
        //
        // lblOverallText
        //
        lblOverallText.AutoSize = true;
        lblOverallText.Location = new System.Drawing.Point(0, 0);
        lblOverallText.Margin = new System.Windows.Forms.Padding(0);
        lblOverallText.Name = "lblOverallText";
        lblOverallText.Size = new System.Drawing.Size(82, 15);
        lblOverallText.TabIndex = 0;
        lblOverallText.Text = "Test 0 of 0";
        //
        // lblOverallPercent
        //
        lblOverallPercent.AutoSize = true;
        lblOverallPercent.Location = new System.Drawing.Point(496, 0);
        lblOverallPercent.Margin = new System.Windows.Forms.Padding(0);
        lblOverallPercent.Name = "lblOverallPercent";
        lblOverallPercent.Size = new System.Drawing.Size(33, 15);
        lblOverallPercent.TabIndex = 1;
        lblOverallPercent.Text = "0.0%";
        //
        // pbOverall
        //
        pbOverall.Dock = System.Windows.Forms.DockStyle.Fill;
        pbOverall.Location = new System.Drawing.Point(15, 55);
        pbOverall.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
        pbOverall.Name = "pbOverall";
        pbOverall.Size = new System.Drawing.Size(520, 23);
        pbOverall.TabIndex = 2;
        //
        // lblCurrentDetail
        //
        lblCurrentDetail.AutoSize = true;
        lblCurrentDetail.ForeColor = System.Drawing.SystemColors.GrayText;
        lblCurrentDetail.Location = new System.Drawing.Point(15, 86);
        lblCurrentDetail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
        lblCurrentDetail.Name = "lblCurrentDetail";
        lblCurrentDetail.Size = new System.Drawing.Size(16, 15);
        lblCurrentDetail.TabIndex = 3;
        lblCurrentDetail.Text = "—";
        //
        // tlpSub
        //
        tlpSub.AutoSize = true;
        tlpSub.ColumnCount = 2;
        tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpSub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSub.Controls.Add(lblSubText, 0, 0);
        tlpSub.Controls.Add(lblSubPercent, 1, 0);
        tlpSub.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpSub.Location = new System.Drawing.Point(12, 107);
        tlpSub.Margin = new System.Windows.Forms.Padding(0);
        tlpSub.Name = "tlpSub";
        tlpSub.RowCount = 1;
        tlpSub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpSub.Size = new System.Drawing.Size(526, 15);
        tlpSub.TabIndex = 4;
        //
        // lblSubText
        //
        lblSubText.AutoSize = true;
        lblSubText.Location = new System.Drawing.Point(0, 0);
        lblSubText.Margin = new System.Windows.Forms.Padding(0);
        lblSubText.Name = "lblSubText";
        lblSubText.Size = new System.Drawing.Size(16, 15);
        lblSubText.TabIndex = 0;
        lblSubText.Text = "—";
        //
        // lblSubPercent
        //
        lblSubPercent.AutoSize = true;
        lblSubPercent.Location = new System.Drawing.Point(496, 0);
        lblSubPercent.Margin = new System.Windows.Forms.Padding(0);
        lblSubPercent.Name = "lblSubPercent";
        lblSubPercent.Size = new System.Drawing.Size(0, 15);
        lblSubPercent.TabIndex = 1;
        //
        // pbSub
        //
        pbSub.Dock = System.Windows.Forms.DockStyle.Fill;
        pbSub.Location = new System.Drawing.Point(15, 125);
        pbSub.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
        pbSub.Name = "pbSub";
        pbSub.Size = new System.Drawing.Size(520, 23);
        pbSub.TabIndex = 5;
        //
        // tlpTiming
        //
        tlpTiming.AutoSize = true;
        tlpTiming.ColumnCount = 4;
        tlpTiming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpTiming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpTiming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpTiming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpTiming.Controls.Add(lblElapsedLabel, 0, 0);
        tlpTiming.Controls.Add(lblElapsed, 1, 0);
        tlpTiming.Controls.Add(lblRemainingLabel, 2, 0);
        tlpTiming.Controls.Add(lblRemaining, 3, 0);
        tlpTiming.Controls.Add(lblSpeedLabel, 0, 1);
        tlpTiming.Controls.Add(lblSpeed, 1, 1);
        tlpTiming.Controls.Add(lblETALabel, 2, 1);
        tlpTiming.Controls.Add(lblETA, 3, 1);
        tlpTiming.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpTiming.Location = new System.Drawing.Point(12, 156);
        tlpTiming.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
        tlpTiming.Name = "tlpTiming";
        tlpTiming.RowCount = 2;
        tlpTiming.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpTiming.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpTiming.Size = new System.Drawing.Size(526, 34);
        tlpTiming.TabIndex = 6;
        //
        // lblElapsedLabel
        //
        lblElapsedLabel.AutoSize = true;
        lblElapsedLabel.Margin = new System.Windows.Forms.Padding(0, 2, 4, 2);
        lblElapsedLabel.Name = "lblElapsedLabel";
        lblElapsedLabel.Size = new System.Drawing.Size(51, 15);
        lblElapsedLabel.TabIndex = 0;
        lblElapsedLabel.Text = "Elapsed:";
        //
        // lblElapsed
        //
        lblElapsed.AutoSize = true;
        lblElapsed.Margin = new System.Windows.Forms.Padding(0, 2, 12, 2);
        lblElapsed.Name = "lblElapsed";
        lblElapsed.Size = new System.Drawing.Size(49, 15);
        lblElapsed.TabIndex = 1;
        lblElapsed.Text = "00:00:00";
        //
        // lblRemainingLabel
        //
        lblRemainingLabel.AutoSize = true;
        lblRemainingLabel.Margin = new System.Windows.Forms.Padding(0, 2, 4, 2);
        lblRemainingLabel.Name = "lblRemainingLabel";
        lblRemainingLabel.Size = new System.Drawing.Size(68, 15);
        lblRemainingLabel.TabIndex = 2;
        lblRemainingLabel.Text = "Remaining:";
        //
        // lblRemaining
        //
        lblRemaining.AutoSize = true;
        lblRemaining.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        lblRemaining.Name = "lblRemaining";
        lblRemaining.Size = new System.Drawing.Size(52, 15);
        lblRemaining.TabIndex = 3;
        lblRemaining.Text = "--:--:--";
        //
        // lblSpeedLabel
        //
        lblSpeedLabel.AutoSize = true;
        lblSpeedLabel.Margin = new System.Windows.Forms.Padding(0, 2, 4, 2);
        lblSpeedLabel.Name = "lblSpeedLabel";
        lblSpeedLabel.Size = new System.Drawing.Size(42, 15);
        lblSpeedLabel.TabIndex = 4;
        lblSpeedLabel.Text = "Speed:";
        //
        // lblSpeed
        //
        lblSpeed.AutoSize = true;
        lblSpeed.Margin = new System.Windows.Forms.Padding(0, 2, 12, 2);
        lblSpeed.Name = "lblSpeed";
        lblSpeed.Size = new System.Drawing.Size(24, 15);
        lblSpeed.TabIndex = 5;
        lblSpeed.Text = "—";
        //
        // lblETALabel
        //
        lblETALabel.AutoSize = true;
        lblETALabel.Margin = new System.Windows.Forms.Padding(0, 2, 4, 2);
        lblETALabel.Name = "lblETALabel";
        lblETALabel.Size = new System.Drawing.Size(30, 15);
        lblETALabel.TabIndex = 6;
        lblETALabel.Text = "ETA:";
        //
        // lblETA
        //
        lblETA.AutoSize = true;
        lblETA.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        lblETA.Name = "lblETA";
        lblETA.Size = new System.Drawing.Size(24, 15);
        lblETA.TabIndex = 7;
        lblETA.Text = "—";
        //
        // lvVersions
        //
        lvVersions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colVersion, colStatus, colArguments });
        lvVersions.Dock = System.Windows.Forms.DockStyle.Fill;
        lvVersions.FullRowSelect = true;
        lvVersions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        lvVersions.Location = new System.Drawing.Point(15, 201);
        lvVersions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
        lvVersions.Name = "lvVersions";
        lvVersions.Size = new System.Drawing.Size(520, 200);
        lvVersions.TabIndex = 7;
        lvVersions.UseCompatibleStateImageBehavior = false;
        lvVersions.View = System.Windows.Forms.View.Details;
        lvVersions.VirtualMode = true;
        //
        // colVersion
        //
        colVersion.Text = "Version";
        colVersion.Width = 130;
        //
        // colStatus
        //
        colStatus.Text = "Status";
        colStatus.Width = 80;
        //
        // colArguments
        //
        colArguments.Text = "Arguments";
        colArguments.Width = 310;
        //
        // tlpButtons
        //
        tlpButtons.AutoSize = true;
        tlpButtons.ColumnCount = 2;
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpButtons.Controls.Add(btnStop, 1, 0);
        tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpButtons.Location = new System.Drawing.Point(12, 198);
        tlpButtons.Margin = new System.Windows.Forms.Padding(0);
        tlpButtons.Name = "tlpButtons";
        tlpButtons.RowCount = 1;
        tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        tlpButtons.Size = new System.Drawing.Size(526, 35);
        tlpButtons.TabIndex = 8;
        //
        // btnStop
        //
        btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        btnStop.Location = new System.Drawing.Point(440, 98);
        btnStop.Name = "btnStop";
        btnStop.Size = new System.Drawing.Size(83, 29);
        btnStop.TabIndex = 0;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        //
        // BruteForceProgressForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        ClientSize = new System.Drawing.Size(650, 520);
        Controls.Add(tlpMain);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(500, 400);
        Name = "BruteForceProgressForm";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Brute Force Progress";
        tlpMain.ResumeLayout(false);
        tlpMain.PerformLayout();
        tlpOverall.ResumeLayout(false);
        tlpOverall.PerformLayout();
        tlpSub.ResumeLayout(false);
        tlpSub.PerformLayout();
        tlpTiming.ResumeLayout(false);
        tlpTiming.PerformLayout();
        tlpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.Label lblPhase;
    private System.Windows.Forms.TableLayoutPanel tlpOverall;
    private System.Windows.Forms.Label lblOverallText;
    private System.Windows.Forms.Label lblOverallPercent;
    private System.Windows.Forms.ProgressBar pbOverall;
    private System.Windows.Forms.Label lblCurrentDetail;
    private System.Windows.Forms.TableLayoutPanel tlpSub;
    private System.Windows.Forms.Label lblSubText;
    private System.Windows.Forms.Label lblSubPercent;
    private System.Windows.Forms.ProgressBar pbSub;
    private System.Windows.Forms.TableLayoutPanel tlpTiming;
    private System.Windows.Forms.Label lblElapsedLabel;
    private System.Windows.Forms.Label lblElapsed;
    private System.Windows.Forms.Label lblRemainingLabel;
    private System.Windows.Forms.Label lblRemaining;
    private System.Windows.Forms.Label lblSpeedLabel;
    private System.Windows.Forms.Label lblSpeed;
    private System.Windows.Forms.Label lblETALabel;
    private System.Windows.Forms.Label lblETA;
    private System.Windows.Forms.ListView lvVersions;
    private System.Windows.Forms.ColumnHeader colVersion;
    private System.Windows.Forms.ColumnHeader colStatus;
    private System.Windows.Forms.ColumnHeader colArguments;
    private System.Windows.Forms.TableLayoutPanel tlpButtons;
    private System.Windows.Forms.Button btnStop;
}
