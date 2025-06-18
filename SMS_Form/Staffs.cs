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
    public partial class Staffs : Form
    {
        private int selectedStaffId = -1; // To track the selected staff for updates or deletions
        private int selectedUserId = -1; // To track the selected user ID for staff operations
        public Staffs()
        {
            InitializeComponent();
            staffrole(); // Initialize the role combo box with predefined roles
            loadstaff(); // Load staff data into the DataGridView
            clearform(); // Clear the form fields initially
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AccountStaffcs addStaffForm = new AccountStaffcs();
            addStaffForm.ShowDialog();
            loadstaff(); // Reload staff data after adding a new staff member
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff member to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(name.Text) || role_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            var staff = new Model.Staff
            {
                Id = selectedStaffId,
                Name = name.Text,
                StaffRole = role_comboBox.SelectedItem.ToString(),
                UserId = selectedUserId // Use the stored user ID for updates
            };
            var staffController = new Controller.StaffController();
            string result = staffController.UpdateStaff(staff);
            MessageBox.Show(result);
            loadstaff(); // Reload staff data after updating
            clearform(); // Clear the form fields after update

        }

      

        private void dgv_staff_CellContentClick(object sender, EventArgs e)
        {
            if (dgv_staff.SelectedRows.Count > 0)
            {
                var selectedRow = dgv_staff.SelectedRows[0];
                var staffview = selectedRow.DataBoundItem as Model.Staff;
                if (staffview != null)
                {
                    selectedStaffId = staffview.Id; // Store the selected staff ID for updates or deletions
                    selectedUserId = staffview.UserId; // Store the selected user ID for staff operations
                    name.Enabled = true; // Enable the name text box for editing
                    role_comboBox.Enabled = true; // Enable the role combo box for editing

                    Controller.StaffController staffController = new Controller.StaffController();
                    var staff = staffController.GetStaffbyid(selectedStaffId);
                    if (staff != null)
                    {
                        name.Text = staff.Name; // Display the selected staff's name in the text box
                        role_comboBox.SelectedItem = staff.StaffRole; // Set the selected staff's role in the combo box

                    }
                }

            }

        }

        private void staffrole()
        {
            role_comboBox.DataSource = new List<string>
            {
                  "Manager",
                  "Exam Coordinator",
                  "Academic Assistant",
                  "Timetable Officer",
                  "Data Entry Staff",
                  "Records Clerk",
                  "Marks Entry Operator",
                  "IT Support",
                  "Academic Office Staff"
            };

            role_comboBox.SelectedIndex = 0; // Set no selection initially




        }

        private void loadstaff()
        {
            Controller.StaffController staffController = new Controller.StaffController();
            List<Model.Staff> staffs = staffController.GetAllStaff();
            dgv_staff.DataSource = staffs;

            dgv_staff.Columns["Name"].HeaderText = "Staff Name"; // Rename column header
            dgv_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void clearform()
        {
            name.Clear(); // Clear the name text box
            role_comboBox.SelectedIndex = -1; // Reset the role combo box selection
            selectedStaffId = -1; // Reset the selected staff ID
            selectedUserId = -1; // Reset the selected user ID}
            name.Enabled = false; // Disable the name text box
            role_comboBox.Enabled = false; // Disable the role combo box
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1 && selectedUserId==-1)
            {
                MessageBox.Show("Please select a staff member to delete.");
                return;
            }
            var staffController = new Controller.StaffController();
            var userController = new Controller.UserController();
            var confirmResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Proceed with deletion
                string result = staffController.DeleteStaff(selectedStaffId);
                //MessageBox.Show($"Deleting user with ID: {selectedUserId}");

                userController.DeleteUser(selectedUserId); // Delete the associated user account

                loadstaff(); // Reload staff data after deletion
                clearform(); // Clear the form fields after deletion
                MessageBox.Show(result); // Show the result of the deletion operation
            }
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void role_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staffs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
