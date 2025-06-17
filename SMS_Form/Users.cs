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
    }
}
