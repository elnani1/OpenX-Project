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
<<<<<<< HEAD
        private ReglaDeAcceso reglaActual;
=======
>>>>>>> 3b9fa4ab6716183f5cf4bfa650410cacb98841a2
        public FormularioReglamentario()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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
=======
        private void FormularioReglamentario_Load(object sender, EventArgs e)
        {
            dgvReglas.Columns.Add("UsuarioCol", "Usuario/Rol");
            dgvReglas.Columns.Add("DispositivoCol", "Dispositivo");
            dgvReglas.Columns.Add("HorarioCol", "Horario");

>>>>>>> 3b9fa4ab6716183f5cf4bfa650410cacb98841a2
            cbxUsuarios.Items.Add("Administrador");
            cbxUsuarios.Items.Add("Usuario");
            cbxDispositivos.Items.Add("Dispositivo - 001");
            cbxDispositivos.Items.Add("Dispositivo - 002");
<<<<<<< HEAD

            cargarReglas();
        }

        private void cargarReglas()
        {
            DataBaseManager dbManager = new DataBaseManager();
            dgvReglas.DataSource = dbManager.ObtenerTodasLasReglas();
=======
>>>>>>> 3b9fa4ab6716183f5cf4bfa650410cacb98841a2
        }

        private void btnGuardarRegla_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            string Usuario = cbxUsuarios.SelectedIndex.ToString();
            string Dispositivo = cbxDispositivos.SelectedIndex.ToString();
            string Horario = txtHorario.Text;

            //Agrega una fila al data grit
            dgvReglas.Rows.Add(Usuario, Dispositivo, Horario);
            //Limpia campos
            cbxDispositivos.SelectedIndex = -1;
            cbxUsuarios.SelectedIndex = -1;
            txtHorario.Clear();
>>>>>>> 3b9fa4ab6716183f5cf4bfa650410cacb98841a2
        }

        private void btnEliminarRegla_Click(object sender, EventArgs e)
        {
            if(dgvReglas.SelectedRows.Count > 0)
            {
<<<<<<< HEAD
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
=======
                int indiceSeleccionado = dgvReglas.SelectedRows[0].Index;
                dgvReglas.Rows.RemoveAt (indiceSeleccionado);
            }
            else
            {
                MessageBox.Show("Selecciona la columna para eliminar Correctamnte !Por favor¡.");
>>>>>>> 3b9fa4ab6716183f5cf4bfa650410cacb98841a2
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }
<<<<<<< HEAD

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
=======
>>>>>>> 3b9fa4ab6716183f5cf4bfa650410cacb98841a2
    }
}
