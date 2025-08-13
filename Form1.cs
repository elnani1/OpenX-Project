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
            CargarUsuariosIniciales();
        }

        public static List <Usuario> Usuarios = new List<Usuario>();

        private void CargarUsuariosIniciales()
        {
            Usuarios.Add(new Usuario { NombreUsuario = "admin", Contraseña = "admin123", Rol = "Administrador" });
            Usuarios.Add(new Usuario { NombreUsuario = "usuario", Contraseña = "usuario123", Rol = "Usuario" });
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraIngresada = txtContra.Text;

            // Busca el usuario en la lista
            Usuario usuarioAutenticado = Usuarios.Find(u => u.NombreUsuario == usuarioIngresado && u.Contraseña == contraIngresada);

            if (usuarioAutenticado != null)
            {
                // El usuario encontrado y credenciales son validas
                if (usuarioAutenticado.Rol == "Administrador")
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
                    FormPrincipal userForm = new FormPrincipal();
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
