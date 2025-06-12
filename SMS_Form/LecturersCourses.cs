using SMS_Form.Controller;
using SMS_Form.Model;
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
    public partial class LecturersCourses : Form
    {
        private int selectedCourseId = -1;
       

        public LecturersCourses()
        {
            InitializeComponent();
            LoadCourses();
            
        }

        private void LoadCourses()
        {
            CourseController controller = new CourseController();
            List<Course> courses = controller.GetAllStream();
            CourseView.DataSource = courses;


            CourseView.ClearSelection();
            CourseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //CourseView.Columns["CourseName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //courseName.ReadOnly = true;


        }


        private void LecturerView_CellContentClick(object sender, EventArgs e)
        {

        }

        private void CourseView_CellContentClick(object sender, EventArgs e)
        {
            if (CourseView.SelectedRows.Count > 0)
            {
                var row = CourseView.SelectedRows[0];
                var courseView = row.DataBoundItem as Course;

                if (courseView != null)
                {

                    selectedCourseId = courseView.Id;




                    CourseController courseController = new CourseController();
                    var course = courseController.GetCourseById(selectedCourseId);
                    if (course != null)
                    {
                        courseName.Text = course.Name;


                    }
                }
            }


        }
    }
}
