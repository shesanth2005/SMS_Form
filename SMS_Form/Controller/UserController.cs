using SMS_Form.Data;
using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class UserController
    {
        public int Adduser(User user)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string Adduser = "INSERT INTO Users(UserName,Password,Role)VALUES(@username,@password,@role)";

                SQLiteCommand insertusercommand = new SQLiteCommand(Adduser, getdbconn);
                insertusercommand.Parameters.AddWithValue("@username", user.Name);
                insertusercommand.Parameters.AddWithValue("@password", user.Password);
                insertusercommand.Parameters.AddWithValue("@role", user.Role);
                insertusercommand.ExecuteNonQuery();

                int newUserId = (int)getdbconn.LastInsertRowId;
                return newUserId;

            }
        }

        public void DeleteUser(int userId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                

                using (var command = new SQLiteCommand("DELETE FROM Users WHERE UserId = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.ExecuteNonQuery();
                }
            }
        }


        public bool IsUsernameAvailable(string username)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand(
                    "SELECT Username FROM Users WHERE Username = @Username",
                    conn);

                command.Parameters.AddWithValue("@Username", username);

                // Explicitly typed as string
                string result = command.ExecuteScalar() as string;

                // If result is null, username doesn't exist
                return result == null;
            }
        }
    }
}
