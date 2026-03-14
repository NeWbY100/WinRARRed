namespace WinRARRed.Forms;

partial class RARChecksumNotFoundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RARChecksumNotFoundForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.systemIconError1 = new WinRARRed.Controls.SystemIconError();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.systemIconError1);
            this.panelContent.Controls.Add(this.lblErrorMessage);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panel1";
            this.panelContent.Size = new System.Drawing.Size(531, 72);
            this.panelContent.TabIndex = 8;
            // 
            // systemIconError1
            // 
            this.systemIconError1.Location = new System.Drawing.Point(21, 18);
            this.systemIconError1.Name = "systemIconError1";
            this.systemIconError1.Size = new System.Drawing.Size(32, 32);
            this.systemIconError1.TabIndex = 7;
            this.systemIconError1.Text = "systemIconError1";
            // 
            // label1
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMessage.Location = new System.Drawing.Point(59, 18);
            this.lblErrorMessage.Name = "label1";
            this.lblErrorMessage.Size = new System.Drawing.Size(472, 54);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.Text = resources.GetString("label1.Text");
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(444, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // RARChecksumNotFoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(531, 115);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RARChecksumNotFoundForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error: RAR checksum not found";
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnOK;
    private Controls.SystemIconError systemIconError1;
}