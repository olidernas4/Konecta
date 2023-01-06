using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konecta
{
    public partial class InicioApp : Form
    {
        public InicioApp()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 m = new Form1();
            m.ShowDialog();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            this.Hide();
            Solicitud m = new Solicitud();
            m.ShowDialog();
        }
    }
}
