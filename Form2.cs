using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestor_de_Expedicions_Espacials
{
    public partial class Form2 : Form
    {
        private Database db = new Database();
        private int expedicioSeleccionada = -1; 

        public Form2()
        {
            InitializeComponent();

            dataGridViewExpediciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpediciones.MultiSelect = false;

            dataGridViewExpediciones.SelectionChanged += DataGridViewExpediciones_SelectionChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarExpediciones();
            LimpiarCampos();
        }

        private void CargarExpediciones()
        {
            DataTable dt = db.ObtenirExpedicions();
            if (dt.Rows.Count > 0)
            {
                dataGridViewExpediciones.DataSource = dt;

                dataGridViewExpediciones.Columns[0].HeaderText = "ID";
                dataGridViewExpediciones.Columns[1].HeaderText = "Destiny";
                dataGridViewExpediciones.Columns[2].HeaderText = "Output date";
                dataGridViewExpediciones.Columns[3].HeaderText = "Duratiob (days)";
                dataGridViewExpediciones.Columns[4].HeaderText = "ID Ship";

                dataGridViewExpediciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dataGridViewExpediciones.DataSource = null;
            }
        }

        private void DataGridViewExpediciones_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewExpediciones.SelectedRows.Count > 0 &&
                    dataGridViewExpediciones.SelectedRows[0].Cells.Count > 0 &&
                    dataGridViewExpediciones.SelectedRows[0].Cells[0].Value != null &&
                    !Convert.IsDBNull(dataGridViewExpediciones.SelectedRows[0].Cells[0].Value))
                {
                    DataGridViewRow filaSeleccionada = dataGridViewExpediciones.SelectedRows[0];

                    if (filaSeleccionada.Cells[0].Value != null &&
                        filaSeleccionada.Cells[1].Value != null &&
                        filaSeleccionada.Cells[2].Value != null &&
                        filaSeleccionada.Cells[3].Value != null &&
                        filaSeleccionada.Cells[4].Value != null)
                    {
                        expedicioSeleccionada = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                        textBoxDesti.Text = filaSeleccionada.Cells[1].Value.ToString();

                        if (DateTime.TryParse(filaSeleccionada.Cells[2].Value.ToString(), out DateTime fecha))
                        {
                            dateTimePickerDataSortida.Value = fecha;
                        }
                        else
                        {
                            dateTimePickerDataSortida.Value = DateTime.Now;
                        }

                        textBoxDuracio.Text = filaSeleccionada.Cells[3].Value.ToString();
                        textBoxNauId.Text = filaSeleccionada.Cells[4].Value.ToString();
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


        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();  
        }

        private void btnAfegirExpedicio_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            string desti = textBoxDesti.Text.Trim();
            int duracion = int.Parse(textBoxDuracio.Text);
            int nauId = int.Parse(textBoxNauId.Text);

            db.AfegirExpedicio(desti, dateTimePickerDataSortida.Value, duracion, nauId);
            CargarExpediciones();  
            LimpiarCampos();
        }

        private bool ValidarDatos()
        {
            string desti = textBoxDesti.Text.Trim();

            if (string.IsNullOrWhiteSpace(desti))
            {
                MessageBox.Show("Destiny cannot be empty.");
                return false;
            }

            if (!int.TryParse(textBoxDuracio.Text, out int duracion))
            {
                MessageBox.Show("Please enter a valid duration.");
                return false;
            }

            if (!int.TryParse(textBoxNauId.Text, out int nauId))
            {
                MessageBox.Show("Please enter a valid ship ID.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            textBoxDesti.Text = string.Empty;
            dateTimePickerDataSortida.Value = DateTime.Now;
            textBoxDuracio.Text = string.Empty;
            textBoxNauId.Text = string.Empty;
            expedicioSeleccionada = -1;
        }

        private void btnEliminarExpedicio_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpediciones.SelectedRows.Count == 0 || expedicioSeleccionada == -1)
            {
                MessageBox.Show("Please select an expedition to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this expedition?",
                "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.EliminarExpedicio(expedicioSeleccionada);
                CargarExpediciones();  
                LimpiarCampos();
            }
        }

        private void btnModificarExpedicio_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpediciones.SelectedRows.Count == 0 || expedicioSeleccionada == -1)
            {
                MessageBox.Show("Please select an expedition to modify.");
                return;
            }

            if (!ValidarDatos())
            {
                return;
            }

            string desti = textBoxDesti.Text.Trim();
            int duracion = int.Parse(textBoxDuracio.Text);
            int nauId = int.Parse(textBoxNauId.Text);

            db.ModificarExpedicio(expedicioSeleccionada, desti, dateTimePickerDataSortida.Value, duracion, nauId);

            CargarExpediciones();
            LimpiarCampos();
        }

        private void expeditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void astronautsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAstronautas formAstronauts = new FormAstronautas();
            formAstronauts.FormClosed += (s, args) => this.Close(); 
            formAstronauts.Show();
        }

        private void spaceshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormNaves formNaves = new FormNaves();
            formNaves.FormClosed += (s, args) => this.Close(); 
            formNaves.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            passwTextBox loginForm = new passwTextBox();
            loginForm.FormClosed += (s, args) => this.Close(); 
            loginForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLlistarExpedicio_Click(object sender, EventArgs e)
        {
            Form reportForm = new Form();
            reportForm.Text = "Complete Data Report";
            reportForm.Size = new Size(800, 600);
            reportForm.StartPosition = FormStartPosition.CenterScreen;

            RichTextBox rtbReport = new RichTextBox();
            rtbReport.Dock = DockStyle.Fill;
            rtbReport.ReadOnly = true;
            rtbReport.Font = new Font("Consolas", 10);

            reportForm.Controls.Add(rtbReport);

            GenerateCompleteReport(rtbReport);

            reportForm.ShowDialog();
        }

        private void GenerateCompleteReport(RichTextBox rtb)
        {
            try
            {
                DataTable dtSpaceships = db.ObtenirNaus();
                DataTable dtExpeditions = db.ObtenirExpedicions();
                DataTable dtAstronauts = db.ObtenirAstronautes();

                if (dtSpaceships.Rows.Count == 0 && dtExpeditions.Rows.Count == 0 && dtAstronauts.Rows.Count == 0)
                {
                    rtb.AppendText("No data found to display.");
                    return;
                }

                rtb.AppendText("=== COMPLETE DATA REPORT ===\n\n");

                rtb.AppendText("=== SPACESHIPS ===\n");
                if (dtSpaceships.Rows.Count > 0)
                {
                    rtb.AppendText(String.Format("{0,-5} {1,-20} {2,-20} {3,-10}\n", "ID", "Name", "Model", "Capacity"));
                    rtb.AppendText(new string('-', 60) + "\n");

                    foreach (DataRow row in dtSpaceships.Rows)
                    {
                        rtb.AppendText(String.Format("{0,-5} {1,-20} {2,-20} {3,-10}\n",
                            row["id"],
                            row["nom"],
                            row["model"],
                            row["capacitat"]));
                    }
                }
                else
                {
                    rtb.AppendText("No spaceships found.\n");
                }

                rtb.AppendText("\n");

                rtb.AppendText("=== EXPEDITIONS ===\n");
                if (dtExpeditions.Rows.Count > 0)
                {
                    rtb.AppendText(String.Format("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10}\n",
                        "ID", "Destination", "Departure Date", "Duration", "Ship ID"));
                    rtb.AppendText(new string('-', 65) + "\n");

                    foreach (DataRow row in dtExpeditions.Rows)
                    {
                        string formattedDate = Convert.ToDateTime(row["data_sortida"]).ToString("MM/dd/yyyy");

                        rtb.AppendText(String.Format("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10}\n",
                            row["id"],
                            row["desti"],
                            formattedDate,
                            row["duracio"],
                            row["nau_id"]));
                    }

                    rtb.AppendText("\nDetails of ships assigned to expeditions:\n");
                    rtb.AppendText(new string('-', 65) + "\n");

                    foreach (DataRow rowExp in dtExpeditions.Rows)
                    {
                        int shipId = Convert.ToInt32(rowExp["nau_id"]);
                        DataRow[] associatedShips = dtSpaceships.Select($"id = {shipId}");

                        if (associatedShips.Length > 0)
                        {
                            rtb.AppendText(String.Format("Expedition to {0} (ID: {1}) uses ship: {2} (Model: {3})\n",
                                rowExp["desti"],
                                rowExp["id"],
                                associatedShips[0]["nom"],
                                associatedShips[0]["model"]));
                        }
                        else
                        {
                            rtb.AppendText(String.Format("Expedition to {0} (ID: {1}) - Ship not found (ID: {2})\n",
                                rowExp["desti"],
                                rowExp["id"],
                                shipId));
                        }
                    }
                }
                else
                {
                    rtb.AppendText("No expeditions found.\n");
                }

                rtb.AppendText("\n");

                rtb.AppendText("=== ASTRONAUTS ===\n");
                if (dtAstronauts.Rows.Count > 0)
                {
                    rtb.AppendText(String.Format("{0,-5} {1,-20} {2,-10} {3,-20}\n",
                        "ID", "Name", "Age", "Speciality"));
                    rtb.AppendText(new string('-', 60) + "\n");

                    foreach (DataRow row in dtAstronauts.Rows)
                    {
                        rtb.AppendText(String.Format("{0,-5} {1,-20} {2,-10} {3,-20}\n",
                            row["id"],
                            row["nom"],
                            row["edat"],
                            row["especialitat"]));
                    }
                }
                else
                {
                    rtb.AppendText("No astronauts found.\n");
                }
                rtb.AppendText("\n\n=== STATISTICAL SUMMARY ===\n");
                rtb.AppendText($"Total spaceships: {dtSpaceships.Rows.Count}\n");
                rtb.AppendText($"Total expeditions: {dtExpeditions.Rows.Count}\n");
                rtb.AppendText($"Total astronauts: {dtAstronauts.Rows.Count}\n");

                int totalCapacity = 0;
                foreach (DataRow row in dtSpaceships.Rows)
                {
                    totalCapacity += Convert.ToInt32(row["capacitat"]);
                }
                rtb.AppendText($"Total fleet capacity: {totalCapacity} people\n");

                int totalDuration = 0;
                foreach (DataRow row in dtExpeditions.Rows)
                {
                    totalDuration += Convert.ToInt32(row["duracio"]);
                }
                rtb.AppendText($"Total duration of all expeditions: {totalDuration} days\n");
            }
            catch (Exception ex)
            {
                rtb.Text = "Error generating report: " + ex.Message;
            }
        }


    }
}