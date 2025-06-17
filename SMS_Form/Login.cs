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
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var userController = new Controller.UserController();
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }
            if (userController.CheckUserName(name.Text))
            {
                var user = userController.GetUserByUsername(name.Text);
                if (user != null)
                {
                    if (user.Password == password.Text)
                    {
                        // Login successful, redirect to the main form based on user role
                        //if (user.Role == "Admin")
                        //{
                        //    Dashboard admindashboardForm = new Dashboard();
                        //    admindashboardForm.Role = "Admin"; // Set the role for the dashboard
                        //    admindashboardForm.Show();
                        //}
                        //else if (user.Role == "Staff")
                        //{
                        //    Dashboard staffdashboardForm = new Dashboard();
                        //    staffdashboardForm.Role = "Staff"; // Set the role for the dashboard
                        //    staffdashboardForm.Show();
                        //}
                        //else if (user.Role == "Student")
                        //{
                        //    Dashboard studentdashboardForm = new Dashboard();
                        //    studentdashboardForm.Role = "Student"; // Set the role for the dashboard
                        //    studentdashboardForm.Show();
                        //}
                        //else if (user.Role == "Lecturer")
                        //{
                        //    Dashboard lecturerdashboardForm = new Dashboard();
                        //    lecturerdashboardForm.Role = "Lecturer"; // Set the role for the dashboard
                        //    lecturerdashboardForm.Show();
                        //}
                        Dashboard dashboardForm = new Dashboard();
                        dashboardForm.Role = user.Role; // Set the role for the dashboard
                        dashboardForm.Show();
                        this.Close(); // Hide the login form
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password.");
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Username does not exist.");
                return;
            }
        }
    }
}
