namespace ZipAddressImporter
{
    partial class frmZipAddressImporter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZipAddressImporter));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDirSelect = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileDownloadDir = new System.Windows.Forms.TextBox();
            this.txtUrlPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZipFileSelect = new System.Windows.Forms.Button();
            this.btnZipExtract = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExtractPath = new System.Windows.Forms.TextBox();
            this.txtExtractZipFileName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDataImport = new System.Windows.Forms.Button();
            this.dgCsvList = new System.Windows.Forms.DataGridView();
            this.txtCsvFilePath = new System.Windows.Forms.TextBox();
            this.btnCSVFileSelect = new System.Windows.Forms.Button();
            this.btnImports = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCsvList)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.btnDirSelect);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFileDownloadDir);
            this.groupBox1.Controls.Add(this.txtUrlPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ファイルダウンロード";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(192, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "↓";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(242, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "↓";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(216, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "↓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ファイル名";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(178, 156);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(103, 35);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "ダウンロード";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDirSelect
            // 
            this.btnDirSelect.Location = new System.Drawing.Point(412, 90);
            this.btnDirSelect.Name = "btnDirSelect";
            this.btnDirSelect.Size = new System.Drawing.Size(29, 23);
            this.btnDirSelect.TabIndex = 3;
            this.btnDirSelect.Text = "...";
            this.btnDirSelect.UseVisualStyleBackColor = true;
            this.btnDirSelect.Click += new System.EventHandler(this.btnDirSelect_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(18, 129);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(131, 19);
            this.txtFileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ファイルダウンロード先";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URLファイル名";
            // 
            // txtFileDownloadDir
            // 
            this.txtFileDownloadDir.Location = new System.Drawing.Point(18, 92);
            this.txtFileDownloadDir.Name = "txtFileDownloadDir";
            this.txtFileDownloadDir.ReadOnly = true;
            this.txtFileDownloadDir.Size = new System.Drawing.Size(388, 19);
            this.txtFileDownloadDir.TabIndex = 2;
            // 
            // txtUrlPath
            // 
            this.txtUrlPath.Location = new System.Drawing.Point(18, 39);
            this.txtUrlPath.Name = "txtUrlPath";
            this.txtUrlPath.Size = new System.Drawing.Size(423, 19);
            this.txtUrlPath.TabIndex = 1;
            this.txtUrlPath.Text = "http://www.post.japanpost.jp/zipcode/dl/oogaki/zip/ken_all.zip";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtZipFileSelect);
            this.groupBox2.Controls.Add(this.btnZipExtract);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtExtractPath);
            this.groupBox2.Controls.Add(this.txtExtractZipFileName);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ファイル解凍";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(192, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "↓";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(242, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "↓";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(216, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "↓";
            // 
            // txtZipFileSelect
            // 
            this.txtZipFileSelect.Location = new System.Drawing.Point(412, 33);
            this.txtZipFileSelect.Name = "txtZipFileSelect";
            this.txtZipFileSelect.Size = new System.Drawing.Size(29, 23);
            this.txtZipFileSelect.TabIndex = 4;
            this.txtZipFileSelect.Text = "...";
            this.txtZipFileSelect.UseVisualStyleBackColor = true;
            this.txtZipFileSelect.Click += new System.EventHandler(this.txtZipFileSelect_Click);
            // 
            // btnZipExtract
            // 
            this.btnZipExtract.Location = new System.Drawing.Point(178, 79);
            this.btnZipExtract.Name = "btnZipExtract";
            this.btnZipExtract.Size = new System.Drawing.Size(103, 35);
            this.btnZipExtract.TabIndex = 5;
            this.btnZipExtract.Text = "解凍";
            this.btnZipExtract.UseVisualStyleBackColor = true;
            this.btnZipExtract.Click += new System.EventHandler(this.btnZipExtract_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "解凍ファイル選択";
            // 
            // txtExtractPath
            // 
            this.txtExtractPath.Location = new System.Drawing.Point(18, 120);
            this.txtExtractPath.Name = "txtExtractPath";
            this.txtExtractPath.ReadOnly = true;
            this.txtExtractPath.Size = new System.Drawing.Size(388, 19);
            this.txtExtractPath.TabIndex = 2;
            // 
            // txtExtractZipFileName
            // 
            this.txtExtractZipFileName.Location = new System.Drawing.Point(18, 35);
            this.txtExtractZipFileName.Name = "txtExtractZipFileName";
            this.txtExtractZipFileName.ReadOnly = true;
            this.txtExtractZipFileName.Size = new System.Drawing.Size(388, 19);
            this.txtExtractZipFileName.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDataImport);
            this.groupBox4.Controls.Add(this.dgCsvList);
            this.groupBox4.Controls.Add(this.txtCsvFilePath);
            this.groupBox4.Controls.Add(this.btnCSVFileSelect);
            this.groupBox4.Controls.Add(this.btnImports);
            this.groupBox4.Location = new System.Drawing.Point(12, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 329);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CSVデータの取り込み";
            // 
            // btnDataImport
            // 
            this.btnDataImport.Location = new System.Drawing.Point(306, 293);
            this.btnDataImport.Name = "btnDataImport";
            this.btnDataImport.Size = new System.Drawing.Size(100, 30);
            this.btnDataImport.TabIndex = 6;
            this.btnDataImport.Text = "保存";
            this.btnDataImport.UseVisualStyleBackColor = true;
            this.btnDataImport.Click += new System.EventHandler(this.btnDataImport_Click);
            // 
            // dgCsvList
            // 
            this.dgCsvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCsvList.Location = new System.Drawing.Point(18, 45);
            this.dgCsvList.Name = "dgCsvList";
            this.dgCsvList.RowTemplate.Height = 21;
            this.dgCsvList.Size = new System.Drawing.Size(634, 243);
            this.dgCsvList.TabIndex = 0;
            // 
            // txtCsvFilePath
            // 
            this.txtCsvFilePath.Location = new System.Drawing.Point(18, 18);
            this.txtCsvFilePath.Name = "txtCsvFilePath";
            this.txtCsvFilePath.ReadOnly = true;
            this.txtCsvFilePath.Size = new System.Drawing.Size(388, 19);
            this.txtCsvFilePath.TabIndex = 2;
            // 
            // btnCSVFileSelect
            // 
            this.btnCSVFileSelect.Location = new System.Drawing.Point(412, 16);
            this.btnCSVFileSelect.Name = "btnCSVFileSelect";
            this.btnCSVFileSelect.Size = new System.Drawing.Size(29, 23);
            this.btnCSVFileSelect.TabIndex = 4;
            this.btnCSVFileSelect.Text = "...";
            this.btnCSVFileSelect.UseVisualStyleBackColor = true;
            this.btnCSVFileSelect.Click += new System.EventHandler(this.txtCSVSelect_Click);
            // 
            // btnImports
            // 
            this.btnImports.Location = new System.Drawing.Point(447, 18);
            this.btnImports.Name = "btnImports";
            this.btnImports.Size = new System.Drawing.Size(103, 21);
            this.btnImports.TabIndex = 5;
            this.btnImports.Text = "取り込み";
            this.btnImports.UseVisualStyleBackColor = true;
            this.btnImports.Click += new System.EventHandler(this.btnImports_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(569, 713);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmZipAddressImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 742);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZipAddressImporter";
            this.Text = "郵便番号 登録";
            this.Load += new System.EventHandler(this.frmZipAddressImporter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCsvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDirSelect;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileDownloadDir;
        private System.Windows.Forms.TextBox txtUrlPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txtZipFileSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExtractZipFileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnZipExtract;
        private System.Windows.Forms.TextBox txtExtractPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgCsvList;
        private System.Windows.Forms.TextBox txtCsvFilePath;
        private System.Windows.Forms.Button btnCSVFileSelect;
        private System.Windows.Forms.Button btnImports;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDataImport;
    }
}

