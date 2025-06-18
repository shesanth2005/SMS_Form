using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS_Form.Controller;

namespace SMS_Form
{
    public partial class Marks : Form
    {
        private int selectedMarkId = -1; // To track the selected mark for updates or deletions
        private int selectedStudentId = -1; // To track the selected student for adding marks
        private int selectedExamId = -1; // To track the selected exam for adding marks
        private string Role; // To store the role of the user
        private int userId; // To store the user ID if needed
        private int studentid; // To store the student ID if needed
        public Marks(string role,int userid)
        {
            InitializeComponent();
            Role = role; // Store the role passed to the constructor
            userId = userid; // Store the user ID passed to the constructor
            if (Role == "Student")
            {
                btn_add.Visible = false; // Hide the add button for students
                btn_update_mark.Visible = false; // Hide the update button for students
                btn_delete_marks.Visible = false; // Hide the delete button for students
                loadmarksbystudentuserid(userId); // Load marks for the student based on user ID
                cmb_exam.Enabled = false; // Hide the exam combo box for students
                txt_marks.Enabled = false; // Hide the marks text box for students
                cmb_student.Enabled = false; // Hide the student combo box for students
            }
            else if (Role == "Staff")
            {
             
                btn_delete_marks.Visible = false; // Hide the delete button for staff
                LoadMarks();
                loadStudents();
                loadexams();
            }
            else if (Role == "Lecturer")
            {
                
                btn_delete_marks.Visible = false; // Hide the delete button for lecturers
                LoadMarks();
                loadStudents();
                loadexams();
            }
            else if (Role == "Admin")
            {
                // Admin has access to all buttons
                LoadMarks();
                loadStudents();
                loadexams();
            }
         
            //LoadMarks();
            //loadStudents();
            //loadexams();
            //clearFields(); // Clear fields on form load
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_student.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }
            if (cmb_exam.SelectedValue == null)
            {
                MessageBox.Show("Please select an exam.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_marks.Text))
            {
                MessageBox.Show("Please enter marks.");
                return;
            }
            if (!markcheck())
            {
                return; // Stop if validation failed
            }
            Model.Mark mark = new Model.Mark();
            mark.StudentId = Convert.ToInt32(cmb_student.SelectedValue);
            mark.ExamId = Convert.ToInt32(cmb_exam.SelectedValue);
            mark.Marks = Convert.ToInt32(txt_marks.Text);
            Controller.MarkController markController = new Controller.MarkController();
            string result = markController.AddMark(mark);
            MessageBox.Show(result);
            LoadMarks();
            clearFields(); // Clear fields after adding a new mark
        }

        private void LoadMarks()
        {
            Controller.MarkController markController = new Controller.MarkController();
            var marks = markController.GetAllMarks();
            dgv_marks.DataSource = marks;
            if (dgv_marks.Columns.Contains("StudentId"))
            {
                dgv_marks.Columns["StudentId"].Visible = false; // Hide the StudentId column
            }
            if (dgv_marks.Columns.Contains("ExamId"))
            {
                dgv_marks.Columns["ExamId"].Visible = false; // Hide the ExamId column
            }
            dgv_marks.Columns["StudentName"].DisplayIndex = 1;
            dgv_marks.Columns["ExamName"].DisplayIndex = 2;
            dgv_marks.Columns["Marks"].DisplayIndex = 3;

        }
        private void loadmarksbystudentuserid(int userid)
        {
            StudentController studentController = new StudentController();

            var student = studentController.GetStudentByUserId(userid);
            if (student != null)
            {
                studentid= student.Id; // Get the student ID from the student object
            }
            Controller.MarkController markController = new Controller.MarkController();
            var marks = markController.GetMarksByStudentid(studentid);
            dgv_marks.DataSource = marks;
            if (dgv_marks.Columns.Contains("StudentId"))
            {
                dgv_marks.Columns["StudentId"].Visible = false; // Hide the StudentId column
            }
            if (dgv_marks.Columns.Contains("ExamId"))
            {
                dgv_marks.Columns["ExamId"].Visible = false; // Hide the ExamId column
            }
            if(dgv_marks.Columns.Contains("Id"))
            {
                dgv_marks.Columns["Id"].Visible = false; // Hide the Id column
            }
            dgv_marks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_marks.Columns["StudentName"].DisplayIndex = 0;
            dgv_marks.Columns["ExamName"].DisplayIndex = 1;
            dgv_marks.Columns["Marks"].DisplayIndex = 2;

        }

        private void loadStudents()
        {
            Controller.StudentController studentController = new Controller.StudentController();
            var students = studentController.GetAllStudent();
            cmb_student.DataSource = students;
            cmb_student.DisplayMember = "Id";
            cmb_student.ValueMember = "Id";
        }

        private void loadexams()
        {
            Controller.ExamController examController = new Controller.ExamController();
            var exams = examController.GetAllExams();
            cmb_exam.DataSource = exams;
            cmb_exam.DisplayMember = "Name";
            cmb_exam.ValueMember = "Id";
            cmb_exam.SelectedIndex = -1; // Reset the selected exam index
        }

        private void clearFields()
        {
            cmb_student.SelectedIndex = -1;
            cmb_exam.SelectedIndex = -1;
            txt_marks.Clear();
            selectedMarkId = -1; // Reset the selected mark ID
            selectedStudentId = -1; // Reset the selected student ID
            selectedExamId = -1; // Reset the selected exam ID
        }

        private void dgv_marks_CellContentClick(object sender, EventArgs e)
        {


            if (dgv_marks.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_marks.SelectedRows[0];
                var mark = selectedRow.DataBoundItem as Model.Mark;

                if (mark != null)
                {
                    selectedMarkId = mark.Id; // Store the selected mark ID for updates or deletions
                    selectedStudentId = mark.StudentId; // Store the selected student ID
                    selectedExamId = mark.ExamId; // Store the selected exam ID
                }

                MarkController markController = new MarkController();
                var selectedMark = markController.GetMarkById(selectedMarkId);
                if (selectedMark != null)
                {
                    cmb_student.SelectedValue = selectedMark.StudentId; // Set the selected student
                    cmb_exam.SelectedValue = selectedMark.ExamId; // Set the selected exam
                    txt_marks.Text = selectedMark.Marks.ToString(); // Set the marks text box
                }
            }

        }




        private bool markcheck()
        {
            int mar;
            if (!int.TryParse(txt_marks.Text.Trim(), out mar))
            {
                MessageBox.Show("Please enter a valid numeric value for marks.");
                txt_marks.Clear();
                txt_marks.Focus();
                return false;
            }

            if (mar < 0 || mar > 100)
            {
                MessageBox.Show("Marks must be between 0 and 100.");
                txt_marks.Clear();
                txt_marks.Focus();
                return false;
            }

            return true;  // Valid marks
        }




        private void btn_update_mark_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }
            if (cmb_student.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }
            if (cmb_exam.SelectedValue == null)
            {
                MessageBox.Show("Please select an exam.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_marks.Text))
            {
                MessageBox.Show("Please enter marks.");
                return;
            }
            if (!markcheck())
            {
                return; // Stop if validation failed
            }
            Model.Mark mark = new Model.Mark();
            mark.Id = selectedMarkId; // Use the selected mark ID for updating
            mark.StudentId = Convert.ToInt32(cmb_student.SelectedValue);
            mark.ExamId = Convert.ToInt32(cmb_exam.SelectedValue);
            mark.Marks = int.Parse(txt_marks.Text);
            Controller.MarkController markController = new Controller.MarkController();
            string result = markController.UpdateMark(mark);
            MessageBox.Show(result);
            LoadMarks();
            clearFields(); // Clear fields after updating a mark
        }

        private void btn_delete_marks_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }
            Controller.MarkController markController = new Controller.MarkController();
            string result = markController.DeleteMark(selectedMarkId);
            MessageBox.Show(result);
            LoadMarks();
            clearFields(); // Clear fields after deleting a mark
        }
    }
}
