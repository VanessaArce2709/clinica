using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class frmacceso : Form
    {
        public frmacceso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //CLASES.CLUSUARIOS oingresar = new CLASES.CLUSUARIOS(txtusuario.Text, txtcontraseña.Text);
            CLASES.CLUSUARIOS oingresar = new CLASES.CLUSUARIOS(txtusuario.Text);
            oingresar.buscarpornombre();
            //oingresar.ingresar();
            if ("le atinó" == "le atinó")
            {
                FORMULARIOS.frmmenu fusuario = new FORMULARIOS.frmmenu();
                fusuario.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Acceso Erroneo!!");
        }
    }
}
