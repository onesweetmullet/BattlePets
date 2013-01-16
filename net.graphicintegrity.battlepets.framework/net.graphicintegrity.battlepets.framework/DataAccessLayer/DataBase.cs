using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.OleDb;
using System.Data;

namespace net.graphicintegrity.battlepets.framework.DataAccessLayer
{
    public class DataBase
    {

        public static List<List<string>> GetResults(string query, string databasePath)
        {
            List<List<string>> _listResults = new List<List<string>>();
            DataTable _dt = new DataTable();
            string _cs = @"URI=file:" + databasePath + "";
            using (SQLiteConnection _con = new SQLiteConnection(_cs))
            {
                _con.Open();

                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    using (SQLiteDataReader _dr = _cmd.ExecuteReader())
                    {
                        _dt.Load(_dr);
                        while (_dr.Read())
                        {
                            List<string> _listFields = new List<string>();
                            for (int i = 0; i < _dr.FieldCount; i++)
                            {
                                _listFields.Add(_dr.GetValue(i).ToString());
                            }

                            _listResults.Add(_listFields);
                        }
                    }
                }

                _con.Close();
            }



            return _listResults;
        }

        public static string GetResult(string query, string databasePath)
        {
            string _returnVal = "";

            string _cs = @"URI=file:" + databasePath + "";
            using (SQLiteConnection _con = new SQLiteConnection(_cs))
            {
                _con.Open();

                using (SQLiteCommand _cmd = new SQLiteCommand(query, _con))
                {
                    using (SQLiteDataReader _dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            _returnVal = _dr.GetValue(0).ToString();
                        }
                    }
                }

                _con.Close();
            }

            return _returnVal;
        }
    }
}
