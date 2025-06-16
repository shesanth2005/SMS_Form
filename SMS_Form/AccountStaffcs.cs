using SMS_Form.Controller;
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
    public partial class AccountStaffcs : Form
    {
        public AccountStaffcs()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both Name and Password.");
                return;
            }
            if (password.Text.Length<8)
            { 
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            UserController userController = new UserController();
            if (userController.IsUsernameAvailable(name.Text))
            {
                Model.User user = new Model.User
                {
                    Name = name.Text,
                    Password = password.Text,
                    Role = "Staff"
                };
                AddStaffForm addStaffForm = new AddStaffForm();
                addStaffForm.UserId = userController.Adduser(user);
                addStaffForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Username already exists
                MessageBox.Show("Username already exists");
                return;
            }
        }
    }
}
