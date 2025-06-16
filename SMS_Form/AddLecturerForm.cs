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
    public partial class AddLecturerForm : Form
    {
        public int UserId { get; set; }
        public AddLecturerForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(telephone.Text))
            {
                MessageBox.Show("Please enter Name, Address, and Telephone.");
                return;
            }
            if (!long.TryParse(telephone.Text, out long num))
            {
                MessageBox.Show("Please enter a valid telephone number.");
                return;
            }
            


            Model.Lecturer lecturer = new Model.Lecturer
            {
                Name = name.Text,
                Address = address.Text,
                Telephone = telephone.Text,
                UserId = this.UserId  // Optional, if you're tracking user who added
            };

            LecturerController teacherController = new LecturerController();
            string getMessage = teacherController.AddLecturer(lecturer);
            MessageBox.Show(getMessage);

            this.Close();


        }
    }
}
