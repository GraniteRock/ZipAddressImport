using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ZipAddressImporter
{
    /// <summary>
    /// DB接続クラス
    /// </summary>
    class DbAccess
    {

        /// <summary>
        /// データの登録
        /// </summary>
        /// <param name="dt"></param>
        public void insert(DataTable dtview)
        {

            try {
                using (MySqlConnection conn = new MySqlConnection()) {
                    conn.ConnectionString = ConstantClass.CONSTANT_DB_CONNECTION_STRING;

                    conn.Open();

                    using (MySqlDataAdapter da = new MySqlDataAdapter()) {

                        string selectStr = "SELECT * FROM " + ConstantClass.CONSTANT_DB_NAME;

                        // select用コマンド・オブジェクトの作成
                        MySqlCommand selCmd = new MySqlCommand();
                        selCmd.Connection = conn;
                        selCmd.CommandText = selectStr;

                        da.SelectCommand = selCmd;

                        // データセットへの読み込み
                        DataSet ds = new DataSet();
                        da.Fill(ds, ConstantClass.CONSTANT_DB_NAME);

                        // insert用コマンド・オブジェクトの作成
                        string insertStr
                            = "INSERT INTO "
                            + ConstantClass.CONSTANT_DB_NAME
                            + "(code, old_zipcode, zipcode, state_kana, city_kana, town_kana, state, city, town, flg1, flg2, flg3, flg4, flg5, flg6)"
                            + " VALUES (@code, @old_zipcode, @zipcode, @state_kana, @city_kana, @town_kana, @state, @city, @town, @flg1, @flg2, @flg3, @flg4, @flg5, @flg6)";

                        DataTable dt = ds.Tables[ConstantClass.CONSTANT_DB_NAME];

                        MySqlCommand insCmd = new MySqlCommand();
                        insCmd.Connection = conn;
                        insCmd.CommandText = insertStr;

                        insCmd.Parameters.Add(AddMySqlParameter("code", MySqlDbType.VarChar, 5));
                        insCmd.Parameters.Add(AddMySqlParameter("old_zipcode", MySqlDbType.VarChar, 5));
                        insCmd.Parameters.Add(AddMySqlParameter("zipcode", MySqlDbType.VarChar, 7));
                        insCmd.Parameters.Add(AddMySqlParameter("state_kana", MySqlDbType.VarChar, 24));
                        insCmd.Parameters.Add(AddMySqlParameter("city_kana", MySqlDbType.VarChar, 128));
                        insCmd.Parameters.Add(AddMySqlParameter("city", MySqlDbType.VarChar, 128));
                        insCmd.Parameters.Add(AddMySqlParameter("town_kana", MySqlDbType.VarChar, 128));
                        insCmd.Parameters.Add(AddMySqlParameter("state", MySqlDbType.VarChar, 10));
                        insCmd.Parameters.Add(AddMySqlParameter("town", MySqlDbType.VarChar, 128));
                        insCmd.Parameters.Add(AddMySqlParameter("flg1", MySqlDbType.Int32));
                        insCmd.Parameters.Add(AddMySqlParameter("flg2", MySqlDbType.Int32));
                        insCmd.Parameters.Add(AddMySqlParameter("flg3", MySqlDbType.Int32));
                        insCmd.Parameters.Add(AddMySqlParameter("flg4", MySqlDbType.Int32));
                        insCmd.Parameters.Add(AddMySqlParameter("flg5", MySqlDbType.Int32));
                        insCmd.Parameters.Add(AddMySqlParameter("flg6", MySqlDbType.Int32));

                        MySqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                        insCmd.Transaction = tran;
                        //id, code, old_zipcode, zipcode, state_kana, city_kana, town_kana, state, city, town, flg1, flg2, flg3, flg4, flg5, flg6
                        da.InsertCommand = insCmd;


                        foreach (DataRow dr in dtview.Rows) {
                            // 行の追加
                            DataRow newRow = dt.NewRow();
                            newRow["code"] = dr["F1"];
                            newRow["old_zipcode"] = dr["F2"];
                            newRow["zipcode"] = dr["F3"];
                            newRow["state_kana"] = dr["F4"];
                            newRow["city_kana"] = dr["F5"];
                            newRow["town_kana"] = dr["F6"];
                            newRow["state"] = dr["F7"];
                            newRow["city"] = dr["F8"];
                            newRow["town"] = dr["F9"];
                            newRow["flg1"] = dr["F10"];
                            newRow["flg2"] = dr["F11"];
                            newRow["flg3"] = dr["F12"];
                            newRow["flg4"] = dr["F13"];
                            newRow["flg5"] = dr["F14"];
                            newRow["flg6"] = dr["F15"];
                            dt.Rows.Add(newRow);
                        }

                        // データベースの更新
                        da.Update(ds, ConstantClass.CONSTANT_DB_NAME);

                        if (tran != null) {
                            tran.Commit();
                        }

                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
        /// <summary>
        /// MySQLのパラメータを返す
        /// </summary>
        /// <returns></returns>
        private MySqlParameter AddMySqlParameter(string palmName, MySqlDbType type, int size = 0)
        {
            MySqlParameter p = new MySqlParameter();

            try
            {
                p.ParameterName = "@" + palmName;
                p.SourceColumn = palmName;
                p.Direction = ParameterDirection.Input;

                switch (type){
                    case MySqlDbType.VarChar:
                    case MySqlDbType.VarString:
                    case MySqlDbType.Text:
                    case MySqlDbType.String:
                    case MySqlDbType.MediumText:
                    case MySqlDbType.LongText:
                        p.Size = size;
                        break;
                    default:
                        break;
                }

                p.MySqlDbType = type;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            return p;
        }

    }
}
