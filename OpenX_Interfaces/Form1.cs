using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenX_Interfaces
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraIngresada = txtContra.Text;

            //Instancia del Manager
            DataBaseManager DbManager = new DataBaseManager();
            Usuario usuarioAutenticado = DbManager.ValidarCredenciales(usuarioIngresado, contraIngresada);

            if (usuarioAutenticado != null)
            {
                // El usuario encontrado y credenciales son validas
                if (usuarioAutenticado.Rol.Trim() == "Administrador")
                {
                    MessageBox.Show("¡Bienvenido al sistema como Administrador!", "Inicio de sesión exitoso");
                    this.Hide();
                    FormPrincipal adminForm = new FormPrincipal();
                    adminForm.ShowDialog();
                }
                else // Es un usuario normal
                {
                    MessageBox.Show("¡Bienvenido al sistema!", "Inicio de sesión exitoso");
                    this.Hide();
                    FormSecundario userForm = new FormSecundario();
                    userForm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtContra.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
