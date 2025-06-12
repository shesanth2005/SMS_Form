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
        public Dashboard()
        {
            InitializeComponent();
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
    }
}
