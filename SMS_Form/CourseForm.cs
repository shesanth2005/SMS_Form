using SMS_Form.Controller;
using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMS_Form
{
    public partial class CourseForm : Form
    {
        private int selectedCourseId = -1;
        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void ClearForm()
        {
            courseName.Clear();
            selectedCourseId = -1;
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseName.Text))
            {
                MessageBox.Show("Please enter the Course Name ");
                return;
            }

            Course course = new Course
            {
                Name = courseName.Text,
            };

            CourseController courseController = new CourseController();
            string getMessage = courseController.Addcourse(course);
            MessageBox.Show(getMessage);
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

        private void btn_course_update_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(courseName.Text))
            {
                MessageBox.Show("Please enter the Course Name ");
                return;
            }

            var course = new Course
            {
                Id = selectedCourseId,
                Name = courseName.Text
                


            };

            CourseController controller = new CourseController();
            controller.UpdateCourse(course);
            LoadCourses();
            ClearForm();
            MessageBox.Show("Course Updated Successfully");

        }

        private void btn_course_delete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            CourseController courseController = new CourseController();

            var confirmResult = MessageBox.Show("Are you sure to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                courseController.DeleteCourse(selectedCourseId);
                LoadCourses();
                ClearForm();
                MessageBox.Show("Course Deleted Successfully");

            }

        }
    }
}
