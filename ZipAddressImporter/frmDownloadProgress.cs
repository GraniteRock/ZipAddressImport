using System;
using System.IO;
using System.Windows.Forms;

namespace ZipAddressImporter
{
    /// <summary>
    /// ファイルダウンロードクラス
    /// </summary>
    public partial class frmDownloadProgress : Form
    {
        /// <summary>
        /// ファイルパス
        /// </summary>
        private string FilePath = null;

        /// <summary>
        /// ファイルダウンロード元
        /// </summary>
        private string Url = null;

        /// <summary>
        /// デバッグモードフラグ
        /// </summary>
        private bool debug_mode = false;

        /// <summary>
        /// 機能名
        /// </summary>
        private string Function_Uame = string.Empty;

        /// <summary>
        /// ダウンロードフラグ
        /// </summary>
        private bool FileDownloadFlg = false;
        
        //WebClientフィールド
        System.Net.WebClient DownloadClient = null;

        /// <summary>
        /// 変数の初期化
        /// </summary>
        private void InitializeVariables() {
            this.FilePath = string.Empty;

            this.Url = string.Empty;

            this.Function_Uame = ConstantClass.CONSTANT_DOWNLOAD_PROGRESS_FORMNAME;
        }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private frmDownloadProgress() {
            InitializeComponent();

            InitializeVariables();
        }

        /// <summary>
        /// コンストラクタ（引数付き）
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="url"></param>
        public frmDownloadProgress(string filename, string url) {
            InitializeComponent();

            InitializeVariables();

            this.FilePath = filename;
            this.Url = url;
        }

        /// <summary>
        /// 画面ロード時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDownloadProgress_Load(object sender, EventArgs e) {
            //ダウンロード基のURL
            Uri u = new Uri(Url);

            try {

                //WebClientの作成
                if (this.DownloadClient == null){
                    this.DownloadClient = new System.Net.WebClient();
                    //イベントハンドラの作成
                    this.DownloadClient.DownloadProgressChanged +=
                        new System.Net.DownloadProgressChangedEventHandler(
                            downloadClient_DownloadProgressChanged);
                    this.DownloadClient.DownloadFileCompleted +=
                        new System.ComponentModel.AsyncCompletedEventHandler(
                            downloadClient_DownloadFileCompleted);
                }

                btnClose.Enabled = false;
                btnCancel.Enabled = true ;

                //非同期ダウンロードを開始する
                this.DownloadClient.DownloadFileAsync(u, FilePath);
            }
            catch (Exception ex) {
                throw ex;
            }


        }

        /// <summary>
        /// 非同期でダウンロードの進捗が変わった場合のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadClient_DownloadProgressChanged(object sender,
            System.Net.DownloadProgressChangedEventArgs e) {

            string caption = string.Format(ConstantClass.FORMAT_DOWNLOAD_PROGRESS_INFO
                , getFileName()
                , e.ProgressPercentage
                , e.TotalBytesToReceive
                , e.BytesReceived);

            this.display_Label(caption);
            progressDownload.Value = e.ProgressPercentage;

        }

        /// <summary>
        /// ダウンロード完了イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadClient_DownloadFileCompleted(object sender,
            System.ComponentModel.AsyncCompletedEventArgs e) {
            if (e.Cancelled){

                this.display_Label(ConstantClass.MSG_DOWNLOAD_PROGRESS_MSG_CANCEL);
            }
            else if (e.Error != null){

                this.display_Label(string.Format(ConstantClass.FORMAT_DOWNLOAD_PROGRESS_MSG_ERR, e.Error.Message));
            }
            else {
                this.display_Label(ConstantClass.MSG_DOWNLOAD_PROGRESS_MSG_COMPLETE);
                this.FileDownloadFlg = true ;
            }

            btnClose.Enabled = true;
            btnCancel.Enabled = false;
        }

        /// <summary>
        /// ファイル名取得
        /// </summary>
        /// <returns></returns>
        private string getFileName() {

            string fileName = "";

            try
            {
                fileName = Path.GetFileName(FilePath);
            }
            catch (Exception ex) {
                throw ex;
            }

            return fileName;
        }

        /// <summary>
        /// 閉じるボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// キャンセルボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            //非同期ダウンロードをキャンセルする
            if (this.DownloadClient != null) this.DownloadClient.CancelAsync();
        }

        /// <summary>
        /// ラベルの表示
        /// </summary>
        /// <param name="caption"></param>
        private void display_Label(string caption ) {
            this.lblDownloadInfo.Text = caption;

            // デバッグモードの場合
            if (debug_mode) { Console.WriteLine(caption); }
        }

        /// <summary>
        /// フォームを閉じる場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDownloadProgress_FormClosed(object sender, FormClosedEventArgs e) {

            // 処理完了の場合
            if (this.FileDownloadFlg) {

                if (this.Owner != null) {
                    frmZipAddressImporter frm =  (frmZipAddressImporter)this.Owner;

                    frm.SetExtractZipFileName(FilePath);
                }

            }
        }
    }
}
