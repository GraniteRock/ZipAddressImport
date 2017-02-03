using System;
using System.IO;
using System.IO.Compression;
namespace ZipAddressImporter
{
    /// <summary>
    /// ZIP解凍クラス
    /// </summary>
    class ZipExtract
    {
        /// <summary>
        /// 展開パス
        /// </summary>
        public string ExtractPath { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ZipExtract()
        {

        }

        /// <summary>
        /// ZIPの解凍
        /// </summary>
        /// <param name="zipPath"></param>
        /// <returns></returns>
        public bool Unzip(string zipPath )
        {
            bool result = false;
            try
            {

                //ファイル名（拡張子抜き）
                ExtractPath = System.IO.Path.GetDirectoryName(zipPath) + @"\" +
                    System.IO.Path.GetFileNameWithoutExtension(zipPath);

                var directoryInfo = Directory.CreateDirectory(ExtractPath);

                // ZIPファイルを開いてZipArchiveオブジェクトを作る
                using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                {
                    // 選択したファイルを指定したフォルダーに書き出す
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        // ZipArchiveEntryオブジェクトのExtractToFileメソッドにフルパスを渡す
                        entry.ExtractToFile(Path.Combine(ExtractPath, entry.FullName));
                        Console.WriteLine("展開: {0}", entry.FullName);
                    }
                }

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
