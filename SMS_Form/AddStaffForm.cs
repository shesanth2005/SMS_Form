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
    public partial class AddStaffForm : Form
    {
        public int UserId { get; set; }
        public AddStaffForm()
        {
            InitializeComponent();
            staffrole(); // Initialize the role combo box with predefined roles
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name.Text)  || role_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var staff = new Model.Staff
            {
                Name = name.Text,
                StaffRole = role_comboBox.SelectedItem.ToString(),
                UserId = UserId
            };

            var staffController = new Controller.StaffController();
            string result = staffController.AddStaff(staff);
            MessageBox.Show(result);
            this.Close();

        }

        private void staffrole()
        {
            role_comboBox.DataSource = new List<string>
            {
                  "Manager",
                  "Exam Coordinator",
                  "Academic Assistant",
                  "Timetable Officer",
                  "Data Entry Staff",
                  "Records Clerk",
                  "Marks Entry Operator",
                  "IT Support",
                  "Academic Office Staff"
            };

            role_comboBox.SelectedIndex = 0; // Set no selection initially




        }
    }
}
