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
    internal class StudentController
    {
        public string Addstudent(Model.Student student)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string Addstudent = "INSERT INTO Students(Name,Address,CourseId,UserId)VALUES(@name,@address,@courseid,@userid)";

                SQLiteCommand insertstudentcommand = new SQLiteCommand(Addstudent, getdbconn);

                insertstudentcommand.Parameters.AddWithValue("@name", student.Name);
                insertstudentcommand.Parameters.AddWithValue("@address", student.Address);
                insertstudentcommand.Parameters.AddWithValue("@courseid", student.CourseId);
                insertstudentcommand.Parameters.AddWithValue("@userid", student.UserId);
                insertstudentcommand.ExecuteNonQuery();
                return "Student Added Successfully";

            }
        }

        public List<Model.Student> GetAllStudent()
        {
            List<Model.Student> students = new List<Model.Student>();
            string getStudentQuery = @"
                    SELECT s.Id, s.Name, s.Address, s.CourseId,cou.Name AS CourseName,s.UserId
                    FROM Students s
                    LEFT JOIN Courses cou ON s.CourseId = cou.Id";


            using (var conn = DbConfig.GetConnection())
            {



                SQLiteCommand getStudentscommand = new SQLiteCommand(getStudentQuery, conn);
                var readers = getStudentscommand.ExecuteReader();


                while (readers.Read())
                {
                    Model.Student student = new Model.Student();
                    student.Id = readers.GetInt32(0);
                    student.Name = readers.GetString(1);
                    student.Address = readers.GetString(2);
                    student.CourseId = readers.GetInt32(3);
                    student.CourseName = readers.GetString(4);
                    student.UserId = readers.GetInt32(5);



                    students.Add(student);
                }
                return students;


            }
        }

        public Student GetStudentById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Students WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Student student = new Student();
                        student.Id = reader.GetInt32(0);
                        student.Name = reader.GetString(1);
                        student.Address = reader.GetString(2);
                        student.CourseId = reader.GetInt32(3);
                        student.UserId = reader.GetInt32(4);
                        return student;
                    }
                }
            }

            return null;
        }

        public void UpdateStudent(Student student)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Students SET Name = @Name, Address = @Address, CourseId = @CourseId  WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@CourseId", student.CourseId);
                command.Parameters.AddWithValue("@Id", student.Id);
                //command.Parameters.AddWithValue("@UserId",student.UserId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Students WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", studentId);
                command.ExecuteNonQuery();
            }
        }
    }
}


