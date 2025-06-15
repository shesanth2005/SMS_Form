using SMS_Form.Data;
using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class StaffController
    {
        public string AddStaff(Staff staff)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("INSERT INTO Staff (Name) VALUES (@Name)", conn);
                cmd.Parameters.AddWithValue("@Name", staff.Name);
               
                cmd.ExecuteNonQuery();
                return "Staff Added Successfully";
            }

        }

        public string DeleteStaff(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("DELETE FROM Staff WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                return "Staff Deleted Successfully";
            }
        }

        public Staff GetStaffbyid(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("SELECT * FROM Staff WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Staff staff = new Staff
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        UserId = reader.GetInt32(2)
                    };
                    return staff;
                }


            }
            return null; // Return null if no staff found with the given id
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("SELECT * FROM Staff", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Staff staff = new Staff
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        UserId = reader.GetInt32(2)
                    };
                    staffList.Add(staff);
                }
            }
            return staffList;
        }

        public string UpdateStaff(Staff staff)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("UPDATE Staff SET Name = @Name WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Name", staff.Name);
             
                cmd.Parameters.AddWithValue("@Id", staff.Id);
                cmd.ExecuteNonQuery();
                return "Staff Updated Successfully";
            }
        }
    }
}
