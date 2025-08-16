using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OpenX_Interfaces
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE UsuarioLogin = @usuario AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    // Login exitoso
                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormularioRegistro registro = new FormularioRegistro();
            registro.Show();
        }
    }
}
