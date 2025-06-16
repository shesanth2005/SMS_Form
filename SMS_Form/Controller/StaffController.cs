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
                var cmd = new System.Data.SQLite.SQLiteCommand("INSERT INTO Staffs (Name,StaffRole,UserId) VALUES (@Name,@StaffRole,@UserId)" , conn);
                cmd.Parameters.AddWithValue("@Name", staff.Name);
                cmd.Parameters.AddWithValue("@StaffRole", staff.StaffRole); // Assuming StaffRole is a property of Staff
                cmd.Parameters.AddWithValue("@UserId", staff.UserId);
                cmd.ExecuteNonQuery();
                return "Staff Added Successfully";
            }

        }

        public string DeleteStaff(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("DELETE FROM Staffs WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                return "Staff Deleted Successfully";
            }
        }

        public Staff GetStaffbyid(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new System.Data.SQLite.SQLiteCommand("SELECT * FROM Staffs WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Staff staff = new Staff
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        StaffRole = reader.GetString(2), // Assuming StaffRole is the same as Name for this example
                        UserId = reader.GetInt32(3)
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
                var cmd = new System.Data.SQLite.SQLiteCommand("SELECT * FROM Staffs", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Staff staff = new Staff
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        StaffRole = reader.GetString(2), // Assuming StaffRole is the same as Name for this example
                        UserId = reader.GetInt32(3)
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
                var cmd = new System.Data.SQLite.SQLiteCommand("UPDATE Staffs SET Name = @Name,StaffRole=@StaffRole,UserId=@UserId WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Name", staff.Name);
                
                cmd.Parameters.AddWithValue("@Id", staff.Id);
                cmd.Parameters.AddWithValue("@UserId", staff.UserId);
                cmd.Parameters.AddWithValue("@StaffRole", staff.StaffRole); // Assuming StaffRole is a property of Staff
                cmd.ExecuteNonQuery();
                return "Staff Updated Successfully";
            }
        }
    }
}
