using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenX_Interfaces
{
    public partial class FormPrincipal : Form
    {
        private bool menuExpandido = false;
        private int anchoMenuColapsado = 0;
        private int anchoMenuExtendido = 285;

        public FormPrincipal()
        { 
            InitializeComponent();
            pnlMenuRetractil.Width = anchoMenuColapsado;
            CargarActividadReciente();
        }

        public void CargarActividadReciente()
        {
            pnlEventos.Controls.Clear();

            int top = 10;
            foreach (var evento in LogManager.Actividades)
            {
                Label lblEvento = new Label();
                lblEvento.Text = evento;
                lblEvento.AutoSize = true;
                lblEvento.Location = new Point(10, top);

                pnlEventos.Controls.Add(lblEvento);
                top += 25; // Espacio entre eventos
            }
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                // Expandir el menú
                pnlMenuRetractil.Width -= 15;

                if (pnlMenuRetractil.Width <= anchoMenuColapsado)
                {
                    timerMenu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                pnlMenuRetractil.Width += 15;

                if (pnlMenuRetractil.Width >= anchoMenuExtendido)
                {
                    timerMenu.Stop();
                    menuExpandido = true;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MenuLogin menuLogin = new MenuLogin();
            menuLogin.ShowDialog();
            this.Hide(); // Cierra el formulario principal al cerrar sesión
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            FormularioRegistro formRegistro = new FormularioRegistro();
            formRegistro.ShowDialog();

            CargarActividadReciente();
        }

        private void btnReglamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioReglamentario formularioReglamentario = new FormularioReglamentario();
            formularioReglamentario.ShowDialog();
        }
    }
}
