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

namespace SMS_Form
{
    public partial class TimeTable : Form
    {
        private int selectedTimetableId = -1; // To store the ID of the selected timetable for updates
        
        private string Role; // To store the role of the user (e.g., Student, Teacher, Admin, Staff)
        public TimeTable(string role)
        {
            Role = role;
            InitializeComponent();
            Loadtimes();
            Loadday();
            LoadRooms();
            LoadSubjects();
            LoadTimetables();
            if (Role == "Student")
            {
                //btn_add.Enabled = false; // Disable add button for students
                //btn_update.Enabled = false; // Disable update button for students
                //btn_delete.Enabled = false; // Disable delete button for students
                btn_add.Visible = false; // Hide add button for students
                btn_update.Visible = false;
                btn_delete.Visible = false;
               
            }
            else if (Role == "Lecturer")
            {
                btn_add.Visible = false; // Hide add button for students
                btn_update.Visible = false;
                btn_delete.Visible = false;
            }
            else if (Role == "Admin")
            {
                btn_add.Enabled = true; // Enable add button for admins
                btn_update.Enabled = true; // Enable update button for admins
                btn_delete.Enabled = true; // Enable delete button for admins
            }
            else if (Role == "Staff")
            {
                btn_add.Visible = false; // Hide add button for students
                btn_update.Visible = false;
                btn_delete.Visible = false;
            }

         
        }

        private void ClearForm()
        {
            subjectcomboBox.SelectedIndex = -1;
            comboBoxDay.SelectedIndex = -1;
            comboBoxStarttime.SelectedIndex = -1;
            comboBoxEndtime.SelectedIndex = -1;
            roomComboBox.SelectedIndex = -1;
            selectedTimetableId = -1; // Reset the selected timetable ID
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (subjectcomboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            if (comboBoxDay.SelectedItem == null)
            {
                MessageBox.Show("Please select a day.");
                return;
            }

            if (comboBoxStarttime.SelectedItem == null)
            {
                MessageBox.Show("Please select a  starting time ");
                return;
            }
            if (comboBoxEndtime.SelectedItem==null)
            {
                MessageBox.Show("Please select a  ending time ");
            }

            if (roomComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a room.");
                return;
            }
            if (comboBoxStarttime.SelectedItem.ToString() == comboBoxEndtime.SelectedItem.ToString())
            {
                MessageBox.Show("Start time and end time cannot be the same.");
                return;
            }
            if (comboBoxStarttime.SelectedIndex >= comboBoxEndtime.SelectedIndex)
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            Timetable timetable = new Timetable
            {
                SubjectId = (int)subjectcomboBox.SelectedValue,
                Day = comboBoxDay.SelectedItem.ToString(),
                StartTime = comboBoxStarttime.SelectedItem.ToString(),
                EndTime = comboBoxEndtime.SelectedItem.ToString(),
                RoomId = (int)roomComboBox.SelectedValue
            };

            TimetableController timetableController = new TimetableController();
            string result = timetableController.AddTimetable(timetable);
            MessageBox.Show(result);
            LoadTimetables();

        }

        private void Loadtimes()
        {
            comboBoxStarttime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEndtime.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] timeSlots = {
                "07:00", "07:15", "07:30", "07:45",
                "08:00", "08:15", "08:30", "08:45",
                "09:00", "09:15", "09:30", "09:45",
                "10:00", "10:15", "10:30", "10:45",
                "11:00", "11:15", "11:30", "11:45",
                "12:00", "12:15", "12:30", "12:45",
                "13:00", "13:15", "13:30", "13:45",
                "14:00", "14:15", "14:30", "14:45",
                "15:00", "15:15", "15:30", "15:45",
                "16:00", "16:15", "16:30", "16:45",
                "17:00", "17:15", "17:30", "17:45",
                "18:00", "18:15", "18:30", "18:45",
                "19:00"
            };

            comboBoxStarttime.Items.AddRange(timeSlots);
            comboBoxStarttime.SelectedIndex = 0; // Set default selection to the first time slot
            comboBoxEndtime.Items.AddRange(timeSlots);
            comboBoxEndtime.SelectedIndex = 4; // Set default selection to the first time slot


        }

        private void Loadday()
        {
            comboBoxDay.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxDay.Items.AddRange(new string[]
            {
        "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
              });

            comboBoxDay.SelectedIndex = 0;
        }

