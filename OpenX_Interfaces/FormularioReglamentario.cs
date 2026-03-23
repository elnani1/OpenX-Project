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
    public partial class FormularioReglamentario : Form
    {
        private ReglaDeAcceso reglaActual;
        public FormularioReglamentario()
        {
            InitializeComponent();
        }

        public FormularioReglamentario(ReglaDeAcceso regla)
        {
            InitializeComponent();
            this.reglaActual = regla;

            if (this.reglaActual != null)
            {
                txtHorario.Text = reglaActual.Horario;
                btnGuardarRegla.Text = "Actualizar";
            }
        }

        private void FormularioReglamentario_Load(object sender, EventArgs e)
        {
            cbxUsuarios.Items.Add("Administrador");
            cbxUsuarios.Items.Add("Usuario");
            cbxDispositivos.Items.Add("Dispositivo - 001");
            cbxDispositivos.Items.Add("Dispositivo - 002");

            cargarReglas();
        }

        private void cargarReglas()
        {
            DataBaseManager dbManager = new DataBaseManager();
            dgvReglas.DataSource = dbManager.ObtenerTodasLasReglas();
        }

        private void btnGuardarRegla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHorario.Text) || cbxUsuarios.SelectedIndex == -1 || cbxDispositivos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellena todos los campos para la regla.");
                return;
            }
            DataBaseManager dbManager = new DataBaseManager();

            if (reglaActual != null)
            {
                // Modo de Actualización
                reglaActual.UsuarioAsignado = cbxUsuarios.SelectedItem.ToString();
                reglaActual.DispositivoAsignado = cbxDispositivos.SelectedItem.ToString();
                reglaActual.Horario = txtHorario.Text;
                dbManager.ActualizarRegla(reglaActual);
                MessageBox.Show("Regla actualizada con éxito.");
            }
            else
            {
                // Modo de Creación
                ReglaDeAcceso nuevaRegla = new ReglaDeAcceso
                {
                    UsuarioAsignado = cbxUsuarios.SelectedItem.ToString(),
                    DispositivoAsignado = cbxDispositivos.SelectedItem.ToString(),
                    Horario = txtHorario.Text
                };
                dbManager.GuardarRegla(nuevaRegla);
                MessageBox.Show("Regla guardada con éxito.");
            }

            limpiarCampos();
            cargarReglas(); // Refresca el DataGridView
        }

        private void btnEliminarRegla_Click(object sender, EventArgs e)
        {
            if(dgvReglas.SelectedRows.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("¿Estás seguro de que quieres borrar esta regla?", "Conformar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(confirmation == DialogResult.Yes)
                {
                    int idReglaAEliminar = (int)dgvReglas.SelectedRows[0].Cells["id"].Value;
                    DataBaseManager dbManager = new DataBaseManager();

                    dbManager.EliminarRegla(idReglaAEliminar);
                    MessageBox.Show("Regla eliminada con éxito");

                    cargarReglas();
                }
            }
            else
            {
                MessageBox.Show("Selecciona la columna para eliminar correctamnte, !Por favor¡.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            cbxUsuarios.SelectedIndex = -1;
            cbxDispositivos.SelectedIndex = -1;
            txtHorario.Clear();
            reglaActual = null; //Resetea la variable edicion
            btnGuardarRegla.Text = "Guardar";
        }
    }
}
