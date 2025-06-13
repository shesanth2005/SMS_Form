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

        public LectureCourse GetLecturerCourseById(int lecturerId, int courseId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string query = @"
            SELECT lc.LecturerId, lc.CourseId,
                   l.Name AS LecturerName,
                   c.Name AS CourseName
            FROM LecturerCourse lc
            LEFT JOIN Lecturers l ON lc.LecturerId = l.Id
            LEFT JOIN Courses c ON lc.CourseId = c.Id
            WHERE lc.LecturerId = @LecturerId AND lc.CourseId = @CourseId";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LecturerId", lecturerId);
                cmd.Parameters.AddWithValue("@CourseId", courseId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        LectureCourse lectureCourse = new LectureCourse();
                        lectureCourse.LecturerId = reader.GetInt32(0);
                        lectureCourse.CourseId = reader.GetInt32(1);
                        lectureCourse.LecturerName = reader.GetString(2); // assuming not null
                        lectureCourse.CourseName = reader.GetString(3);   // assuming not null
                        return lectureCourse;
                    }
                }
            }

            return null;
        }

        public string UpdateLectureCourse(int oldLecturerId, int oldCourseId, Model.LectureCourse lectureCourse)
        {
            using (var conn = DbConfig.GetConnection())
            {
                // Step 1: Check if new combination already exists
                string checkQuery = @"
            SELECT COUNT(*) FROM LecturerCourse 
            WHERE LecturerId = @newLecturerId AND CourseId = @newCourseId";

                using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@newLecturerId", lectureCourse.LecturerId);
                    checkCmd.Parameters.AddWithValue("@newCourseId", lectureCourse.CourseId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return "This lecturer is already assigned to this course.";
                    }
                }

                // Step 2: Perform the update using old values in WHERE clause
                string updateQuery = @"
            UPDATE LecturerCourse 
            SET LecturerId = @newLecturerId, CourseId = @newCourseId 
            WHERE LecturerId = @oldLecturerId AND CourseId = @oldCourseId";

                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@newLecturerId", lectureCourse.LecturerId);
                    cmd.Parameters.AddWithValue("@newCourseId", lectureCourse.CourseId);
                    cmd.Parameters.AddWithValue("@oldLecturerId", oldLecturerId);
                    cmd.Parameters.AddWithValue("@oldCourseId", oldCourseId);

                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0
                        ? "Lecturer-course updated successfully."
                        : "Update failed. No matching record found.";
                }
            }
        }

    }
}
