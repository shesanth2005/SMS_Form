using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMS_Form.Data
{
    internal static class Migration
    {
        public static void CreateTables()
        {
            using (var getdbconn = DbConfig.GetConnection())
            {

                string tableQueries = @" 
                        CREATE TABLE IF NOT EXISTS Courses ( 
                            Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                            Name TEXT NOT NULL 
                        );

                        CREATE TABLE IF NOT EXISTS Users (
                            UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL,
                            Password TEXT NOT NULL,
                            Role TEXT NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS Lecturers ( 
                            Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                            Name TEXT NOT NULL, 
                            Address TEXT NOT NULL, 
                            Telephone TEXT NOT NULL,
                            UserId INTEGER NOT NULL,
                            FOREIGN KEY (UserId) REFERENCES Users(UserID) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Students ( 
                            Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                            Name TEXT NOT NULL,
                            Address TEXT NOT NULL,
                            CourseId INTEGER NOT NULL,
                            UserId INTEGER NOT NULL,
                            FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE,
                            FOREIGN KEY (UserId) REFERENCES Users(UserID) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS StudentLecturer ( 
                            StudentId INTEGER NOT NULL, 
                            LecturerId INTEGER NOT NULL, 
                            PRIMARY KEY (StudentId, LecturerId), 
                            FOREIGN KEY (StudentId) REFERENCES Students(Id) ON DELETE CASCADE, 
                            FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS LecturerCourse (
                            LecturerId INTEGER NOT NULL,
                            CourseId INTEGER NOT NULL,
                            PRIMARY KEY (LecturerId, CourseId),
                            FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id) ON DELETE CASCADE,
                            FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Rooms(
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            RoomName TEXT NOT NULL,
                            RoomType INTEGER NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS Subjects (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            CourseId INTEGER NOT NULL,
                            FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Timetable (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectId INTEGER NOT NULL,
                            Day TEXT NOT NULL,
                            StartTime TEXT NOT NULL,
                            EndTime TEXT NOT NULL,
                            RoomId INTEGER NOT NULL,
                            FOREIGN KEY (SubjectId) REFERENCES Subjects(Id) ON DELETE CASCADE,
                            FOREIGN KEY (RoomId) REFERENCES Rooms(Id)
                        );

                        CREATE TABLE IF NOT EXISTS Exams (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            SubjectId INTEGER NOT NULL,
                            FOREIGN KEY (SubjectId) REFERENCES Subjects(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Marks (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentId INTEGER NOT NULL,
                            ExamId INTEGER NOT NULL,
                            Marks INTEGER NOT NULL,
                            FOREIGN KEY (StudentId) REFERENCES Students(Id) ON DELETE CASCADE,
                            FOREIGN KEY (ExamId) REFERENCES Exams(Id) ON DELETE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS Staffs (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            StaffRole TEXT NOT NULL,
                            UserId INTEGER NOT NULL,
                            FOREIGN KEY (UserId) REFERENCES Users(UserID) ON DELETE CASCADE
                        );
                    ";



                SQLiteCommand Command = new SQLiteCommand(tableQueries, getdbconn);
                Command.ExecuteNonQuery();

                MessageBox.Show("Sucessfully Table Created");

                var checkAdminCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username = @username;", getdbconn);
                checkAdminCmd.Parameters.AddWithValue("@username", "admin");
                long count = (long)checkAdminCmd.ExecuteScalar();

                if (count == 0)
                {
                    // Insert default admin user
                    var insertAdminCmd = new SQLiteCommand(@"
                        INSERT INTO Users (Username, Password, Role) 
                        VALUES (@username, @password, @role);", getdbconn);

                    insertAdminCmd.Parameters.AddWithValue("@username", "admin");
                    insertAdminCmd.Parameters.AddWithValue("@password", "admin123"); // Replace with hashed password in real app
                    insertAdminCmd.Parameters.AddWithValue("@role", "Admin");

                    insertAdminCmd.ExecuteNonQuery();




                }
            }
        }
    }
}
