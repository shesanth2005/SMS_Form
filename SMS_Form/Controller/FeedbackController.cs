using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class FeedbackController
    {

        public string AddFeedback(Model.Feedback feedback)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string AddFeedbackQuery = "INSERT INTO Feedbacks(feedback, Role) VALUES(@feedback, @role)";
                using (var insertFeedbackCommand = new System.Data.SQLite.SQLiteCommand(AddFeedbackQuery, getdbconn))
                {
                    insertFeedbackCommand.Parameters.AddWithValue("@feedback", feedback.feedback);
                    insertFeedbackCommand.Parameters.AddWithValue("@role", feedback.Role);
                    insertFeedbackCommand.ExecuteNonQuery();
                }
                return "Your feedback has been submitted successfully.";
            }
        }

        public List<Model.Feedback> GetAllFeedbacks()
        {
            List<Model.Feedback> feedbacks = new List<Model.Feedback>();
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string query = "SELECT * FROM Feedbacks";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, getdbconn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var feedback = new Model.Feedback
                            {
                                Id = reader.GetInt32(0),
                                feedback = reader.GetString(1),
                                Role = reader.GetString(2)
                            };
                            feedbacks.Add(feedback);
                        }
                    }
                }
            }
            return feedbacks;


        }

        public Feedback GetFeedbackById(int id)
        {
            using (var getdbconn = Data.DbConfig.GetConnection())
            {
                string query = "SELECT * FROM Feedbacks WHERE Id = @id";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, getdbconn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Feedback
                            {
                                Id = reader.GetInt32(0),
                                feedback = reader.GetString(1),
                                Role = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return null; // Return null if no feedback found with the given ID
        }
    }
}
