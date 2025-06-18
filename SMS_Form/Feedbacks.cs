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
    public partial class Feedbacks : Form
    {
        private int selectedFeedbackId = -1; // To track the selected feedback for updates or deletions
        private string userRole; // To store the role of the user
        public Feedbacks(string role)
        {
            userRole = role; // Initialize the user role
            InitializeComponent();
            if (userRole == "Student")
            {
                dgv_feedback.Visible = false; // Hide the DataGridView for students
            }
            else if (userRole == "Admin" || userRole == "Staff" || userRole == "Lecturer")
            {
                LoadFeedbacks(); // Load feedbacks for Admin, Staff, or Lecturer
                txt_feedback.Enabled = false; // Disable the feedback text box for Admin, Staff, or Lecturer
                btn_submit.Enabled = false; // Disable the submit button for Admin, Staff, or Lecturer
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(txt_feedback.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your feedback.");
                return;
            }

            var feedback = new Model.Feedback
            {
                feedback = txt_feedback.Text.Trim(),
                Role = "Student"
            };

            FeedbackController feedbackController = new FeedbackController();
            var result = feedbackController.AddFeedback(feedback);
            MessageBox.Show(result);
        }

        private void LoadFeedbacks()
        {
            FeedbackController feedbackController = new FeedbackController();
            var feedbacks = feedbackController.GetAllFeedbacks(); // Assuming this method exists in FeedbackController
            dgv_feedback.DataSource = feedbacks;
             
            dgv_feedback.Columns["feedback"].HeaderText = "Feedback"; // Rename the feedback column header
            dgv_feedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_feedback_CellContentClick(object sender, EventArgs e)
        {
            if (dgv_feedback.SelectedRows.Count > 0)
            {

                var row = dgv_feedback.SelectedRows[0];
                var selectedFeedback = row.DataBoundItem as Feedback;

                if (selectedFeedback != null)
                {
                    selectedFeedbackId = selectedFeedback.Id; // Store the selected feedback ID
                    var feedbackController = new FeedbackController();
                    var feedback = feedbackController.GetFeedbackById(selectedFeedbackId); // Assuming this method exists in FeedbackController
                    if (feedback != null)
                    {
                        txt_feedback.Text = feedback.feedback; // Display the selected feedback in the text box
                    }

                }
            } 

        }
    }
}
