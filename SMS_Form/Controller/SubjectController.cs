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
    internal class SubjectController
    {
        public string AddSubject(Model.Subject subject)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string addSubjectQuery = "INSERT INTO Subjects(Name, CourseId) VALUES(@name, @courseid)";

                SQLiteCommand insertSubjectCommand = new SQLiteCommand(addSubjectQuery, getdbconn);

                insertSubjectCommand.Parameters.AddWithValue("@name", subject.Name);
                insertSubjectCommand.Parameters.AddWithValue("@courseid", subject.CourseId);

                insertSubjectCommand.ExecuteNonQuery();
                return "Subject Added Successfully";
            }
        }


        public List<Model.Subject> GetAllSubjects()
        {
            List<Model.Subject> subjects = new List<Model.Subject>();
            string getSubjectQuery = @"
        SELECT s.Id, s.Name, s.CourseId, c.Name AS CourseName
        FROM Subjects s
        LEFT JOIN Courses c ON s.CourseId = c.Id";

            using (var conn = DbConfig.GetConnection())
            {
                SQLiteCommand getSubjectsCommand = new SQLiteCommand(getSubjectQuery, conn);
                var reader = getSubjectsCommand.ExecuteReader();

                while (reader.Read())
                {
                    Model.Subject subject = new Model.Subject();
                    subject.Id = reader.GetInt32(0);
                    subject.Name = reader.GetString(1);
                    subject.CourseId = reader.GetInt32(2);
                    subject.CourseName = reader.GetString(3);

                    subjects.Add(subject);
                }
            }

            return subjects;
        }

        public Subject GetSubjectById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Subject subject = new Subject();
                        subject.Id = reader.GetInt32(0);
                        subject.Name = reader.GetString(1);
                        subject.CourseId = reader.GetInt32(2);
                        return subject;
                    }
                }
            }

            return null;
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Subjects SET Name = @Name, CourseId = @CourseId WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Name", subject.Name);
                command.Parameters.AddWithValue("@CourseId", subject.CourseId);
                command.Parameters.AddWithValue("@Id", subject.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Subjects WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", subjectId);
                command.ExecuteNonQuery();
            }
        }
    }
}
