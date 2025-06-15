using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class ExamController
    {
        public string AddExam(Model.Exam exam)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string AddExamQuery = "INSERT INTO Exams(Name,SubjectId)VALUES(@name,@subjectid)";
                using (var insertExamCommand = new System.Data.SQLite.SQLiteCommand(AddExamQuery, getdbconn))
                {
                    insertExamCommand.Parameters.AddWithValue("@name", exam.Name);
                    insertExamCommand.Parameters.AddWithValue("@subjectid", exam.SubjectId);
                    insertExamCommand.ExecuteNonQuery();
                }
                return "Exam Added Successfully";
            }
        }
        public List<Model.Exam> GetAllExams()
        {
            List<Model.Exam> exams = new List<Model.Exam>();
            string getExamsQuery = @"
                    SELECT e.Id, e.Name, e.SubjectId, s.Name AS SubjectName
                    FROM Exams e
                    LEFT JOIN Subjects s ON e.SubjectId = s.Id";
            using (var conn = Data.DbConfig.GetConnection())
            {
                using (var getExamsCommand = new System.Data.SQLite.SQLiteCommand(getExamsQuery, conn))
                {
                    var readers = getExamsCommand.ExecuteReader();
                    while (readers.Read())
                    {
                        Model.Exam exam = new Model.Exam();
                        exam.Id = readers.GetInt32(0);
                        exam.Name = readers.GetString(1);
                        exam.SubjectId = readers.GetInt32(2);
                        exam.SubjectName = readers.GetString(3);
                        exams.Add(exam);
                    }
                }
            }
            return exams;
        }

        


        public string UpdateExam(Model.Exam exam)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string UpdateExamQuery = "UPDATE Exams SET Name = @name, SubjectId = @subjectid WHERE Id = @id";
                using (var updateExamCommand = new System.Data.SQLite.SQLiteCommand(UpdateExamQuery, getdbconn))
                {
                    updateExamCommand.Parameters.AddWithValue("@name", exam.Name);
                    updateExamCommand.Parameters.AddWithValue("@subjectid", exam.SubjectId);
                    updateExamCommand.Parameters.AddWithValue("@id", exam.Id);
                    updateExamCommand.ExecuteNonQuery();
                }
                return "Exam Updated Successfully";
            }
        }

        public string DeleteExam(int examId)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string DeleteExamQuery = "DELETE FROM Exams WHERE Id = @id";
                using (var deleteExamCommand = new System.Data.SQLite.SQLiteCommand(DeleteExamQuery, getdbconn))
                {
                    deleteExamCommand.Parameters.AddWithValue("@id", examId);
                    deleteExamCommand.ExecuteNonQuery();
                }
                return "Exam Deleted Successfully";
            }
        }


        public Model.Exam GetExamById(int examId)
        {
            Model.Exam exam = null;
            string getExamQuery = "SELECT Id, Name, SubjectId FROM Exams WHERE Id = @id";
            using (var conn = Data.DbConfig.GetConnection())
            {
                using (var getExamCommand = new System.Data.SQLite.SQLiteCommand(getExamQuery, conn))
                {
                    getExamCommand.Parameters.AddWithValue("@id", examId);
                    var reader = getExamCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        exam = new Model.Exam
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            SubjectId = reader.GetInt32(2)
                        };
                    }
                }
            }
            return exam;
        }
    }
}
