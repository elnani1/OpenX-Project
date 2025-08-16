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
        public FormularioReglamentario()
        {
            InitializeComponent();
        }

        private void FormularioReglamentario_Load(object sender, EventArgs e)
        {
            dgvReglas.Columns.Add("UsuarioCol", "Usuario/Rol");
            dgvReglas.Columns.Add("DispositivoCol", "Dispositivo");
            dgvReglas.Columns.Add("HorarioCol", "Horario");

            cbxUsuarios.Items.Add("Administrador");
            cbxUsuarios.Items.Add("Usuario");
            cbxDispositivos.Items.Add("Dispositivo - 001");
            cbxDispositivos.Items.Add("Dispositivo - 002");
        }

        private void btnGuardarRegla_Click(object sender, EventArgs e)
        {
            string Usuario = cbxUsuarios.SelectedIndex.ToString();
            string Dispositivo = cbxDispositivos.SelectedIndex.ToString();
            string Horario = txtHorario.Text;

            //Agrega una fila al data grit
            dgvReglas.Rows.Add(Usuario, Dispositivo, Horario);
            //Limpia campos
            cbxDispositivos.SelectedIndex = -1;
            cbxUsuarios.SelectedIndex = -1;
            txtHorario.Clear();
        }

        private void btnEliminarRegla_Click(object sender, EventArgs e)
        {
            if(dgvReglas.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dgvReglas.SelectedRows[0].Index;
                dgvReglas.Rows.RemoveAt (indiceSeleccionado);
            }
            else
            {
                MessageBox.Show("Selecciona la columna para eliminar Correctamnte !Por favor¡.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }
    }
}
