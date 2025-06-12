using SMS_Form.Controller;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SMS_Form.Model
{
    public partial class StudentAccount : Form
    {
        

        public StudentAccount()
        {
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }
            
            UserController userController = new UserController();

            if (userController.IsUsernameAvailable(userName.Text))
            {

                User user = new User
                {
                    Name = userName.Text,
                    Password = password.Text,
                    Role = "Student"


                };

                AddStudentForm addStudentForm = new AddStudentForm();
                addStudentForm.UserId = userController.Adduser(user);
                addStudentForm.ShowDialog();
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
