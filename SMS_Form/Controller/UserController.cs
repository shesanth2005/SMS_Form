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

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (var conn = DbConfig.GetConnection())
            {
                string query = "SELECT UserId, UserName, Password, Role FROM Users";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

        public User GetuserbyID(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string query = "SELECT UserId, UserName, Password, Role FROM Users WHERE UserId = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                        }

                    }
                }
            }
            return null; // Return null if no user found with the given ID

        }

       

        public string UpdateUser(User user)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string updateQuery = "UPDATE Users SET UserName = @UserName, Password = @Password, Role = @Role WHERE UserId = @UserId";
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", user.Id);
                    cmd.Parameters.AddWithValue("@UserName", user.Name);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.ExecuteNonQuery();
                }
            }
            return "User Updated Successfully";
        }

        public List<User> GetAdmins()
        {
            var admins = new List<User>();
            using (var conn = DbConfig.GetConnection())
            {
                string query = "SELECT UserId, UserName, Password, Role FROM Users WHERE Role = @Role";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Role", "Admin");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            admins.Add(new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            });
                        }
                    }
                }
            }
            return admins;
        }

    }
}
