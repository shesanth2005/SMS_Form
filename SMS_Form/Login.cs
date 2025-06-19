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
                
                        
                        //if (user.Role == "Student")
                        //{
                        //  StudentController studentController = new StudentController();
                        //    var student = studentController.GetStudentByUserId(user.Id);
                        //    if (student != null)
                        //    {
                                
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Student not found for the given user.");
                        //    }
                        //}
                        //else if (user.Role == "Admin")
                        //{
                           
                        //}
                        //else if (user.Role == "Staff")
                        //{
                            
                        //}
                        //else if (user.Role == "Lecturer")
                        //{
                          
                        //}

                        Dashboard dashboardForm = new Dashboard(user.Role, user.Id);

                        this.Hide(); // Just hide LoginForm
                        dashboardForm.ShowDialog(); // Show Dashboard as modal
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password.");
                        password.Focus();
                        
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Username does not exist.");
                name.Focus();
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
    }
}
