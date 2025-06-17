using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Form
{
    public partial class Dashboard : Form
    {
        private string userRole;
        private int userId;

        public Dashboard(string role,int uid)
        {
            userRole = role;
            userId = uid;

            InitializeComponent();

            if (userRole == "Student")
            { 
              btn_admin.Visible = false;
              btn_staff.Visible = false;
              btn_course.Visible = false;
              btn_subject.Visible = false;
              btn_room.Visible = false;
              btn_lecturer.Visible = false;
              btn_user.Visible = false;
            }
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.ShowDialog();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();    
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();  
        }

        private void btn_lecturer_Click(object sender, EventArgs e)
        {
            panelLecturerSubmenu.Visible = !panelLecturerSubmenu.Visible;

        }

        private void btn_lec_dtail_Click(object sender, EventArgs e)
        {
            TeacherManagement teacherManagement = new TeacherManagement();
            teacherManagement.ShowDialog();
        }

        private void btn_lec_course_Click(object sender, EventArgs e)
        {
            LecturersCourses lecturersCourses = new LecturersCourses();
            lecturersCourses.ShowDialog();
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
             TimeTable timeTable = new TimeTable();
             timeTable.ShowDialog();    
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.ShowDialog();
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            Marks marks = new Marks();
            marks.ShowDialog();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            Staffs staffs = new Staffs();
            staffs.ShowDialog();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Admins admins = new Admins();
            admins.ShowDialog();
        }

        
       
    }
}
