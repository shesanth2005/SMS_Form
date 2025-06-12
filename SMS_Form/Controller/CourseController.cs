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
    internal class CourseController
    {
        public List<Course> GetAllStream()
        {
            List<Course> courses = new List<Course>();
            string getStudentQuery = "SELECT * FROM Courses";
            using (var conn = DbConfig.GetConnection())
            {



                SQLiteCommand getStudentscommand = new SQLiteCommand(getStudentQuery, conn);
                var readers = getStudentscommand.ExecuteReader();


                while (readers.Read())
                {
                    Course course= new Course();
                    
                    course.Id = readers.GetInt32(0);
                    course.Name = readers.GetString(1);
                    
                    courses.Add(course);
                }
                return courses;


            }
        }

        public string Addcourse(Course course)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string Addcourse = "INSERT INTO Courses(Name)VALUES(@name)";

                SQLiteCommand insertusercommand = new SQLiteCommand(Addcourse, getdbconn);
                insertusercommand.Parameters.AddWithValue("@name", course.Name);
               
             
                insertusercommand.ExecuteNonQuery();

                return "Course Added Successfully";

            }
        }

        public Course GetCourseById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Course course = new Course();

                        course.Id = reader.GetInt32(0);
                        course.Name = reader.GetString(1);
                        return course;
                    }
                }
            }

            return null;
        }

        public void UpdateCourse(Course course)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Courses SET Name=@Name   WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Name",course.Name);
                command.Parameters.AddWithValue("@Id",course.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Courses WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", courseId);
                command.ExecuteNonQuery();
            }
        }
    }
}
