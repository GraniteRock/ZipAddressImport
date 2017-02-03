using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ZipAddressImporter
{
    /// <summary>
    /// 郵便番号インポート画面
    /// </summary>
    public partial class frmZipAddressImporter : Form
    {

        /// <summary>
        /// 画面名
        /// </summary>
        protected string Function_Name = "";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmZipAddressImporter() {
            InitializeComponent();

            InitializeVariables();
        }

        /// <summary>
        /// フォルダ選択ダイアログ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDirSelect_Click(object sender, EventArgs e) {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog folderDir = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            folderDir.Description = ConstantClass.MSG_COMMON_ALERT_FOLDER_UNCHIOCE; 
            //ルートフォルダを指定する デフォルトでDesktop
            folderDir.RootFolder = Environment.SpecialFolder.Desktop;

            // ディレクトリが指定済みの場合
            if (!string.IsNullOrEmpty(txtFileDownloadDir.Text )) {
                folderDir.SelectedPath = txtFileDownloadDir.Text ;
            }
            else {
                folderDir.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            folderDir.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (folderDir.ShowDialog(this) == DialogResult.OK) {
                //選択されたフォルダを表示する
                txtFileDownloadDir.Text = folderDir.SelectedPath;
            }
        }

        /// <summary>
        /// Clickイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e) {
            if (!isDownloadValidation()) return;

            string folderName = txtFileDownloadDir.Text;

            //ダウンロードしたファイルの保存先
            string filePath = folderName + "\\" + txtFileName.Text;

            frmDownloadProgress form = new frmDownloadProgress(filePath, txtUrlPath.Text );
            form.Owner = this;
            form.Show();
            form.Activate();
        }

        /// <summary>
        /// 検証関数
        /// </summary>
        /// <returns></returns>
        private bool isDownloadValidation() {
            bool result = true;
            StringBuilder message = new StringBuilder();

            if (string.IsNullOrEmpty(txtUrlPath.Text)) message.AppendLine(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_URL_NOTFOUND);
            if (string.IsNullOrEmpty(txtFileDownloadDir.Text)) message.AppendLine(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_DIR_UNCHOICE);
            if (string.IsNullOrEmpty(txtFileName.Text)) message.AppendLine(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_FILE_NAME_NOT_SETTING);
            if (!string.IsNullOrEmpty(message.ToString())) {
                result = false; 
                MessageBox.Show(message.ToString(), this.Function_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;

        }
        /// <summary>
        /// 解凍するファイル選択ダイアログ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtZipFileSelect_Click(object sender, EventArgs e) {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.zip";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "Zipファイル(*.zip;*.ZIP)|*.zip;*.ZIP";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = ConstantClass.MSG_COMMON_ALERT_FILE_UNCHIOCE;
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK) {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);

                txtExtractZipFileName.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// 変数の初期化
        /// </summary>
        private void InitializeVariables() {
            txtFileDownloadDir.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.Function_Name = ConstantClass.CONSTANT_ZIPADDR_IMPORT_FORMNAME;
        }

        /// <summary>
        /// ZIPの解凍処理ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZipExtract_Click(object sender, EventArgs e) {
            if (!isZipExtractValidation()) { return ; }

            try
            {
                ZipExtract zipclass = new ZipExtract();

                if (zipclass.Unzip(txtExtractZipFileName.Text)) {
                    txtExtractPath.Text = zipclass.ExtractPath;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString(),Function_Name,MessageBoxButtons.OK,MessageBoxIcon.Warning );
            }
        

        }

        /// <summary>
        /// 検証関数
        /// </summary>
        /// <returns></returns>
        private bool isZipExtractValidation() {
            bool result = true;

            if (string.IsNullOrEmpty(txtExtractZipFileName.Text)) {
                result = false;
                MessageBox.Show(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_ZIPFILE_UNCHIOCE, this.Function_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return result;
        }

        /// <summary>
        /// メインの閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainClose(object sender, EventArgs e) {
            if (
                MessageBox.Show(
                    ConstantClass.MSG_COMMON_ALERT_CLOSE_DIALOG, 
                    this.Function_Name, 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question
               ) == System.Windows.Forms.DialogResult.OK) {
                this.Close();

            }
        }

        /// <summary>
        /// ファイル選択画面表示ボタンクリッククラス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCSVSelect_Click(object sender, EventArgs e) {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "ken_all.csv";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "CSVファイル(*.csv;*.CSV)|*.csv;*.CSV";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = ConstantClass.MSG_COMMON_ALERT_FILE_UNCHIOCE;
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK) {
                txtCsvFilePath.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// CSV取り込みボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImports_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtCsvFilePath.Text))
                MessageBox.Show(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_FILE_UNCHIOCE, this.Function_Name + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!File.Exists(txtCsvFilePath.Text))
                MessageBox.Show(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_FILE_NOTFOUND, this.Function_Name + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //CSVファイルの名前
            string csvFileName = txtCsvFilePath.Text;
            
            //接続文字列
            string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                + System.IO.Path.GetDirectoryName(csvFileName) + ";Extended Properties=\"text;HDR=No;FMT=Delimited\"";
            System.Data.OleDb.OleDbConnection con =
                new System.Data.OleDb.OleDbConnection(conString);

            string commText = "SELECT * FROM [" + System.IO.Path.GetFileName(csvFileName) + "]";
            System.Data.OleDb.OleDbDataAdapter da =
                new System.Data.OleDb.OleDbDataAdapter(commText, con);

            //DataTableに格納する
            DataTable dt = new DataTable();
            da.Fill(dt);


            // 行がある場合
            if (dt.Rows.Count > 0) {

                InitializeGridView(dt);
            }
            else {
                MessageBox.Show(ConstantClass.MSG_ZIPADDR_IMPORT_ALERT_FILE_EMPTY, this.Function_Name + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
        /// <summary>
        /// データグリッドの初期化
        /// </summary>
        /// <param name="dt"></param>
        private void InitializeGridView(DataTable dt) {
            dgCsvList.DataSource = dt;
            dgCsvList.ReadOnly = true;
            dgCsvList.AllowUserToAddRows = false;
            //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
            dgCsvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
            dgCsvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e) {
            //OKボタンがクリックされた場合
            if (DialogResult.OK == 
                MessageBox.Show(
                    ConstantClass.MSG_COMMON_ALERT_CLOSE_DIALOG, 
                    this.Function_Name, 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Information)
                ) {
                this.Close();
            }
        }

        /// <summary>
        /// データ取り込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataImport_Click(object sender, EventArgs e) {
            try {
                // データがある場合
                if (dgCsvList.Rows.Count > 0) {
                    DataTable dt = (DataTable)dgCsvList.DataSource;


                    DbAccess da = new DbAccess();

                    da.insert(dt);

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString(), Function_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /// <summary>
        /// 画面ロード時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmZipAddressImporter_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// ダウンロードファイルパスの設定
        /// </summary>
        /// <param name="pathName"></param>
        public void SetExtractZipFileName(string pathName) {
            txtExtractZipFileName.Text = pathName;
        }
    }    
}
