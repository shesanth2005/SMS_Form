using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Form.Data;
using SMS_Form.Model;

namespace SMS_Form.Controller
{
    internal class RoomController
    {
        public string AddRoom(Model.Room room)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string addRoomQuery = "INSERT INTO Rooms(RoomName, RoomType) VALUES (@roomName, @roomType)";

                SQLiteCommand insertRoomCommand = new SQLiteCommand(addRoomQuery, getdbconn);
                insertRoomCommand.Parameters.AddWithValue("@roomName", room.Name);
                insertRoomCommand.Parameters.AddWithValue("@roomType", room.Type);

                insertRoomCommand.ExecuteNonQuery();
                return "Room Added Successfully";
            }
        }


        public List<Model.Room> GetAllRooms()
        {
            List<Model.Room> rooms = new List<Model.Room>();

            string getRoomsQuery = @"
                                    SELECT Id, RoomName, RoomType
                                    FROM Rooms";

            using (var conn = DbConfig.GetConnection())
            {
                SQLiteCommand getRoomsCommand = new SQLiteCommand(getRoomsQuery, conn);
                var reader = getRoomsCommand.ExecuteReader();

                while (reader.Read())
                {
                    Model.Room room = new Model.Room();
                    room.Id = reader.GetInt32(0);             // Id
                    room.Name = reader.GetString(1);      // RoomName
                    room.Type = reader.GetString(2);      // RoomType (Lab or Hall as string)

                    rooms.Add(room);
                }
            }

            return rooms;
        }

        public Model.Room GetRoomById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT Id, RoomName, RoomType FROM Rooms WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Model.Room room = new Model.Room();
                        room.Id = reader.GetInt32(0);          // Id
                        room.Name = reader.GetString(1);       // RoomName -> Name
                        room.Type = reader.GetString(2);       // RoomType -> Type
                        return room;
                    }
                }
            }

            return null; // Room with given id not found
        }

        public void UpdateRoom(Room room)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand(
                    "UPDATE Rooms SET RoomName = @Name, RoomType = @Type WHERE Id = @Id", conn);

                command.Parameters.AddWithValue("@Name", room.Name);
                command.Parameters.AddWithValue("@Type", room.Type); // e.g. "Lab" or "Hall"
                command.Parameters.AddWithValue("@Id", room.Id);

                command.ExecuteNonQuery();
            }
        }


        public void DeleteRoom(int roomId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Rooms WHERE Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", roomId);
                command.ExecuteNonQuery();
            }
        }





    }
}
