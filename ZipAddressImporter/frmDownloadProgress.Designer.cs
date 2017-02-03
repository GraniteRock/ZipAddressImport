namespace ZipAddressImporter
{
    partial class frmDownloadProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloadProgress));
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDownloadInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressDownload
            // 
            this.progressDownload.Location = new System.Drawing.Point(12, 31);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(401, 23);
            this.progressDownload.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "中断";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(223, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDownloadInfo
            // 
            this.lblDownloadInfo.AutoSize = true;
            this.lblDownloadInfo.Location = new System.Drawing.Point(12, 16);
            this.lblDownloadInfo.Name = "lblDownloadInfo";
            this.lblDownloadInfo.Size = new System.Drawing.Size(0, 12);
            this.lblDownloadInfo.TabIndex = 3;
            // 
            // frmDownloadProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 95);
            this.Controls.Add(this.lblDownloadInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressDownload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDownloadProgress";
            this.Text = "ダウンロード進捗状況";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDownloadProgress_FormClosed);
            this.Load += new System.EventHandler(this.frmDownloadProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressDownload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDownloadInfo;
    }
}