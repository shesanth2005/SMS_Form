﻿using SMS_Form.Data;
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
                            lc.LecturerName = reader.IsDBNull(1) ? "" : reader.GetString(1);

                            lc.CourseId = reader.GetInt32(2);
                            lc.CourseName = reader.IsDBNull(3) ? "" : reader.GetString(3);


                            lectureCourses.Add(lc);
                        }
                    }
                }
            }

            return lectureCourses;
        }

        public string AddLectureCourse(Model.LectureCourse lectureCourse)
        {
            // Check if the lecturer is already assigned to the course
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




                // Insert the new lecturer-course assignment

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

                        lectureCourse.LecturerName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        lectureCourse.CourseName = reader.IsDBNull(3) ? "" : reader.GetString(3);
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
            WHERE LecturerId = @oldLecturerId AND CourseId = @oldCourseId";// Update the WHERE clause to use old values

                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@newLecturerId", lectureCourse.LecturerId);
                    cmd.Parameters.AddWithValue("@newCourseId", lectureCourse.CourseId);
                    cmd.Parameters.AddWithValue("@oldLecturerId", oldLecturerId);
                    cmd.Parameters.AddWithValue("@oldCourseId", oldCourseId);

                    cmd.ExecuteNonQuery();

                    return "Lecturer-course updated successfully.";
                   


                }
            }
        }

        public void DeleteLectureCourse(int lecturerId, int courseId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM LecturerCourse WHERE LecturerId = @LecturerId AND CourseId = @CourseId", conn);
                command.Parameters.AddWithValue("@LecturerId", lecturerId);
                command.Parameters.AddWithValue("@CourseId", courseId);
                command.ExecuteNonQuery();
            }
        }


    }
}
