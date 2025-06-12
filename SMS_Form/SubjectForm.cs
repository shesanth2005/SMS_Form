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
using System.Xml.Linq;

namespace SMS_Form
{
    public partial class SubjectForm : Form
    {
        private int selectedSubjectId = -1;
        public SubjectForm()
        {
            InitializeComponent();
            LoadCourses();
            LoadSubjects();
        }

        private void ClearForm()
        {
            name.Clear();
            course_comboBox.SelectedIndex = -1;
            selectedSubjectId = -1;  
        }


        private void LoadCourses()
        {
            CourseController coursecontroller = new CourseController();
            List<Course> courses = coursecontroller.GetAllStream();
            course_comboBox.DataSource = courses;

            course_comboBox.DisplayMember = "Name";
            course_comboBox.ValueMember = "Id";

        }

        private void btn_add_subject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Please enter the Subject Name.");
                return;
            }

            if (course_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            Model.Subject subject = new Model.Subject
            {
                Name = name.Text,
                CourseId = Convert.ToInt32(course_comboBox.SelectedValue)
            };

            SubjectController subjectController = new SubjectController();
            string getMessage = subjectController.AddSubject(subject);
            MessageBox.Show(getMessage);
            LoadSubjects();

        }
        private void LoadSubjects()
        {
            SubjectController subjectController = new SubjectController();
            List<Model.Subject> subjects = subjectController.GetAllSubjects();
            SubjectView.DataSource = subjects;

            if (SubjectView.Columns.Contains("CourseId"))
            {
                SubjectView.Columns["CourseId"].Visible = false;
            }

            SubjectView.ClearSelection();
            SubjectView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (SubjectView.Columns.Contains("CourseName"))
            {
                SubjectView.Columns["CourseName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                SubjectView.Columns["CourseName"].HeaderText = "Course Name";
            }

            if (SubjectView.Columns.Contains("Name"))
            {
                SubjectView.Columns["Name"].HeaderText = "Subject Name";
            }
        }

        private void SubjectView_CellContentClick(object sender, EventArgs e)
        {
            if (SubjectView.SelectedRows.Count > 0)
            {
                var row = SubjectView.SelectedRows[0];
                var subjectView = row.DataBoundItem as Subject;

                if (subjectView != null)
                {
                    selectedSubjectId = subjectView.Id;

                    SubjectController subjectController = new SubjectController();
                    var subject = subjectController.GetSubjectById(selectedSubjectId);
                    if (subject != null)
                    {
                        name.Text = subject.Name;
                        course_comboBox.SelectedValue = subject.CourseId;
                    }
                }
            }
        }

        private void btn_update_subject_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Please enter a Subject Name.");
                return;
            }

            var subject = new Subject
            {
                Id = selectedSubjectId,
                Name = name.Text,
                CourseId = (int)course_comboBox.SelectedValue
            };

            SubjectController subjectController = new SubjectController();
            subjectController.UpdateSubject(subject);
            LoadSubjects();  // Assuming you have a method to refresh the subjects list
            ClearForm();
            MessageBox.Show("Subject Updated Successfully");
        }

        private void btn_subject_delete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            SubjectController subjectController = new SubjectController();
            var confirmResult = MessageBox.Show("Are you sure to delete this subject?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                subjectController.DeleteSubject(selectedSubjectId);
                LoadSubjects(); 
                ClearForm();
                MessageBox.Show("Subject Deleted Successfully");
            }
        }
    }
}
