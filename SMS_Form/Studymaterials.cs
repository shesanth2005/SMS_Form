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
    public partial class Studymaterials : Form
    {
        private int selectedStudyMaterialId = -1; // Variable to store the selected study material ID
        private string role;
        public Studymaterials(string Role)
        {
            role = Role;
            InitializeComponent();
            loadstudymaterials();
            if (role == "Student")
            {
               btn_add.Visible = false;
               btn_update.Visible = false;
               button1.Visible = false;
               name.ReadOnly = true;
               link.ReadOnly = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStudyMaterialId == -1)
            {
                MessageBox.Show("Please select a study material to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(link.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            StudymaterialController studymaterialController = new StudymaterialController();
            Model.Studymaterial studymaterial = new Model.Studymaterial
            {
                Id = selectedStudyMaterialId, // Set the ID of the study material to update
                Name = name.Text,
                Link = link.Text
            };
            string result = studymaterialController.updateStudyMaterial(studymaterial);
            MessageBox.Show(result);
            clearForm();
            loadstudymaterials();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(link.Text) )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            StudymaterialController studymaterialController = new StudymaterialController();
            Model.Studymaterial studymaterial = new Model.Studymaterial
            {
                Name = name.Text,
                Link = link.Text
            };
            string result = studymaterialController.addStudyMaterial(studymaterial);
            MessageBox.Show(result);
            
            clearForm();
            loadstudymaterials();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedStudyMaterialId == -1)
            {
                MessageBox.Show("Please select a study material to delete.");
                return;
            }
            StudymaterialController studymaterialController = new StudymaterialController();
            string result = studymaterialController.deleteStudyMaterial(selectedStudyMaterialId);
            MessageBox.Show(result);
            clearForm();
            loadstudymaterials();
        }

        private void loadstudymaterials()
        {
            StudymaterialController studymaterialController = new StudymaterialController();
            List<Model.Studymaterial> studymaterials = studymaterialController.getAllStudyMaterials();
            dgv_studymaterial.DataSource = studymaterials;

            dgv_studymaterial.Columns["Id"].Visible = false; // Hide the Id column
            dgv_studymaterial.Columns["Name"].HeaderText = "Study Material Name"; // Rename the Name column header
            dgv_studymaterial.Columns["Link"].HeaderText = "Study Material Link"; // Rename the Link column header
            dgv_studymaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void clearForm()
        {
            name.Clear();
            link.Clear();
            selectedStudyMaterialId = -1; // Reset the selected study material ID
       
        }

        private void dgv_studymaterial_CellContentClick(object sender, EventArgs e)
        {
            if(dgv_studymaterial.SelectedRows.Count>0)
            {
                var row = dgv_studymaterial.SelectedRows[0];
                var studyMaterialview = row.DataBoundItem as Model.Studymaterial;
                if (studyMaterialview != null)
                {
                    selectedStudyMaterialId = studyMaterialview.Id; // Store the selected study material ID
                   


                    StudymaterialController studymaterialController = new StudymaterialController();
                    var studymaterial = studymaterialController.getStudyMaterialById(selectedStudyMaterialId);
                    if (studymaterial != null)
                    {
                        name.Text = studymaterial.Name;
                        link.Text = studymaterial.Link;
                    }
                   
                }


            }
        }
    }
}
