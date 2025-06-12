using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Data
{
    internal static class DbConfig
    {
        private static string connectionString = "Data Source=SchoolDB.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;

        }

    }
}
