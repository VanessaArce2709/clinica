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
    public partial class frmusuarios : Form
    {
        public frmusuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de imagenes (*.jpg)(*.jpeg)|*.jpg;*.jpeg";

            if(getImage.ShowDialog() == DialogResult.OK)
            {
                fotousuario.ImageLocation = getImage.FileName;
                txtruta.Text = getImage.FileName;
            }
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter
            //SaveFileDialog.Filter = "";
        }
    }
}
