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
    public partial class AddStudentForm : Form
    {
        public int UserId { get; set; }
        public AddStudentForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            if (course_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }



            Model.Student student = new Model.Student 
            { 
                Name = name.Text,
                Address= address.Text,
                CourseId = Convert.ToInt32(course_comboBox.SelectedValue),
                UserId=this.UserId


            };
            
            StudentController studentController = new StudentController();
            string getMessage=studentController.Addstudent(student);
            MessageBox.Show(getMessage);
            

            this.Close();


        }

        //private void LoadStudents()
        //{
        //  StudentController studentcontroller=new StudentController();
        //  List<Model.Student> students = studentcontroller.GetAllStudent();
        //  StudentView.DataSource = students;
        //  if (StudentView.Columns.Contains("CourseId"))
        //  {
        //        StudentView.Columns["CourseId"].Visible = false;
        //  }

        //  StudentView.ClearSelection();

        //}


        private void LoadCourses()
        {
            CourseController coursecontroller = new CourseController();
            List<Course> courses = coursecontroller.GetAllStream();
            course_comboBox.DataSource = courses;
            
            course_comboBox.DisplayMember = "Name";
            course_comboBox.ValueMember = "Id";

        }

        private void course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
