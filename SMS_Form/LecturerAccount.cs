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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SMS_Form
{
    public partial class LecturerAccount : Form
    {
        public LecturerAccount()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both Name and Password.");
                return;
            }
            if (password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            UserController userController = new UserController();

            if (userController.IsUsernameAvailable(userName.Text))
            {

                User user = new User
                {
                    Name = userName.Text,
                    Password = password.Text,
                    Role = "Lecturer"


                };

                AddLecturerForm addLecturerForm = new AddLecturerForm();
                addLecturerForm.UserId = userController.Adduser(user);
                addLecturerForm.ShowDialog();
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
