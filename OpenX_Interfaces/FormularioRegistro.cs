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
        private Usuario usuarioActual;

        public FormularioRegistro(Usuario usuario = null)
        {
            InitializeComponent();
            cmbRol.SelectedIndex = 0;
            this.usuarioActual = usuario;

            if (this.usuarioActual != null)
            {
                // Si el usuario actual no es nulo, significa que estamos editando un usuario existente
                txtUserR.Text = usuarioActual.NombreUsuario;
                txtContraR.Text = usuarioActual.Contraseña;
                cmbRol.SelectedItem = usuarioActual.Rol;

                txtUserR.Enabled = false; // Deshabilitar el campo de nombre de usuario para evitar cambios
                btnAggUser.Text = "Actualizar"; // Cambiar el texto del botón para indicar actualización
            }
        }

        private void btnAggUser_Click(object sender, EventArgs e)
        {
            // Validaciones iniciales
            if (string.IsNullOrWhiteSpace(txtUserR.Text) || string.IsNullOrWhiteSpace(txtContraR.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las contraseñas coincidan solo si no estamos editando
            if (usuarioActual == null && txtContraR.Text != txtConfirContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, revísalas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea una instancia de DatabaseManager
            DataBaseManager dbManager = new DataBaseManager();

            // Lógica para decidir si es una operación de Crear o Actualizar
            if (usuarioActual != null)
            {
                // Es una operación de Actualizar
                usuarioActual.Contraseña = txtContraR.Text;
                usuarioActual.Rol = cmbRol.SelectedItem.ToString();
                dbManager.ActualizarUsuario(usuarioActual); // Llama al método de ACTUALIZACIÓN
                LogManager.AgregarActividad($"Usuario '{usuarioActual.NombreUsuario}' actualizado.");
                MessageBox.Show("Usuario actualizado con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Es una operación de Crear
                Usuario nuevoUsuario = new Usuario
                {
                    NombreUsuario = txtUserR.Text,
                    Contraseña = txtContraR.Text,
                    Rol = cmbRol.SelectedItem.ToString()
                };
                dbManager.GuardarUsuario(nuevoUsuario); // Llama al método de GUARDAR
                LogManager.AgregarActividad($"Nuevo {nuevoUsuario.Rol} '{nuevoUsuario.NombreUsuario}' dado de alta.");
                MessageBox.Show("Nuevo usuario creado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cierra el formulario después de la operación exitosa
            this.Close();
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

        private void FormularioRegistro_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            DataBaseManager dbManager = new DataBaseManager();
            dgvUsuarios.DataSource = dbManager.ObtenerTodosLosUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    string nombreUsuarioAEliminar = dgvUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();

                    DataBaseManager dbManager = new DataBaseManager();
                    dbManager.EliminarUsuario(nombreUsuarioAEliminar); // Llama al método de ELIMINACIÓN

                    CargarUsuarios(); // Recargar la lista de usuarios después de la eliminación
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}