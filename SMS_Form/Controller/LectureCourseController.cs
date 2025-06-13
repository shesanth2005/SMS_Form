using SMS_Form.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class LectureCourseController
    {
        public List<Model.LectureCourse> GetAllLectureCourses()
        {
            List<Model.LectureCourse> lectureCourses = new List<Model.LectureCourse>();

            string query = @"
        SELECT lc.LecturerId, l.Name AS LecturerName, 
               lc.CourseId, c.Name AS CourseName
        FROM LecturerCourse lc
        LEFT JOIN Lecturers l ON lc.LecturerId = l.Id
        LEFT JOIN Courses c ON lc.CourseId = c.Id";

            using (var conn = DbConfig.GetConnection())
            {
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var lc = new Model.LectureCourse();

                            lc.LecturerId = reader.GetInt32(0);
                            lc.LecturerName = reader.GetString(1);

                            lc.CourseId = reader.GetInt32(2);
                            lc.CourseName =reader.GetString(3);

                            lectureCourses.Add(lc);
                        }
                    }
                }
            }

            return lectureCourses;
        }

        public string AddLectureCourse(Model.LectureCourse lectureCourse)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM LecturerCourse WHERE LecturerId = @lecturerId AND CourseId = @courseId";
                using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@lecturerId", lectureCourse.LecturerId);
                    checkCmd.Parameters.AddWithValue("@courseId", lectureCourse.CourseId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return "This lecturer is already assigned to this course.";
                    }
                }






                string insertQuery = "INSERT INTO LecturerCourse (LecturerId, CourseId) VALUES (@lecturerId, @courseId)";

                SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@lecturerId", lectureCourse.LecturerId);
                cmd.Parameters.AddWithValue("@courseId", lectureCourse.CourseId);

                cmd.ExecuteNonQuery();

                return "Lecturer assigned to this course successfully.";
            }
        }


    }
}
