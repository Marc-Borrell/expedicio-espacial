using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestor_de_Expedicions_Espacials
{
    public partial class FormAstronautas : Form
    {
        private Database db = new Database();

        
        private int astronautaSeleccionado = -1;
        private string nombreOriginal = string.Empty;
        private string edadOriginal = string.Empty;
        private string especialidadOriginal = string.Empty;

        public FormAstronautas()
        {
            InitializeComponent();
           
            this.Load += FormAstronautas_Load;

           
            dataGridViewAstronautas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAstronautas.MultiSelect = false;
            dataGridViewAstronautas.ReadOnly = true;
            dataGridViewAstronautas.AllowUserToAddRows = false;
            dataGridViewAstronautas.SelectionChanged += DataGridViewAstronautas_SelectionChanged;
        }

        private void FormAstronautas_Load(object sender, EventArgs e)
        {
            CargarAstronautas();
            LimpiarCampos();
        }
        private void CargarAstronautas()
        {
            try
            {
                DataTable dt = db.ObtenirAstronautes();
                dataGridViewAstronautas.DataSource = dt;
                dataGridViewAstronautas.Refresh();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay astronautas registrados.");
                }
                else
                {
                    if (dt.Columns.Contains("id"))
                        dataGridViewAstronautas.Columns["id"].HeaderText = "ID";
                    if (dt.Columns.Contains("nom"))
                        dataGridViewAstronautas.Columns["nom"].HeaderText = "Name";
                    if (dt.Columns.Contains("edat"))
                        dataGridViewAstronautas.Columns["edat"].HeaderText = "Age";
                    if (dt.Columns.Contains("especialitat"))
                        dataGridViewAstronautas.Columns["especialitat"].HeaderText = "Speciality";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading astronauts: " + ex.Message);
            }
        }

        
        private void LimpiarCampos()
        {
            textBoxNom.Text = string.Empty;
            textBoxEdat.Text = string.Empty;
            textBoxEspecialitat.Text = string.Empty;
            astronautaSeleccionado = -1;
            nombreOriginal = string.Empty;
            edadOriginal = string.Empty;
            especialidadOriginal = string.Empty;
        }

        
        private void DataGridViewAstronautas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAstronautas.SelectedRows.Count > 0 &&
                    dataGridViewAstronautas.CurrentRow != null &&
                    dataGridViewAstronautas.CurrentRow.Index != -1)
                {
                    DataGridViewRow filaSeleccionada = dataGridViewAstronautas.SelectedRows[0];
                    if (filaSeleccionada.Cells["id"].Value != null &&
                        filaSeleccionada.Cells["nom"].Value != null &&
                        filaSeleccionada.Cells["edat"].Value != null &&
                        filaSeleccionada.Cells["especialitat"].Value != null)
                    {
                        astronautaSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                        nombreOriginal = filaSeleccionada.Cells["nom"].Value.ToString();
                        edadOriginal = filaSeleccionada.Cells["edat"].Value.ToString();
                        especialidadOriginal = filaSeleccionada.Cells["especialitat"].Value.ToString();

                        textBoxNom.Text = nombreOriginal;
                        textBoxEdat.Text = edadOriginal;
                        textBoxEspecialitat.Text = especialidadOriginal;
                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
                LimpiarCampos();
            }
        }

        
        private void btnAfegirAstronauta_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            string nombre = textBoxNom.Text.Trim();
            int edad = int.Parse(textBoxEdat.Text);
            string especialidad = textBoxEspecialitat.Text.Trim();

            db.AfegirAstronauta(nombre, edad, especialidad);
            CargarAstronautas();  
            LimpiarCampos();
        }

        
        private bool ValidarDatos()
        {
            string nombre = textBoxNom.Text.Trim();
            string edad = textBoxEdat.Text.Trim();
            string especialidad = textBoxEspecialitat.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("The name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(edad))
            {
                MessageBox.Show("Age cannot be empty.");
                return false;
            }

            if (!int.TryParse(edad, out int edadNumerica))
            {
                MessageBox.Show("Please enter a valid age.");
                return false;
            }

            if (edadNumerica < 18 || edadNumerica > 70)
            {
                MessageBox.Show("The age must be between 18 and 70 years.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(especialidad))
            {
                MessageBox.Show("The specialty cannot be empty.");
                return false;
            }

            return true;
        }

       
        private void btnModificarAstronauta_Click(object sender, EventArgs e)
        {
            if (dataGridViewAstronautas.SelectedRows.Count == 0 || astronautaSeleccionado == -1)
            {
                MessageBox.Show("Please select an astronaut to modify.");
                return;
            }

            if (!ValidarDatos())
            {
                return;
            }

            string nombre = textBoxNom.Text.Trim();
            int edad = int.Parse(textBoxEdat.Text);
            string especialidad = textBoxEspecialitat.Text.Trim();

            bool cambiosRealizados =
                nombre != nombreOriginal ||
                textBoxEdat.Text != edadOriginal ||
                especialidad != especialidadOriginal;

            if (!cambiosRealizados)
            {
                MessageBox.Show("No data has been modified.", "No changes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.ModificarAstronauta(astronautaSeleccionado, nombre, edad, especialidad);
            CargarAstronautas(); 
            LimpiarCampos();
        }



    

        private void astronautsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarAstronautas();
        }


        
        private void btnEliminarAstronauta_Click(object sender, EventArgs e)
        {
            if (dataGridViewAstronautas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an astronaut to remove.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewAstronautas.SelectedRows[0].Cells["id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this astronaut?",
                "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.EliminarAstronauta(id);
                CargarAstronautas();  
                LimpiarCampos();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            passwTextBox loginForm = new passwTextBox();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void spaceshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNaves formNaves = new FormNaves();
            formNaves.FormClosed += (s, args) => this.Close();
            formNaves.Show();
        }

        private void exepeditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formExpediciones = new Form2();
            formExpediciones.FormClosed += (s, args) => this.Close();
            formExpediciones.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLlistarAstronauta_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAstronauts = db.ObtenirAstronautes();
                DataTable dtExpeditions = db.ObtenirExpedicions(); 

                if (dtAstronauts.Rows.Count == 0 && dtExpeditions.Rows.Count == 0)
                {
                    MessageBox.Show("No astronaut data found.");
                    return;
                }

                string report = "=== COMPLETE ASTRONAUT REPORT ===\n\n";

                report += "=== ASTRONAUTS ===\n";
                if (dtAstronauts.Rows.Count > 0)
                {
                    report += string.Format("{0,-5} {1,-20} {2,-10} {3,-20}\n", "ID", "Name", "Age", "Speciality");
                    report += new string('-', 60) + "\n";

                    foreach (DataRow row in dtAstronauts.Rows)
                    {
                        report += string.Format("{0,-5} {1,-20} {2,-10} {3,-20}\n",
                            row["id"],
                            row["nom"],
                            row["edat"] != DBNull.Value ? row["edat"].ToString() : "N/A", 
                            row["especialitat"]);
                    }
                }
                else
                {
                    report += "No astronauts found.\n";
                }

                report += "\n";

                report += "=== EXPEDITIONS ===\n";
                if (dtExpeditions.Rows.Count > 0)
                {
                    report += string.Format("{0,-5} {1,-20} {2,-15} {3,-10}\n", "ID", "Destination", "Departure Date", "Duration");
                    report += new string('-', 60) + "\n";

                    foreach (DataRow row in dtExpeditions.Rows)
                    {
                        string formattedDate = Convert.ToDateTime(row["data_sortida"]).ToString("MM/dd/yyyy");

                        report += string.Format("{0,-5} {1,-20} {2,-15} {3,-10}\n",
                            row["id"],
                            row["desti"],
                            formattedDate,
                            row["duracio"]);
                    }
                }
                else
                {
                    report += "No expeditions found.\n";
                }

                report += "\n";

                report += "\n\n=== STATISTICAL SUMMARY ===\n";
                report += $"Total astronauts: {dtAstronauts.Rows.Count}\n";

                int totalExpeditions = dtExpeditions.Rows.Count;
                report += $"Total expeditions: {totalExpeditions}\n";

                MessageBox.Show(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating astronaut report: " + ex.Message);
            }
        }
    }
}
