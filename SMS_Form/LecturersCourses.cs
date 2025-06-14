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
    public partial class LecturersCourses : Form
    {
        private int selectedCourseId = -1;
        private int selectedLectureId = -1;
        private int oldCourseId = -1;
        private int oldLectureId = -1;


        public LecturersCourses()
        {
            InitializeComponent();
            LoadCourses();
            LoadLecturers();
            LoadLecturerCourses();
            ClearForm();

        }

        private void ClearForm()
        {
            selectedCourseId = -1;
            selectedLectureId = -1;
            oldCourseId = -1;
            oldLectureId = -1;
            lecturerName.Clear();
            courseName.Clear();


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
            LoadLecturerCourses();
        }

        private void LoadLecturerCourses()
        {
            LectureCourseController lectureCourseController = new LectureCourseController();
            List<LectureCourse> lectureCourses = lectureCourseController.GetAllLectureCourses();

            LecturerCourseView.DataSource = lectureCourses;

            // Optional: Hide internal IDs (if needed)
            if (LecturerCourseView.Columns.Contains("LecturerId"))
                LecturerCourseView.Columns["LecturerId"].Visible = true;

            if (LecturerCourseView.Columns.Contains("CourseId"))
                LecturerCourseView.Columns["CourseId"].Visible = false;

            // Optional: adjust column sizing
            LecturerCourseView.ClearSelection();
            LecturerCourseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (oldLectureId == -1 || oldCourseId == -1)
            {
                MessageBox.Show("Please select a lecturer-course pair from LecturerCourse table to update.");
                return;
            }

            Model.LectureCourse lectureCourse = new Model.LectureCourse();

            //LecturerId = selectedLectureId,
            //CourseId = selectedCourseId

            if (oldLectureId == selectedLectureId && oldCourseId == selectedCourseId)
            {
                MessageBox.Show("No changes detected. Please select a different lecturer or course to update.");
                return;
            }
            else if (oldCourseId == selectedCourseId && oldLectureId != selectedLectureId)
            {
                lectureCourse.LecturerId = selectedLectureId;
                lectureCourse.CourseId = oldCourseId;
            }
            else if (oldLectureId == selectedLectureId && oldCourseId != selectedCourseId)
            {
                lectureCourse.LecturerId = oldLectureId;
                lectureCourse.CourseId = selectedCourseId;
            }
            else if (oldLectureId != selectedLectureId && oldCourseId != selectedCourseId)
            {
                lectureCourse.LecturerId = selectedLectureId;
                lectureCourse.CourseId = selectedCourseId;
            }

                // Save to DB
            LectureCourseController lectureCourseController = new LectureCourseController();
            string message = lectureCourseController.UpdateLectureCourse(oldLectureId,oldCourseId,lectureCourse);

            // Show message
            MessageBox.Show(message);
            LoadLecturerCourses();
            ClearForm();


        }

        private void LecturerCourseView_CellContentClick(object sender, EventArgs e)
        {
            if (LecturerCourseView.SelectedRows.Count > 0)
            {
                var row = LecturerCourseView.SelectedRows[0];
                var lecturerCourseView = row.DataBoundItem as LectureCourse;

                if (lecturerCourseView != null)
                {
                

                    oldCourseId = lecturerCourseView.CourseId;
                    oldLectureId = lecturerCourseView.LecturerId;
                   

                    LectureCourseController lecturerCourseController = new LectureCourseController();
                    var lecturerCourse = lecturerCourseController.GetLecturerCourseById(oldLectureId,oldCourseId);
                    if (lecturerCourse != null)
                    {
                        lecturerName.Text = lecturerCourse.LecturerName;
                        courseName.Text = lecturerCourse.CourseName;
                    }
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (oldLectureId == -1 || oldCourseId == -1)
            {
                MessageBox.Show("Please select a lecturer-course pair from LecturerCourse table to delete.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure to delete this lecturer-course assignment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                LectureCourseController lectureCourseController = new LectureCourseController();

                lectureCourseController.DeleteLectureCourse(oldLectureId, oldCourseId);
                LoadLecturerCourses();
                ClearForm();
                MessageBox.Show("Lecturer-course assignment deleted successfully.");
            }
        }
    }
}
