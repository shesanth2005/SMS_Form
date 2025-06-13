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
        private int selectedLectureId = -1;
       

        public LecturersCourses()
        {
            InitializeComponent();
            LoadCourses();
            LoadLecturers();
            LoadLecturerCourses();
            
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
            if (LecturerView.SelectedRows.Count > 0)
            {
                var row = LecturerView.SelectedRows[0];
                var lecturer = row.DataBoundItem as Lecturer;

                if (lecturer != null)
                {
                    selectedLectureId =lecturer.Id;

                    LecturerController lectureController = new LecturerController();
                    var selectedLecture = lectureController.GetLecturerById(selectedLectureId);

                    if (selectedLecture != null)
                    {
                        lecturerName.Text = selectedLecture.Name;
                        // You can also set other UI controls here if needed
                    }
                }
            }


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
        private void LoadLecturers()
        {
            LecturerController lecturerController = new LecturerController();
            List<Lecturer> lecturers = lecturerController.GetAllLecturers();
            LecturerView.DataSource = lecturers;

            // Hide internal database ID if needed


            LecturerView.ClearSelection();
            LecturerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: Adjust specific column widths
            if (LecturerView.Columns.Contains("UserId"))
            {
                LecturerView.Columns["UserId"].Visible = false;
            }

            if (LecturerView.Columns.Contains("Address"))
            {
                LecturerView.Columns["Address"].Visible = false;
            }

            if (LecturerView.Columns.Contains("Telephone"))
            {
                LecturerView.Columns["Telephone"].Visible = false;
            }

            if (LecturerView.Columns.Contains("id"))
            {
                LecturerView.Columns["id"].HeaderText = "Lecture Id";
            }

            if (LecturerView.Columns.Contains("Name"))
            {
                LecturerView.Columns["Name"].HeaderText = "Lecture Name";
            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lecturerName.Text) || string.IsNullOrWhiteSpace(courseName.Text))
            {
                MessageBox.Show("Please enter both Lecturer Name and Course Name.");
                return;
            }

            Model.LectureCourse lectureCourse = new Model.LectureCourse
            {
                LecturerId = selectedLectureId,
                CourseId = selectedCourseId
            };

            // Save to DB
            LectureCourseController lectureCourseController = new LectureCourseController();
            string message = lectureCourseController.AddLectureCourse(lectureCourse);

            // Show message
            MessageBox.Show(message);
        }

        private void LoadLecturerCourses()
        {
            LectureCourseController lectureCourseController = new LectureCourseController();
            List<LectureCourse> lectureCourses = lectureCourseController.GetAllLectureCourses();

            LecturerCourseView.DataSource = lectureCourses;

            // Optional: Hide internal IDs (if needed)
            if (LecturerCourseView.Columns.Contains("LecturerId"))
                LecturerCourseView.Columns["LecturerId"].Visible = false;

            if (LecturerCourseView.Columns.Contains("CourseId"))
                LecturerCourseView.Columns["CourseId"].Visible = false;

            // Optional: adjust column sizing
            LecturerCourseView.ClearSelection();
            LecturerCourseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
