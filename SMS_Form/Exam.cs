using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS_Form.Controller;
using SMS_Form.Model;

namespace SMS_Form
{
    public partial class Exam : Form
    {
        private int selectedExamId = -1; // To track the selected exam for updates or deletions
        public Exam()
        {
            InitializeComponent();
            LoadExams();
            LoadSubjects();
            clearFields();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_exam_name.Text))
            {
                MessageBox.Show("Please enter exam name.");
                return;
            }
            if (cmb_subject.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            Model.Exam exam = new Model.Exam();
            exam.Name = txt_exam_name.Text;
            exam.SubjectId = Convert.ToInt32(cmb_subject.SelectedValue);
            Controller.ExamController examController = new Controller.ExamController();
            string result = examController.AddExam(exam);
            MessageBox.Show(result);
            LoadExams();
            clearFields(); // Clear fields after adding a new exam

        }

        public void LoadExams()
        {
            Controller.ExamController examController = new Controller.ExamController();
            var exams = examController.GetAllExams();
            dgv_exam.DataSource = exams;

            if (dgv_exam.Columns.Contains("SubjectId"))
            {
                //dgv_exam.Columns["Id"].Visible = false; 
                dgv_exam.Columns["SubjectId"].Visible = false; // Hide the SubjectId column
            }
            dgv_exam.ClearSelection();
            dgv_exam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadSubjects()
        {
            Controller.SubjectController subjectController = new Controller.SubjectController();
            var subjects = subjectController.GetAllSubjects();
            cmb_subject.DataSource = subjects;
            cmb_subject.DisplayMember = "Name";
            cmb_subject.ValueMember = "Id";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_exam_name.Text))
            {
                MessageBox.Show("Please enter exam name.");
                return;
            }
            if (cmb_subject.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }
            Model.Exam exam = new Model.Exam();
            exam.Id = selectedExamId; // Set the ID of the exam to update   
            exam.Name = txt_exam_name.Text;
            exam.SubjectId = Convert.ToInt32(cmb_subject.SelectedValue);
            Controller.ExamController examController = new Controller.ExamController();
            string result = examController.UpdateExam(exam);
            MessageBox.Show(result);
            LoadExams();
            clearFields(); // Clear fields after update


        }

        private void dgv_exam_CellContentClick(object sender, EventArgs e)
        {
            if (dgv_exam.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_exam.SelectedRows[0];
                var exam1 = selectedRow.DataBoundItem as Model.Exam;



                if (exam1 != null)
                {
                    selectedExamId = exam1.Id; // Store the selected exam ID for updates or deletions


                    ExamController examController = new ExamController();
                    var exam = examController.GetExamById(selectedExamId);
                    if (exam != null)
                    {
                        txt_exam_name.Text = exam.Name;
                        cmb_subject.SelectedValue = exam.SubjectId; // Set the selected subject
                    }
                }

            }

        }

        private void clearFields()
        {
            txt_exam_name.Clear();
            cmb_subject.SelectedIndex = -1; // Clear the selected subject
            selectedExamId = -1; // Reset the selected exam ID
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ExamController examController = new ExamController();
                string result = examController.DeleteExam(selectedExamId);
                MessageBox.Show(result);
                LoadExams();
                clearFields(); // Clear fields after deletion
            }
        }
    } 
}
