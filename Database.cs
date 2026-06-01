using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestor_de_Expedicions_Espacials
{
    public class Database
    {
        private string connectionString = "server=localhost;port=3307;database=expedicions;user=iot;password=iot";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // ---------------------- MÉTODOS PARA NAU_ESPACIAL ----------------------

        // Obtener todas las naves espaciales
        public DataTable ObtenirNaus()
        {
            using (var conn = GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    string query = "SELECT id, nom, model, capacitat FROM nau_espacial";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No spacecraft were found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting spaceships: " + ex.Message);
                }
                return dt;
            }
        }

        // Añadir una nueva nave espacial
        public void AfegirNau(string nom, string model, int capacitat)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO nau_espacial (nom, model, capacitat) VALUES (@nom, @model, @capacitat)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@capacitat", capacitat);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Spaceship added successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding spaceship: " + ex.Message);
                }
            }
        }

        // Modificar una nave espacial existente
        public void ModificarNau(int id, string nom, string model, int capacitat)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE nau_espacial SET nom = @nom, model = @model, capacitat = @capacitat WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@capacitat", capacitat);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Spaceship modified successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error modifying the spaceship: " + ex.Message);
                }
            }
        }

        // Eliminar una nave espacial
        public void EliminarNau(int id)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM nau_espacial WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Spaceship successfully eliminated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting spaceship: " + ex.Message);
                }
            }
        }

        // Obtener expediciones
        public DataTable ObtenirExpedicions()
        {
            using (var conn = GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    string query = "SELECT id, desti, data_sortida, duracio, nau_id FROM expedicio";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No expeditions found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting expeditions: " + ex.Message);
                }
                return dt;
            }
        }

        // Añadir una expedición
        public void AfegirExpedicio(string desti, DateTime dataSortida, int duracio, int nauId)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO expedicio (desti, data_sortida, duracio, nau_id) VALUES (@desti, @data, @duracio, @nau)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@desti", desti);
                        cmd.Parameters.AddWithValue("@data", dataSortida);
                        cmd.Parameters.AddWithValue("@duracio", duracio);
                        cmd.Parameters.AddWithValue("@nau", nauId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Expedition added successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding expedition: " + ex.Message);
                }
            }
        }

        // Modificar expedición
        public void ModificarExpedicio(int id, string desti, DateTime dataSortida, int duracio, int nauId)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE expedicio SET desti = @desti, data_sortida = @data, duracio = @duracio, nau_id = @nau WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@desti", desti);
                        cmd.Parameters.AddWithValue("@data", dataSortida);
                        cmd.Parameters.AddWithValue("@duracio", duracio);
                        cmd.Parameters.AddWithValue("@nau", nauId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Expedition modified successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error modifying shipment: " + ex.Message);
                }
            }
        }

        // Eliminar expedición
        public void EliminarExpedicio(int id)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM expedicio WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Expedition successfully deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when deleting expedition: " + ex.Message);
                }
            }
        }

        // Obtener todos los astronautas
        public DataTable ObtenirAstronautes()
        {
            using (var conn = GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    string query = "SELECT id, nom, edat, especialitat FROM astronauta";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No astronaut records found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting astronauts: " + ex.Message);
                }
                return dt;
            }
        }

        // Añadir un nuevo astronauta
        public void AfegirAstronauta(string nom, int edat, string especialitat)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO astronauta (nom, edat, especialitat) VALUES (@nom, @edat, @especialitat)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@edat", edat);
                        cmd.Parameters.AddWithValue("@especialitat", especialitat);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Astronaut added successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding astronaut: " + ex.Message);
                }
            }
        }

        // Modificar un astronauta existente
        public void ModificarAstronauta(int id, string nom, int edat, string especialitat)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE astronauta SET nom = @nom, edat = @edat, especialitat = @especialitat WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@edat", edat);
                        cmd.Parameters.AddWithValue("@especialitat", especialitat);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Astronaut modified successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error modifying astronaut: " + ex.Message);
                }
            }
        }

        // Eliminar un astronauta
        public void EliminarAstronauta(int id)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM astronauta WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Astronaut successfully eliminated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting astronaut: " + ex.Message);
                }
            }
        }
    }
}
