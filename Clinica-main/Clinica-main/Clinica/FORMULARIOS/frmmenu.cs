using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.FORMULARIOS
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIOS.frmusuarios x = new frmusuarios();
            x.Show();
        }
    }
}
