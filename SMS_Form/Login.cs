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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*'; // Set password character for the password textbox
          


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var userController = new Controller.UserController();// Create an instance of UserController
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(password.Text))// Check if either field is empty
            {
                MessageBox.Show("Please enter both Username and Password.");// Show message if either field is empty
                return;                                                     // Exit the method if fields are empty
            }
            if (userController.CheckUserName(name.Text))// Check if the username exists in the database
            {
                var user = userController.GetUserByUsername(name.Text);// Retrieve the user details by username
                if (user != null)                                      //check if user is not null
                {
                    if (user.Password == password.Text)               // Compare the entered password with the stored password
                    {
                
                        
                        Dashboard dashboardForm = new Dashboard(user.Role, user.Id);// Create a new instance of Dashboard with user role and ID

                        this.Hide(); // Just hide LoginForm
                        dashboardForm.ShowDialog(); // Show Dashboard as modal
                        this.Close(); //After Dashboard is closed, close LoginForm
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password.");// Show message if password is incorrect
                        password.Focus();                      // Set focus back to password textbox

                    }
                }
               
            }
            else
            {
                MessageBox.Show("Username does not exist.");// Show message if username does not exist
                name.Focus();                               // Set focus back to username textbox
                return;                                     // Exit the method if username does not exist
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
