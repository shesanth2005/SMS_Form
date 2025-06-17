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
    public partial class Users : Form
    {
        private int selectedUserId = -1; // To track the selected user for updates or deletions
       
        public Users()
        {
            InitializeComponent();
            loadusers(); // Load users into the DataGridView when the form is initialized
            LoadRoles(); // Load roles into the combo box
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(password.Text) || role_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            

        }

        private void dgv_admin_CellContentClick(object sender, EventArgs e)
        {
            if(dgv_admin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_admin.SelectedRows[0];
                var userview=selectedRow.DataBoundItem as Model.User;
                if (userview != null)
                {
                    selectedUserId = userview.Id; // Store the selected user ID for updates or deletions
                    var userController = new Controller.UserController();
                    var user = userController.GetuserbyID(selectedUserId);
                    if (user != null)
                    {
                        name.Text = user.Name;
                        password.Text = user.Password;
                        role_comboBox.SelectedItem = user.Role; // Set the selected role in the combo box
                        role_comboBox.Enabled = false; // Disable the role combo box for editing
                    }

                }
            }

        }


        private void loadusers()
        {
            Controller.UserController userController = new Controller.UserController();
            var users = userController.GetAllUsers();
            dgv_admin.DataSource = users;
        }

        private void clearForm()
        {
            name.Clear();
            password.Clear();
            role_comboBox.SelectedIndex = -1; // Reset the role combo box
            selectedUserId = -1; // Reset the selected user ID
           
        }

        private void LoadRoles()
        {
            role_comboBox.DataSource = new List<string> { "Admin","Staff","Student","Lecturer"}; // Populate the role combo box with options
            role_comboBox.SelectedIndex = 0; // Reset the selected index
        }

        private void btn_savechange_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(password.Text) || role_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            var userController = new Controller.UserController();
            var currentUser = userController.GetuserbyID(selectedUserId);

            if (currentUser == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            bool usernameChanged = currentUser.Name != name.Text;
            bool passwordChanged = currentUser.Password != password.Text;
            bool roleChanged = currentUser.Role != role_comboBox.SelectedItem.ToString();

            if (!usernameChanged && !passwordChanged && !roleChanged)
            {
                MessageBox.Show("No changes made.");
                return;
            }

            // Check username availability only if username changed
            if (usernameChanged && !userController.IsUsernameAvailable(name.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            // Password validation only if changed
            if (passwordChanged && password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            var updatedUser = new Model.User
            {
                Id = selectedUserId,
                Name = name.Text,
                Password = password.Text,
                Role = role_comboBox.SelectedItem.ToString()
            };

            userController.UpdateUser(updatedUser);

            MessageBox.Show("User updated successfully.");
            loadusers();
            clearForm();




        }
 

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }
            if (role_comboBox.SelectedItem == "Student")
            {
                StudentController studentController = new StudentController();
                if (studentController.CheckUserId(selectedUserId))
                {
                    MessageBox.Show("This user is associated with a student record and cannot be deleted.");
                    return;
                }
            }
            if (role_comboBox.SelectedItem == "Lecturer")
            {
                LecturerController lecturerController = new LecturerController();
                if (lecturerController.CheckUserId(selectedUserId))
                {
                    MessageBox.Show("This user is associated with a lecturer record and cannot be deleted.");
                    return;
                }
            }
            if (role_comboBox.SelectedItem == "Staff")
            {
                StaffController staffController = new StaffController();
                if (staffController.CheckUserId(selectedUserId))
                {
                    MessageBox.Show("This user is associated with a staff record and cannot be deleted.");
                    return;
                }
            }


            var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var userController = new Controller.UserController();
                userController.DeleteUser(selectedUserId);
                MessageBox.Show("User deleted successfully.");
                clearForm(); // Clear the form after deletion
                loadusers(); // Reload the users in the DataGridView
            }
        }
    }
}
