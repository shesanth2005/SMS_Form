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
    public partial class AccountDashboard : Form
    {
        private string userRole; // To store the role of the user
        private int userId; // To store the user ID
        public AccountDashboard(string role,int uid)
        {
            userRole = role; // Initialize the user role
            userId = uid; // Initialize the user ID
            InitializeComponent();
            var usercontroller = new Controller.UserController();
            var user = usercontroller.GetuserbyID(userId); // Assuming this method exists in UserController
            if (user != null)
            {
                name.Text = user.Name;

                text_role.Text = user.Role;
            }
            if (role =="Student")
            {
                var studentController = new Controller.StudentController();
                var student = studentController.GetStudentByUserId(userId); // Assuming this method exists in StudentController
                if (student != null)
                {
                   realname.Text = student.Name;
                }

            }
            else if (role == "Lecturer")
            {
                var lecturerController = new Controller.LecturerController();
                var lecturer = lecturerController.GetLecturersByUserId(userId); // Assuming this method exists in LecturerController
                if (lecturer != null)
                {
                    realname.Text = lecturer.Name;
                }
            }
            else if (role == "Staff")
            {
                var staffController = new Controller.StaffController();
                var staff = staffController.GetStaffByUserId(userId); // Assuming this method exists in StaffController
                if (staff != null)
                {
                    realname.Text = staff.Name;
                }
            }
            else if (role == "Admin")
            {
                realname.Text = "Admin"; // Assuming Admin has no specific user details
            }
            realname.ReadOnly = true; // Make the real name field read-only
            name.ReadOnly = true; // Make the name field read-only
            text_role.ReadOnly = true; // Make the role field read-only
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
