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
        }

        private void btnReglamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioReglamentario formularioReglamentario = new FormularioReglamentario();
            formularioReglamentario.ShowDialog();
        }
    }
}
