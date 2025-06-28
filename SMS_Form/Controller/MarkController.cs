using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class MarkController
    {
        public string AddMark(Model.Mark mark)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM Marks WHERE StudentId = @studentId AND ExamId = @examId";
                using (var checkCmd = new System.Data.SQLite.SQLiteCommand(checkQuery, getdbconn))
                {
                    checkCmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                    checkCmd.Parameters.AddWithValue("@examId", mark.ExamId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return "Marks for this student and exam already exist.";
                    }
                }


                string AddMarkQuery = "INSERT INTO Marks(StudentId, ExamId, Marks) VALUES(@studentid, @examid, @marks)";
                using (var insertMarkCommand = new System.Data.SQLite.SQLiteCommand(AddMarkQuery, getdbconn))
                {
                    insertMarkCommand.Parameters.AddWithValue("@studentid", mark.StudentId);
                    insertMarkCommand.Parameters.AddWithValue("@examid", mark.ExamId);
                    insertMarkCommand.Parameters.AddWithValue("@marks", mark.Marks);
                    insertMarkCommand.ExecuteNonQuery();
                }
                return "Marks Added Successfully";
            }
        }

        public string DeleteMark(int id)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string DeleteMarkQuery = "DELETE FROM Marks WHERE Id = @id";
                using (var deleteMarkCommand = new System.Data.SQLite.SQLiteCommand(DeleteMarkQuery, getdbconn))
                {
                    deleteMarkCommand.Parameters.AddWithValue("@id", id);
                    deleteMarkCommand.ExecuteNonQuery();
                }
                return "Marks Deleted Successfully";
            }
        }

        public string UpdateMark(int studentid,int examid,Model.Mark mark)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM Marks WHERE StudentId = @studentId AND ExamId = @examId AND Id!=@id";
                using (var checkCmd = new System.Data.SQLite.SQLiteCommand(checkQuery, getdbconn))
                {
                    checkCmd.Parameters.AddWithValue("@studentId", studentid);
                    checkCmd.Parameters.AddWithValue("@examId", examid);
                    checkCmd.Parameters.AddWithValue("@id", mark.Id);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return "Marks for this student and exam already exist.";
                    }
                }


                string UpdateMarkQuery = "UPDATE Marks SET StudentId = @studentid, ExamId = @examid, Marks = @marks WHERE Id = @id";
                using (var updateMarkCommand = new System.Data.SQLite.SQLiteCommand(UpdateMarkQuery, getdbconn))
                {
                    updateMarkCommand.Parameters.AddWithValue("@studentid", mark.StudentId);
                    updateMarkCommand.Parameters.AddWithValue("@examid", mark.ExamId);
                    updateMarkCommand.Parameters.AddWithValue("@marks", mark.Marks);
                    updateMarkCommand.Parameters.AddWithValue("@id", mark.Id);
                    updateMarkCommand.ExecuteNonQuery();
                }
                return "Marks Updated Successfully";
            }
        }

        public List<Model.Mark> GetAllMarks()
        {
            List<Model.Mark> marks = new List<Model.Mark>();
            string getMarksQuery = @"
                SELECT m.Id, m.StudentId, m.ExamId, m.Marks, s.Name AS StudentName, e.Name AS ExamName
                FROM Marks m
                LEFT JOIN Students s ON m.StudentId = s.Id
                LEFT JOIN Exams e ON m.ExamId = e.Id";
            using (var conn = Data.DbConfig.GetConnection())
            {
                using (var getMarksCommand = new System.Data.SQLite.SQLiteCommand(getMarksQuery, conn))
                {
                    var readers = getMarksCommand.ExecuteReader();
                    while (readers.Read())
                    {
                        Model.Mark mark = new Model.Mark();
                        mark.Id = readers.GetInt32(0);
                        mark.StudentId = readers.GetInt32(1);
                        mark.ExamId = readers.GetInt32(2);
                        mark.Marks = readers.GetInt32(3);
                        mark.StudentName = readers.GetString(4);
                        mark.ExamName = readers.GetString(5);
                        marks.Add(mark);
                    }
                }
            }
            return marks;
        }

        //public List<Model.Mark> GetMarksByStudentId(int studentId)
        //{
        //    List<Model.Mark> marks = new List<Model.Mark>();
        //    string getMarksQuery = @"
        //        SELECT m.Id, m.StudentId, m.ExamId, m.Marks, s.Name AS StudentName, e.Name AS ExamName
        //        FROM Marks m
        //        LEFT JOIN Students s ON m.StudentId = s.Id
        //        LEFT JOIN Exams e ON m.ExamId = e.Id
        //        WHERE m.StudentId = @studentid";
        //    using (var conn = Data.DbConfig.GetConnection())
        //    {
        //        using (var getMarksCommand = new System.Data.SQLite.SQLiteCommand(getMarksQuery, conn))
        //        {
        //            getMarksCommand.Parameters.AddWithValue("@studentid", studentId);
        //            var readers = getMarksCommand.ExecuteReader();
        //            while (readers.Read())
        //            {
        //                Model.Mark mark = new Model.Mark();
        //                mark.Id = readers.GetInt32(0);
        //                mark.StudentId = readers.GetInt32(1);
        //                mark.ExamId = readers.GetInt32(2);
        //                mark.Marks = readers.GetDouble(3);
        //                mark.StudentName = readers.GetString(4);
        //                mark.ExamName = readers.GetString(5);
        //                marks.Add(mark);
        //            }
        //        }
        //    }
        //    return marks;
        //}

        public Model.Mark GetMarkById(int id)
        {
            Model.Mark mark = null;
            string getMarkQuery = @"
                SELECT m.Id, m.StudentId, m.ExamId, m.Marks, s.Name AS StudentName, e.Name AS ExamName
                FROM Marks m
                LEFT JOIN Students s ON m.StudentId = s.Id
                LEFT JOIN Exams e ON m.ExamId = e.Id
                WHERE m.Id = @id";
            using (var conn = Data.DbConfig.GetConnection())
            {
                using (var getMarkCommand = new System.Data.SQLite.SQLiteCommand(getMarkQuery, conn))
                {
                    getMarkCommand.Parameters.AddWithValue("@id", id);
                    var reader = getMarkCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        mark = new Model.Mark();
                        mark.Id = reader.GetInt32(0);
                        mark.StudentId = reader.GetInt32(1);
                        mark.ExamId = reader.GetInt32(2);
                        mark.Marks = reader.GetInt32(3);
                        mark.StudentName = reader.GetString(4);
                        mark.ExamName = reader.GetString(5);
                    }
                }
            }
            return mark;
        }

        public List<Model.Mark> GetMarksByStudentid(int studentid)
        {
            List<Model.Mark> marks = new List<Model.Mark>();
            string getMarksQuery = @"
                SELECT m.Id, m.StudentId, m.ExamId, m.Marks, s.Name AS StudentName, e.Name AS ExamName
                FROM Marks m
                LEFT JOIN Students s ON m.StudentId = s.Id
                LEFT JOIN Exams e ON m.ExamId = e.Id
                WHERE m.StudentId = @studentid";
            using (var conn = Data.DbConfig.GetConnection())
            {
                using (var getMarksCommand = new System.Data.SQLite.SQLiteCommand(getMarksQuery, conn))
                {
                    getMarksCommand.Parameters.AddWithValue("@studentid", studentid);
                    var readers = getMarksCommand.ExecuteReader();
                    while (readers.Read())
                    {
                        Model.Mark mark = new Model.Mark();
                        mark.Id = readers.GetInt32(0);
                        mark.StudentId = readers.GetInt32(1);
                        mark.ExamId = readers.GetInt32(2);
                        mark.Marks = readers.GetInt32(3);
                        mark.StudentName = readers.GetString(4);
                        mark.ExamName = readers.GetString(5);
                        marks.Add(mark);
                    }
                }
            }
            return marks;
        }
    }
}