        private void LoadRooms()
        {
            roomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoomController roomController = new RoomController();
            List<Room> rooms = roomController.GetAllRooms();

            roomComboBox.DataSource = rooms;
            roomComboBox.DisplayMember = "Name";
            roomComboBox.ValueMember = "Id";
        }


        private void LoadSubjects()
        {
            subjectcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectController subjectController = new SubjectController();
            List<Model.Subject> subjects = subjectController.GetAllSubjects();
            subjectcomboBox.DataSource = subjects;

            subjectcomboBox.DisplayMember = "Name";
            subjectcomboBox.ValueMember = "Id";



        }

        private void LoadTimetables()
        {
            TimetableController timetableController = new TimetableController();
            List<Model.Timetable> timetables = timetableController.GetAllTimetables();
            TimetableView.DataSource = timetables;

            // Optional: hide internal IDs
            if (TimetableView.Columns.Contains("Id"))
            {
                TimetableView.Columns["Id"].Visible = true;
            }
            if (TimetableView.Columns.Contains("SubjectId"))
            {
                TimetableView.Columns["SubjectId"].Visible = false;
            }
            if (TimetableView.Columns.Contains("RoomId"))
            {
                TimetableView.Columns["RoomId"].Visible = false;
            }

            // Optional: auto-size and format display
            TimetableView.ClearSelection();
            TimetableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TimetableView.Columns["SubjectName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TimetableView.Columns["RoomName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void TimetableView_CellContentClick(object sender, EventArgs e)
        {
            if (TimetableView.SelectedRows.Count > 0)
            {
                var row = TimetableView.SelectedRows[0];
                var timetableView = row.DataBoundItem as Timetable;

                if (timetableView != null)
                {
                    selectedTimetableId = timetableView.Id;

                    TimetableController timetableController = new TimetableController();
                    var timetable = timetableController.GetTimetableById(selectedTimetableId);

                    if (timetable != null)
                    {
                        subjectcomboBox.SelectedValue = timetable.SubjectId;
                        comboBoxDay.SelectedItem = timetable.Day;
                        comboBoxStarttime.SelectedItem = timetable.StartTime;
                        comboBoxEndtime.SelectedItem = timetable.EndTime;
                        roomComboBox.SelectedValue = timetable.RoomId;
                    }
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable entry to update.");
                return;
            }

            if (subjectcomboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            if (comboBoxDay.SelectedItem == null)
            {
                MessageBox.Show("Please select a day.");
                return;
            }

            if (comboBoxStarttime.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }
            if (comboBoxEndtime.SelectedItem == null)
            {
                MessageBox.Show("Please select an ending time.");
                return;
            }

            if (roomComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a room.");
                return;
            }

            if (comboBoxStarttime.SelectedItem.ToString() == comboBoxEndtime.SelectedItem.ToString())
            {
                MessageBox.Show("Start time and end time cannot be the same.");
                return;
            }
            if (comboBoxStarttime.SelectedIndex >= comboBoxEndtime.SelectedIndex)
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            var timetable = new Timetable
            {
                Id = selectedTimetableId,
                SubjectId = (int)subjectcomboBox.SelectedValue,
                Day = comboBoxDay.SelectedItem.ToString(),
                StartTime = comboBoxStarttime.SelectedItem.ToString(),
                EndTime = comboBoxEndtime.SelectedItem.ToString(),
                RoomId = (int)roomComboBox.SelectedValue
            };

            TimetableController timetableController = new TimetableController();
            timetableController.UpdateTimetable(timetable);

            LoadTimetables();  // Assuming you have a method like this to refresh the grid
            ClearForm();       // Clear form after update
            MessageBox.Show("Timetable updated successfully.");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable entry to delete.");
                return;
            }

            TimetableController timetableController= new TimetableController();
            DialogResult result = MessageBox.Show("Are you sure you want to delete this timetable entry?", "Confirm Delete", MessageBoxButtons.YesNo);
            if ( result==DialogResult.Yes)
            { 
                timetableController.DeleteTimetable(selectedTimetableId);
                LoadTimetables();  // Refresh the timetable view
                ClearForm() ;
                MessageBox.Show("Timetable entry deleted successfully.");

            }
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
