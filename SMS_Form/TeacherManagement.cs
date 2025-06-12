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
    public partial class TeacherManagement : Form
    {
        private int selectedLecturerId = -1;
        private int selectedUserId = -1; // Reuse if user logic is shared

        public TeacherManagement()
        {
            InitializeComponent();
            LoadLecturers();
            ClearLecturerForm();
        }
        private void ClearLecturerForm()
        {
            name.Clear();
            address.Clear();
            telephone.Clear(); // Clear telephone field

            selectedLecturerId = -1;
            selectedUserId = -1;

            name.Enabled = false;
            address.Enabled = false;
            telephone.Enabled = false;
        }



        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            LecturerAccount account = new LecturerAccount();
            account.ShowDialog();
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
            if (LecturerView.Columns.Contains("Telephone"))
            {
                LecturerView.Columns["Telephone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void btn_update_teach_Click(object sender, EventArgs e)
        {
       
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(telephone.Text))
            {
                MessageBox.Show("Please enter Name, Address, and Telephone.");
                return;
            }

            var lecturer = new Lecturer
            {
                Id = selectedLecturerId,
                Name = name.Text.Trim(),
                Address = address.Text.Trim(),
                Telephone = telephone.Text.Trim(),
                UserId = selectedUserId  // optional if you track user
            };

            LecturerController lecturerController = new LecturerController();
            lecturerController.UpdateLecturer(lecturer);

            LoadLecturers();  // Your method to refresh lecturer list
            ClearLecturerForm();  // Clear input fields

            MessageBox.Show("Lecturer Updated Successfully");
        


        }

        private void LecturerView_CellContentClick(object sender, EventArgs e)
        {
            if (LecturerView.SelectedRows.Count > 0)
            {
                var row = LecturerView.SelectedRows[0];
                var lecturerView = row.DataBoundItem as Lecturer;

                if (lecturerView != null)
                {
                    selectedLecturerId = lecturerView.Id;
                    selectedUserId = lecturerView.UserId;

                    name.Enabled = true;
                    address.Enabled = true;
                    telephone.Enabled = true;

                    LecturerController lecturerController = new LecturerController();
                    var lecturer = lecturerController.GetLecturerById(selectedLecturerId);
                    if (lecturer != null)
                    {
                        name.Text = lecturer.Name;
                        address.Text = lecturer.Address;
                        telephone.Text = lecturer.Telephone;
                    }
                }
            }

        }

        private void btn_delete_teach_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                LecturerController lecturerController = new LecturerController();
                UserController userController = new UserController();

                lecturerController.DeleteLecturer(selectedLecturerId);
                userController.DeleteUser(selectedUserId);

                LoadLecturers();  // Refresh lecturer list
                ClearLecturerForm();  // Clear form inputs

                MessageBox.Show("Lecturer Deleted Successfully");
            }
        }
    }
}
