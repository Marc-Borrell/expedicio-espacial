using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestor_de_Expedicions_Espacials
{
    public partial class FormNaves : Form
    {
        private Database db = new Database();
        private int nauSeleccionada = -1;

        private string nomOriginal = string.Empty;
        private string modelOriginal = string.Empty;
        private string capacitatOriginal = string.Empty;

        public FormNaves()
        {
            InitializeComponent();
            this.Load += FormNaves_Load;

            dataGridViewNaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNaves.MultiSelect = false;
            dataGridViewNaves.ReadOnly = true;
            dataGridViewNaves.AllowUserToAddRows = false;
            dataGridViewNaves.SelectionChanged += DataGridViewNaves_SelectionChanged;
        }

        private void FormNaves_Load(object sender, EventArgs e)
        {
            CargarNaus();
            LimpiarCampos();
        }

        private void CargarNaus()
        {
            try
            {
                DataTable dt = db.ObtenirNaus();
                dataGridViewNaves.DataSource = dt;
                dataGridViewNaves.Refresh();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("There are no registered ships.");
                }
                else
                {
                    if (dt.Columns.Contains("id"))
                        dataGridViewNaves.Columns["id"].HeaderText = "ID";
                    if (dt.Columns.Contains("nom"))
                        dataGridViewNaves.Columns["nom"].HeaderText = "Name";
                    if (dt.Columns.Contains("model"))
                        dataGridViewNaves.Columns["model"].HeaderText = "Model";
                    if (dt.Columns.Contains("capacitat"))
                        dataGridViewNaves.Columns["capacitat"].HeaderText = "Capacity";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ships: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            textBoxNom.Text = string.Empty;
            textBoxModel.Text = string.Empty;
            textBoxCapacitat.Text = string.Empty;
            nauSeleccionada = -1;
            nomOriginal = string.Empty;
            modelOriginal = string.Empty;
            capacitatOriginal = string.Empty;
        }

        private void DataGridViewNaves_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewNaves.SelectedRows.Count > 0 &&
                    dataGridViewNaves.CurrentRow != null &&
                    dataGridViewNaves.CurrentRow.Index != -1)
                {
                    DataGridViewRow filaSeleccionada = dataGridViewNaves.SelectedRows[0];
                    if (filaSeleccionada.Cells["id"].Value != null &&
                        filaSeleccionada.Cells["nom"].Value != null &&
                        filaSeleccionada.Cells["model"].Value != null &&
                        filaSeleccionada.Cells["capacitat"].Value != null)
                    {
                        nauSeleccionada = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                        nomOriginal = filaSeleccionada.Cells["nom"].Value.ToString();
                        modelOriginal = filaSeleccionada.Cells["model"].Value.ToString();
                        capacitatOriginal = filaSeleccionada.Cells["capacitat"].Value.ToString();

                        textBoxNom.Text = nomOriginal;
                        textBoxModel.Text = modelOriginal;
                        textBoxCapacitat.Text = capacitatOriginal;
                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la nave: " + ex.Message);
                LimpiarCampos();
            }
        }

        // Validar los datos ingresados para la nave
        private bool ValidarDatos()
        {
            string nom = textBoxNom.Text.Trim();
            string model = textBoxModel.Text.Trim();
            string capacitat = textBoxCapacitat.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("The name cannot be empty.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("The model cannot be empty.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(capacitat))
            {
                MessageBox.Show("The capacity cannot be empty.");
                return false;
            }
            if (!int.TryParse(capacitat, out int cap))
            {
                MessageBox.Show("Please enter a valid capacity.");
                return false;
            }
            return true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarNaus();
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            string nom = textBoxNom.Text.Trim();
            string model = textBoxModel.Text.Trim();
            int capacitat = int.Parse(textBoxCapacitat.Text.Trim());

            db.AfegirNau(nom, model, capacitat);
            CargarNaus(); 
            LimpiarCampos();
        }

        private void btnElminarNau_Click(object sender, EventArgs e)
        {
            if (dataGridViewNaves.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ship to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewNaves.SelectedRows[0].Cells["id"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this ship?",
                "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.EliminarNau(id);
                CargarNaus();
                LimpiarCampos();
            }
        }

        private void btnModificarNau_Click(object sender, EventArgs e)
        {
            if (dataGridViewNaves.SelectedRows.Count == 0 || nauSeleccionada == -1)
            {
                MessageBox.Show("Please select a ship to modify.");
                return;
            }

            if (!ValidarDatos())
            {
                return;
            }

            string nom = textBoxNom.Text.Trim();
            string model = textBoxModel.Text.Trim();
            int capacitat = int.Parse(textBoxCapacitat.Text.Trim());

            bool cambiosRealizados = (nom != nomOriginal) || (model != modelOriginal) || (textBoxCapacitat.Text.Trim() != capacitatOriginal);
            if (!cambiosRealizados)
            {
                MessageBox.Show("No data has been modified.", "No changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.ModificarNau(nauSeleccionada, nom, model, capacitat);
            CargarNaus();
            LimpiarCampos();
        }

        private void expeditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formExpediciones = new Form2();
            formExpediciones.FormClosed += (s, args) => this.Close();
            formExpediciones.Show();
        }

        private void astronautsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAstronautas formAstronautas = new FormAstronautas();
            formAstronautas.FormClosed += (s, args) => this.Close();
            formAstronautas.Show();
        }

        private void spaceshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarNaus();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            passwTextBox loginForm = new passwTextBox();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnLlistarNau_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSpaceships = db.ObtenirNaus();
                DataTable dtExpeditions = db.ObtenirExpedicions();

                if (dtSpaceships.Rows.Count == 0 && dtExpeditions.Rows.Count == 0)
                {
                    MessageBox.Show("No data found to display.");
                    return;
                }

                string report = "=== COMPLETE DATA REPORT ===\n\n";

                report += "=== SPACESHIPS ===\n";
                if (dtSpaceships.Rows.Count > 0)
                {
                    report += string.Format("{0,-5} {1,-20} {2,-20} {3,-10}\n", "ID", "Name", "Model", "Capacity");
                    report += new string('-', 60) + "\n";

                    foreach (DataRow row in dtSpaceships.Rows)
                    {
                        report += string.Format("{0,-5} {1,-20} {2,-20} {3,-10}\n",
                            row["id"],
                            row["nom"],
                            row["model"],
                            row["capacitat"]);
                    }
                }
                else
                {
                    report += "No spaceships found.\n";
                }

                report += "\n";

                report += "=== EXPEDITIONS ===\n";
                if (dtExpeditions.Rows.Count > 0)
                {
                    report += string.Format("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10}\n",
                        "ID", "Destination", "Departure Date", "Duration", "Ship ID");
                    report += new string('-', 65) + "\n";

                    foreach (DataRow row in dtExpeditions.Rows)
                    {
                        string formattedDate = Convert.ToDateTime(row["data_sortida"]).ToString("MM/dd/yyyy");

                        report += string.Format("{0,-5} {1,-20} {2,-15} {3,-10} {4,-10}\n",
                            row["id"],
                            row["desti"],
                            formattedDate,
                            row["duracio"],
                            row["nau_id"]);
                    }

                    report += "\nDetails of ships assigned to expeditions:\n";
                    report += new string('-', 65) + "\n";

                    foreach (DataRow rowExp in dtExpeditions.Rows)
                    {
                        int shipId = Convert.ToInt32(rowExp["nau_id"]);
                        DataRow[] associatedShips = dtSpaceships.Select($"id = {shipId}");

                        if (associatedShips.Length > 0)
                        {
                            report += string.Format("Expedition to {0} (ID: {1}) uses ship: {2} (Model: {3})\n",
                                rowExp["desti"],
                                rowExp["id"],
                                associatedShips[0]["nom"],
                                associatedShips[0]["model"]);
                        }
                        else
                        {
                            report += string.Format("Expedition to {0} (ID: {1}) - Ship not found (ID: {2})\n",
                                rowExp["desti"],
                                rowExp["id"],
                                shipId);
                        }
                    }
                }
                else
                {
                    report += "No expeditions found.\n";
                }

                report += "\n";

                report += "\n\n=== STATISTICAL SUMMARY ===\n";
                report += $"Total spaceships: {dtSpaceships.Rows.Count}\n";
                report += $"Total expeditions: {dtExpeditions.Rows.Count}\n";

                int totalCapacity = 0;
                foreach (DataRow row in dtSpaceships.Rows)
                {
                    totalCapacity += Convert.ToInt32(row["capacitat"]);
                }
                report += $"Total fleet capacity: {totalCapacity} people\n";

                int totalDuration = 0;
                foreach (DataRow row in dtExpeditions.Rows)
                {
                    totalDuration += Convert.ToInt32(row["duracio"]);
                }
                report += $"Total duration of all expeditions: {totalDuration} days\n";

                MessageBox.Show(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating the report: " + ex.Message);
            }
        }
    }
}
