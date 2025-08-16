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
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
            cmbRol.SelectedIndex = 0;
        }

        private void btnAggUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserR.Text) || string.IsNullOrWhiteSpace(txtContraR.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las contraseñas coincidan
            if (txtContraR.Text != txtConfirContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, revísalas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo objeto Usuario con los datos del formulario
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = txtUserR.Text,
                Contraseña = txtContraR.Text,
                Rol = cmbRol.SelectedItem.ToString()
            };

            // Agregar el nuevo usuario a la lista estática
            DataBaseManager dbManager = new DataBaseManager();
            dbManager.GuardarUsuario(nuevoUsuario);

            // Agregar una actividad al log
            LogManager.AgregarActividad($"Nuevo {nuevoUsuario.Rol} '{nuevoUsuario.NombreUsuario}' dado de alta.");

            MessageBox.Show("Nuevo usuario creado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtUserR.Clear();
            txtContraR.Clear();
            txtConfirContra.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            cmbRol.SelectedIndex = 0;
        }

        private void btnCancelarAgg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
