using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gestor_de_Expedicions_Espacials
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbConfirmPassword.PasswordChar = '*';
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string usuario = tbUsername.Text;
            string contrasenya = tbPassword.Text;
            string confirmContrasenya = tbConfirmPassword.Text;

            if (contrasenya != confirmContrasenya)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (IsUsernameTaken(usuario))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            if (RegistrarUsuario(usuario, contrasenya))
            {
                MessageBox.Show("User successfully registered.");
                this.Hide();  
                passwTextBox loginForm = new passwTextBox();  
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Error registering the user.");
            }
        }

        private bool IsUsernameTaken(string usuario)
        {
            try
            {
                using (var conn = new Database().GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM usuaris WHERE nom = @usuari";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuari", usuario);

                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                        return userCount > 0;  
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);  
                return false;
            }
        }

        private bool RegistrarUsuario(string usuario, string contrasenya)
        {
            try
            {
                using (var conn = new Database().GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO usuaris (nom, contrasenya) VALUES (@usuari, @contrasenya)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuari", usuario);
                        cmd.Parameters.AddWithValue("@contrasenya", contrasenya); 

                        int rowsAffected = cmd.ExecuteNonQuery();  
                        return rowsAffected > 0;  
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
                return false;
            }
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0'; 
                tbConfirmPassword.PasswordChar = '\0'; 
            }
            else
            {
                tbPassword.PasswordChar = '*';  
                tbConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            string usuario = tbUsername.Text;
            string contrasenya = tbPassword.Text;
            string confirmContrasenya = tbConfirmPassword.Text;

            if (contrasenya != confirmContrasenya)
            {
                MessageBox.Show("Passwords do not match.");
                return; 
            }

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenya))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            if (IsUsernameTaken(usuario))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            if (RegistrarUsuario(usuario, contrasenya))
            {
                MessageBox.Show("User successfully registered.");
                this.Hide();  
                passwTextBox loginForm = new passwTextBox();  
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Error registering the user.");
            }
        }
    }
}
