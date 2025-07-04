﻿using System;
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
            LoadFormInPanel(new Home()); // Load the home form initially


            if (userRole == "Student")
            { 
              btn_admin.Visible = false;
              btn_staff.Visible = false;
              btn_student.Visible = false;
              btn_course.Visible = false;
              btn_subject.Visible = false;
              btn_room.Visible = false;
              btn_lecturer.Visible = false;
              btn_user.Visible = false;
              btn_exam.Visible = false;
            }
            else if (userRole == "Staff")
            {
                btn_admin.Visible = false;
                btn_student.Visible = false;
                btn_course.Visible = false;
                btn_subject.Visible = false;
                btn_room.Visible = false;
                btn_lecturer.Visible = false;
                btn_user.Visible = false;
                btn_staff.Visible = false;

            }
            else if (userRole == "Lecturer")
            {
                btn_admin.Visible = false;
                btn_student.Visible = false;
                btn_course.Visible = false;
                btn_subject.Visible = false;
                btn_room.Visible = false;
                btn_staff.Visible = false;
                btn_user.Visible = false;
                btn_lecturer.Visible = false;
                btn_exam.Visible = false;
            }
            else if (userRole == "Admin")
            {
                // Admin has access to all buttons, no changes needed
            }
        }
        private void LoadFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();  // Clear existing controls

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(form);
            form.Show();
        }


        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement = new StudentManagement();
            LoadFormInPanel(studentManagement);
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            LoadFormInPanel(courseForm);
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            LoadFormInPanel(subjectForm);
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            LoadFormInPanel(roomForm);  
        }

        private void btn_lecturer_Click(object sender, EventArgs e)
        {
            panelLecturerSubmenu.Visible = !panelLecturerSubmenu.Visible;

        }

        private void btn_lec_dtail_Click(object sender, EventArgs e)
        {
            TeacherManagement teacherManagement = new TeacherManagement();
            LoadFormInPanel(teacherManagement);
        }

        private void btn_lec_course_Click(object sender, EventArgs e)
        {
            LecturersCourses lecturersCourses = new LecturersCourses();
            LoadFormInPanel(lecturersCourses);
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
             TimeTable timeTable = new TimeTable(userRole);
           
             LoadFormInPanel(timeTable);    
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam(userRole);
            LoadFormInPanel(exam);
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            Marks marks = new Marks(userRole,userId);
            LoadFormInPanel(marks);
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            Staffs staffs = new Staffs();
            LoadFormInPanel(staffs);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            LoadFormInPanel(users);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Admins admins = new Admins();
            LoadFormInPanel(admins);
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            Feedbacks feedbacks = new Feedbacks(userRole);
            LoadFormInPanel(feedbacks);
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            AccountDashboard accountDashboard = new AccountDashboard(userRole, userId);
            LoadFormInPanel(accountDashboard);
        }

        private void btb_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            LoadFormInPanel(home);
        }

        private void btn_studymaterials_Click(object sender, EventArgs e)
        {
            Studymaterials studymaterials = new Studymaterials(userRole);
            LoadFormInPanel(studymaterials);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the Dashboard form
            Login loginForm = new Login(); // Create a new instance of the Login form
            loginForm.ShowDialog(); // Show the Login form
        }
    }
}
