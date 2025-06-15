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
        FOREIGN KEY (UserId) REFERENCES Users(UserID)
    );

    CREATE TABLE IF NOT EXISTS Students ( 
        Id INTEGER PRIMARY KEY AUTOINCREMENT, 
        Name TEXT NOT NULL,
        Address TEXT NOT NULL,
        CourseId INTEGER NOT NULL,
        UserId INTEGER NOT NULL,
        FOREIGN KEY (CourseId) REFERENCES Courses(Id),
        FOREIGN KEY (UserId) REFERENCES Users(UserID)
    );

    CREATE TABLE IF NOT EXISTS StudentLecturer ( 
        StudentId INTEGER NOT NULL, 
        LecturerId INTEGER NOT NULL, 
        PRIMARY KEY (StudentId, LecturerId), 
        FOREIGN KEY (StudentId) REFERENCES Students(Id), 
        FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id)
    );

    CREATE TABLE IF NOT EXISTS LecturerCourse (
        LecturerId INTEGER NOT NULL,
        CourseId INTEGER NOT NULL,
        PRIMARY KEY (LecturerId, CourseId),
        FOREIGN KEY (LecturerId) REFERENCES Lecturers(Id),
        FOREIGN KEY (CourseId) REFERENCES Courses(Id)
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
        FOREIGN KEY (CourseId) REFERENCES Courses(Id)
    );
    CREATE TABLE IF NOT EXISTS Timetable (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        SubjectId INTEGER NOT NULL,
        Day TEXT NOT NULL,
        StartTime TEXT NOT NULL,
        EndTime TEXT NOT NULL,
        RoomId INTEGER NOT NULL,
        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id),
        FOREIGN KEY (RoomId) REFERENCES Rooms(Id)
   
    );
    CREATE TABLE IF NOT EXISTS Exams (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL,
        SubjectId INTEGER NOT NULL,
        FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
    );
        

";




                SQLiteCommand Command = new SQLiteCommand(tableQueries,getdbconn);
                Command.ExecuteNonQuery();

                MessageBox.Show("Sucessfully Table Created");



                //CREATE TABLE IF NOT EXISTS Attendance(
                //    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                //    StudentId INTEGER NOT NULL,
                //    SubjectId INTEGER NOT NULL,
                //    Date TEXT NOT NULL,
                //    Status TEXT NOT NULL,
                //    FOREIGN KEY (StudentId) REFERENCES Students(Id),
                //    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)


                //);

            }
        }
    }
}
