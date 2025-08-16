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
    public partial class FormSecundario : Form
    {
        public FormSecundario()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MenuLogin menulogin1 = new MenuLogin();
            menulogin1.ShowDialog();
            this.Hide();
        }
    }
}
