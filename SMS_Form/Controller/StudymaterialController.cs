using SMS_Form.Data;
using SMS_Form.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Form.Controller
{
    internal class StudymaterialController
    {
        public string addStudyMaterial(Studymaterial studymaterial)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string addStudyMaterialQuery = "INSERT INTO Studymaterials(Name, Link) VALUES(@name, @link)";
                using (var insertCommand = new SQLiteCommand(addStudyMaterialQuery, getdbconn))
                {
                    insertCommand.Parameters.AddWithValue("@name",studymaterial.Name );
                    insertCommand.Parameters.AddWithValue("@link", studymaterial.Link);
                    insertCommand.ExecuteNonQuery();
                }
            }

            return $"Study material added successfully.";
        }

        public string deleteStudyMaterial(int id)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string deleteStudyMaterialQuery = "DELETE FROM Studymaterials WHERE Id = @id";
                using (var deleteCommand = new SQLiteCommand(deleteStudyMaterialQuery, getdbconn))
                {
                    deleteCommand.Parameters.AddWithValue("@id", id);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return $"Study material deleted successfully.";
                    }
                    else
                    {
                        return $"No study material found.";
                    }
                }
            }
        }

        public List<Model.Studymaterial> getAllStudyMaterials()
        {
            List<Model.Studymaterial> studyMaterials = new List<Model.Studymaterial>();
            string getStudyMaterialsQuery = "SELECT Id, Name, Link FROM Studymaterials";
            using (var conn = DbConfig.GetConnection())
            {
                using (var getCommand = new SQLiteCommand(getStudyMaterialsQuery, conn))
                {
                    using (var reader = getCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Model.Studymaterial studyMaterial = new Model.Studymaterial
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Link = reader.GetString(2)
                            };
                            studyMaterials.Add(studyMaterial);
                        }
                    }
                }
            }
            return studyMaterials;
        }

        public Model.Studymaterial getStudyMaterialById(int id)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string getStudyMaterialQuery = "SELECT Id, Name, Link FROM Studymaterials WHERE Id = @id";
                using (var cmd = new SQLiteCommand(getStudyMaterialQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Model.Studymaterial
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Link = reader.GetString(2)
                            };
                        }
                        else
                        {
                            return null; // No study material found with the given ID
                        }
                    }
                }
            }
        }

        public string updateStudyMaterial(Studymaterial studymaterial)
        {
            using (var getdbconn = DbConfig.GetConnection())
            {
                string updateStudyMaterialQuery = "UPDATE Studymaterials SET Name = @name, Link = @link WHERE Id = @id";
                using (var updateCommand = new SQLiteCommand(updateStudyMaterialQuery, getdbconn))
                {
                    updateCommand.Parameters.AddWithValue("@id", studymaterial.Id );
                    updateCommand.Parameters.AddWithValue("@name", studymaterial.Name);
                    updateCommand.Parameters.AddWithValue("@link", studymaterial.Link);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return $"Study material updated successfully.";
                    }
                    else
                    {
                        return $"No study material found with ID .";
                    }
                }
            }
        }
    }
}
