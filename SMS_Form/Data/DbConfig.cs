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
        private static string connectionString = "Data Source=unicomtic.db;Version=3;Pooling=True;Max Pool Size=100;BusyTimeout=5000;";


        //public static SQLiteConnection GetConnection()
        //{
        //    SQLiteConnection conn = new SQLiteConnection(connectionString);
        //    conn.Open();
        //    return conn;

        //}

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }

            return conn;
        }

    }
}
