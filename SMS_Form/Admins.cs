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
    public partial class Admins : Form
    {
        public Admins()
        {
            InitializeComponent();
            loadadmin(); // Load admin users into the DataGridView when the form is initialized
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both Name and Password.");
                return;
            }
            var userController = new Controller.UserController();   
            if(userController.IsUsernameAvailable(name.Text))
            {
                if (password.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.");
                    return;
                }
                Model.User user = new Model.User
                {
                    Name = name.Text,
                    Password = password.Text,
                    Role = "Admin"
                };
                int userId = userController.Adduser(user);
                if (userId > 0)
                {
                    MessageBox.Show("Admin created successfully.");
                    loadadmin(); // Reload the admin list after adding a new admin
                    name.Clear();
                    password.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to create admin. Please try again.");
                }
            }
            else
            {
                // Username already exists
                MessageBox.Show("Username already exists");
            }

        }

        private void loadadmin()
        {
            Controller.UserController userController = new Controller.UserController();
            List<Model.User> users = userController.GetAdmins();
            dgv_admin.DataSource = users;
            
            dgv_admin.Columns["Id"].HeaderText = "UserId"; // Rename Id column header
            dgv_admin.Columns["Password"].Visible = true; // Hide the Password column
            dgv_admin.Columns["Role"].Visible = false; // Rename Role column header
            dgv_admin.Columns["Name"].HeaderText = "UserName"; // Rename Name column header
            dgv_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
