using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gestor_de_Expedicions_Espacials
{
    public partial class passwTextBox : Form
    {
        public passwTextBox()
        {
            InitializeComponent();

            passTextBox.PasswordChar = '*';  
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usuari = userTextBox.Text;
            string contrasenya = passTextBox.Text;

            if (ValidarUsuari(usuari, contrasenya))
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User or password incorrect.");
            }
        }

        private bool ValidarUsuari(string usuari, string contrasenya)
        {
            using (var conn = new Database().GetConnection())
            {
                conn.Open();
                string query = "SELECT contrasenya FROM usuaris WHERE nom = @usuari";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuari", usuari);

                   
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string contrasenyaGuardada = result.ToString();

                       
                        if (contrasenya == contrasenyaGuardada)
                        {
                            return true;  
                        }
                    }
                }
            }

            return false;  
        }

        
        private void label1_Click_2(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                passTextBox.PasswordChar = '\0'; 
            }
            else
            {
                passTextBox.PasswordChar = '*';  
            }
        }
    }
}
