using SMS_Form.Data;
using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class LecturerController
    {

        public string AddLecturer(Lecturer lecturer)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string insertQuery = @"INSERT INTO Lecturers (Name, Address, Telephone, UserId)
                                       VALUES (@Name, @Address, @Telephone, @UserId)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@Address", lecturer.Address);
                    cmd.Parameters.AddWithValue("@Telephone", lecturer.Telephone);
                    cmd.Parameters.AddWithValue("@UserId", lecturer.UserId);
                    cmd.ExecuteNonQuery();
                }

                return "Lecturer Added Successfully";
            }
        }

        public List<Lecturer> GetAllLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            string selectQuery = @"
                SELECT Id, Name, Address, Telephone, UserId
                FROM Lecturers";

            using (var conn = DbConfig.GetConnection())
            using (var cmd = new SQLiteCommand(selectQuery, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Lecturer lecturer = new Lecturer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Telephone = reader.GetString(3),
                        UserId = reader.GetInt32(4)
                    };
                    lecturers.Add(lecturer);
                }
            }

            return lecturers;
        }

        public Lecturer GetLecturerById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Id, Name, Address, Telephone, UserId FROM Lecturers WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Lecturer
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Telephone = reader.GetString(3),
                            UserId = reader.GetInt32(4)
                        };
                    }
                }
            }

            return null;
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string updateQuery = @"UPDATE Lecturers
                                       SET Name = @Name,
                                           Address = @Address,
                                           Telephone = @Telephone,
                                           UserId = @UserId
                                       WHERE Id = @Id";

                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", lecturer.Name);
                    cmd.Parameters.AddWithValue("@Address", lecturer.Address);
                    cmd.Parameters.AddWithValue("@Telephone", lecturer.Telephone);
                    cmd.Parameters.AddWithValue("@UserId", lecturer.UserId);
                    cmd.Parameters.AddWithValue("@Id", lecturer.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteLecturer(int lecturerId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Lecturers WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        public bool CheckUserId(int userId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("SELECT COUNT(*) FROM Lecturers WHERE UserId = @UserId", conn);
                command.Parameters.AddWithValue("@UserId", userId);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public Lecturer GetLecturersByUserId(int userId)
        {
         
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Lecturers WHERE UserId = @UserId", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Lecturer lecturer = new Lecturer
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Telephone = reader.GetString(3),
                            UserId = reader.GetInt32(4)
                        };
                        return lecturer;
                    }
                }
            }
            return null; // Return null if no lecturer found with the given userId

        }
    }
}

