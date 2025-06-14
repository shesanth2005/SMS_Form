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
    internal class TimetableController
    {
        public string AddTimetable(Model.Timetable timetable)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string insertTimetable = @"INSERT INTO Timetable 
                                   (SubjectId, Day, StartTime,EndTime, RoomId) 
                                   VALUES (@subjectId, @day, @starttime,@endtime, @roomId)";

                using (var cmd = new SQLiteCommand(insertTimetable, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectId", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@day", timetable.Day);
                    cmd.Parameters.AddWithValue("@starttime", timetable.StartTime);
                    cmd.Parameters.AddWithValue("@endtime", timetable.EndTime);
                    cmd.Parameters.AddWithValue("@roomId", timetable.RoomId);

                    cmd.ExecuteNonQuery();
                }

                return "Timetable entry added successfully";
            }
        }
        public List<Model.Timetable> GetAllTimetables()
        {
            List<Model.Timetable> timetables = new List<Model.Timetable>();

            string query = @"
    SELECT t.Id, 
           t.SubjectId, 
           s.Name AS SubjectName,
           t.Day, 
           t.StartTime, 
           t.EndTime,
           t.RoomId, 
           r.RoomName AS RoomName
    FROM Timetable t
    LEFT JOIN Subjects s ON t.SubjectId = s.Id
    LEFT JOIN Rooms r ON t.RoomId = r.Id";

            using (var conn = DbConfig.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Model.Timetable timetable = new Model.Timetable();

                    timetable.Id = reader.GetInt32(0);
                    timetable.SubjectId = reader.GetInt32(1);
                    timetable.SubjectName = reader.GetString(2);
                    timetable.Day = reader.GetString(3);
                    timetable.StartTime = reader.GetString(4);
                    timetable.EndTime = reader.GetString(5);
                    timetable.RoomId = reader.GetInt32(6);
                    timetable.RoomName = reader.GetString(7);

                    timetables.Add(timetable);
                }
            }

            return timetables;
        }

        public Timetable GetTimetableById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Timetable WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Timetable timetable = new Timetable();
                        timetable.Id = reader.GetInt32(0);
                        timetable.SubjectId = reader.GetInt32(1);
                        timetable.Day = reader.GetString(2);
                        timetable.StartTime = reader.GetString(3);
                        timetable.EndTime = reader.GetString(4);
                        timetable.RoomId = reader.GetInt32(5);
                        return timetable;
                    }
                }
            }

            return null;
        }

        public void UpdateTimetable(Timetable timetable)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand(@"
            UPDATE Timetable 
            SET SubjectId = @SubjectId, 
                Day = @Day, 
                StartTime = @StartTime, 
                EndTime = @EndTime,
                RoomId = @RoomId 
            WHERE Id = @Id", conn);

                command.Parameters.AddWithValue("@SubjectId", timetable.SubjectId);
                command.Parameters.AddWithValue("@Day", timetable.Day);
                command.Parameters.AddWithValue("@StartTime", timetable.StartTime);
                command.Parameters.AddWithValue("@EndTime", timetable.EndTime);
                command.Parameters.AddWithValue("@RoomId", timetable.RoomId);
                command.Parameters.AddWithValue("@Id", timetable.Id);

                command.ExecuteNonQuery();
            }
        }
        public void DeleteTimetable(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Timetable WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }

        }
    }
}
