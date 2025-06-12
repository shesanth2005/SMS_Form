using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS_Form.Controller;
using SMS_Form.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMS_Form
{
    public partial class RoomForm : Form
    {
        private int selectedRoomId = -1;

        public RoomForm()
        {
            InitializeComponent();
            LoadRoomType();
            LoadRooms();
        }

        private void ClearForm()
        {
            name.Clear();
            type_comboBox.SelectedIndex = 0;
            selectedRoomId = -1;
        }


        private void btn_add_room_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Please enter the Room Name.");
                return;
            }

            if (type_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the Room Type.");
                return;
            }

            string selectedRoomType = type_comboBox.SelectedItem.ToString();

            Model.Room room = new Model.Room
            {
                Name = name.Text,
                Type = selectedRoomType
            };

            RoomController roomController = new RoomController();
            string resultMessage = roomController.AddRoom(room);
            MessageBox.Show(resultMessage);
            LoadRooms();
            ClearForm();

          
        }

        private void LoadRoomType()
        {
            type_comboBox.Items.Clear();
            type_comboBox.Items.Add("Lab");
            type_comboBox.Items.Add("Hall");
            type_comboBox.SelectedIndex = 0; // Default to Lab
        }

        private void LoadRooms()
        {
            RoomController roomController = new RoomController();
            List<Model.Room> rooms = roomController.GetAllRooms();

            RoomView.DataSource = rooms;

            RoomView.ClearSelection();
            RoomView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Make sure columns resize nicely
            //RoomView.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //RoomView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //RoomView.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
          

        }

        private void RoomView_CellContentClick(object sender, EventArgs e)
        {
            if (RoomView.SelectedRows.Count > 0)
            {
                var row = RoomView.SelectedRows[0];
                var roomView = row.DataBoundItem as Room;

                if (roomView != null)
                {
                    selectedRoomId = roomView.Id;

                    RoomController roomController = new RoomController();
                    var room = roomController.GetRoomById(selectedRoomId);

                    if (room != null)
                    {
                        name.Text = room.Name;

                        type_comboBox.SelectedItem = room.Type;


                    }
                }
            }



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name.Text) || type_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter Room Name and select a Room Type.");
                return;
            }

            var room = new Room
            {
                Id = selectedRoomId,
                Name = name.Text,
                Type = type_comboBox.SelectedItem.ToString() // "Lab" or "Hall"
            };

            RoomController roomController = new RoomController();
            roomController.UpdateRoom(room);
            LoadRooms(); // Your method to reload the DataGridView
            ClearForm(); // Clears the input fields
            MessageBox.Show("Room Updated Successfully");


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            RoomController roomController = new RoomController();
            var confirmResult = MessageBox.Show("Are you sure to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                roomController.DeleteRoom(selectedRoomId);
                LoadRooms();    // Refresh DataGridView or UI list
                ClearForm();    // Clear input fields and reset selectedRoomId
                MessageBox.Show("Room Deleted Successfully");
            }

        }
    }
}
