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
    public partial class Users : Form
    {
        private int selectedUserId = -1; // To track the selected user for updates or deletions
        public Users()
        {
            InitializeComponent();
            loadusers(); // Load users into the DataGridView when the form is initialized
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text) || cmb_role.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Controller.UserController userController = new Controller.UserController();
            Model.User newUser = new Model.User
            {
                Name = txt_username.Text,
                Password = txt_password.Text,
                Role = cmb_role.SelectedItem.ToString()
            };
            int userId = userController.Adduser(newUser);
            if (userId > 0)
            {
                MessageBox.Show("User added successfully.");
                loadusers(); // Reload users after adding a new user
                clearForm(); // Clear the form fields after adding
            }
            else
            {
                MessageBox.Show("Failed to add user.");
            }

        }

        private void dgv_admin_CellContentClick(object sender, EventArgs e)
        {
           
        }


        private void loadusers()
        {
            Controller.UserController userController = new Controller.UserController();
            var users = userController.GetAllUsers();
            dgv_admin.DataSource = users;
        }

        private void clearForm()
        {
            txt_username.Clear();
            txt_password.Clear();
            cmb_role.SelectedIndex = -1; // Reset the role combo box
            selectedUserId = -1; // Reset the selected user ID
        }
    }
}
