
namespace ZipAddressImporter
{
    /// <summary>
    /// 定数・定型文字列クラス
    /// </summary>
    static class ConstantClass
    {

        public const string CONSTANT_DB_NAME = @"mtb_zip_new";

        public const string CONSTANT_DB_CONNECTION_STRING = @"Server=localhost;"
            + "database=dbName;"
            + "Uid=Uid;"
            + "Pwd=password;";

        public const string CONSTANT_DOWNLOAD_PROGRESS_FORMNAME = @"ファイルダウンロード";
        public const string CONSTANT_ZIPADDR_IMPORT_FORMNAME = @"郵政CSV設定画面";

        public const string FORMAT_DOWNLOAD_PROGRESS_INFO = @"ファイル[{0}]をダウンロードしています。{1}%完了中 ({2:#,0}byte 中 {3:#,0}byte) ...";
        public const string FORMAT_DOWNLOAD_PROGRESS_MSG_ERR = @"エラー:{0}";

        public const string MSG_DOWNLOAD_PROGRESS_MSG_CANCEL = @"キャンセルされました。";
        public const string MSG_DOWNLOAD_PROGRESS_MSG_COMPLETE = @"ダウンロードが完了しました。";

        public const string MSG_COMMON_ALERT_FOLDER_UNCHIOCE = @"フォルダを指定してください。";
        public const string MSG_COMMON_ALERT_FILE_UNCHIOCE = @"開くファイルを選択してください。";
        public const string MSG_COMMON_ALERT_CLOSE_DIALOG = @"ダイアログを終了します。よろしいですか？";

        public const string MSG_ZIPADDR_IMPORT_ALERT_FILE_UNCHIOCE = @"ファイルが指定されていません。";
        public const string MSG_ZIPADDR_IMPORT_ALERT_FILE_NOTFOUND = @"ファイルが存在しません。";
        public const string MSG_ZIPADDR_IMPORT_ALERT_ZIPFILE_UNCHIOCE = @"ZIPファイルが指定されていません。";
        public const string MSG_ZIPADDR_IMPORT_ALERT_FILE_EMPTY = @"ファイルの中身がありません。";

        public const string MSG_ZIPADDR_IMPORT_ALERT_URL_NOTFOUND = @"ダウンロード元URLの指定がありません。";
        public const string MSG_ZIPADDR_IMPORT_ALERT_DIR_UNCHOICE = @"ダウンロードするディレクトリの指定がありません。";
        public const string MSG_ZIPADDR_IMPORT_ALERT_FILE_NAME_NOT_SETTING = @"ダウンロードファイル名の指定がありません。";

    }
}
