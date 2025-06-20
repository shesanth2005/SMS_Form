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
    public partial class StudentManagement : Form
    {
        private int selectedStudentId = -1;
        private int selectedUserId = -1;
  

        public StudentManagement()
        {
            InitializeComponent();
            LoadCourses();
            LoadStudents();
            StudentView.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            ClearForm();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            name.Clear();
            address.Clear();
            course_comboBox_main.SelectedIndex = -1;
            selectedStudentId = -1;
            selectedUserId = -1;
            name.Enabled = false;
            address.Enabled = false;
            course_comboBox_main.Enabled = false;

        }

        private void LoadCourses()
        {
            CourseController coursecontroller_01 = new CourseController();
            List<Course> courses = coursecontroller_01.GetAllStream();
            course_comboBox_main.DataSource = courses;

            course_comboBox_main.DisplayMember = "Name";
            course_comboBox_main.ValueMember = "Id";

        }

        private void LoadStudents()
        {
            StudentController studentcontroller_01 = new StudentController();
            List<Model.Student> students = studentcontroller_01.GetAllStudent();
            StudentView.DataSource = students;
            if (StudentView.Columns.Contains("CourseId"))
            {
                StudentView.Columns["CourseId"].Visible = false;
            }

            StudentView.ClearSelection();
            StudentView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentView.Columns["CourseName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
            StudentAccount studentAccount = new StudentAccount();
            studentAccount.ShowDialog();

  

        
            LoadStudents();
        }

        private void StudentView_CellContentClick(object sender, EventArgs e)
        {
            if (StudentView.SelectedRows.Count > 0)
            {
                var row = StudentView.SelectedRows[0];
                var studentView = row.DataBoundItem as Student;

                if (studentView != null)
                {
                    selectedStudentId = studentView.Id;
                    selectedUserId = studentView.UserId;
                    name.Enabled = true;
                    address.Enabled = true;
                    course_comboBox_main.Enabled = true;



                    StudentController studentcontroller = new StudentController();
                    var student=studentcontroller.GetStudentById(selectedStudentId);
                    if (student != null)
                    {
                        name.Text = student.Name;
                        address.Text = student.Address;
                        course_comboBox_main.SelectedValue = student.CourseId;
                        
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            var student = new Student
            {
                Id = selectedStudentId,
                Name = name.Text,
                Address = address.Text,
                CourseId = (int)course_comboBox_main.SelectedValue,




            };

            StudentController studentController = new StudentController();
            studentController.UpdateStudent(student);
            LoadStudents();
            ClearForm();
            MessageBox.Show("Student Updated Successfully");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            StudentController studentController = new StudentController();
            UserController userController = new UserController();
            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            { 
                studentController.DeleteStudent(selectedStudentId);
                userController.DeleteUser(selectedUserId);
                LoadStudents();
                ClearForm();
                MessageBox.Show("Student Deleted Successfully");

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtsearch.Text.ToLower().Trim();

            StudentController studentController = new StudentController();
            List<Student> allStudents = studentController.GetAllStudent();

            if (string.IsNullOrEmpty(keyword))
            {
                // If search box is empty, show all students
                StudentView.DataSource = allStudents;
            }
            else
            {
                // Filter by Name, Id, CourseName, or Address
                var filteredStudents = allStudents
                    .Where(s => (s.Name != null && s.Name.ToLower().Contains(keyword))
                             || s.Id.ToString().Contains(keyword)
                             || (s.CourseName != null && s.CourseName.ToLower().Contains(keyword))
                             || (s.Address != null && s.Address.ToLower().Contains(keyword)))
                    .ToList();

                StudentView.DataSource = filteredStudents;
            }

            if (StudentView.Columns.Contains("CourseId"))
            {
                StudentView.Columns["CourseId"].Visible = false;
            }

            StudentView.ClearSelection();
            StudentView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentView.Columns["CourseName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
