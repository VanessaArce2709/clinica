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
    public partial class frmpacientes : Form
    {
        public frmpacientes()
        {
            InitializeComponent();
        }

        private void frmpacientes_Load(object sender, EventArgs e)
        {

        }

        private void dtpnacimiento_Leave(object sender, EventArgs e)
        {
            // como calcular la edad
            int año_actual = Convert.ToDateTime(dtpRegistro.Text).Year;
            int mes_actual = Convert.ToDateTime(dtpRegistro.Text).Month;
            int dia_actual = Convert.ToDateTime(dtpRegistro.Text).Day;
            DateTime fecha_nacimiento = Convert.ToDateTime(dtpnacimiento.Text);
            int añonacimiento = fecha_nacimiento.Year;
            int mesnacimiento = fecha_nacimiento.Month;
            int dianacimiento = fecha_nacimiento.Day;
            if(mes_actual >= mesnacimiento)
            {
                if(dia_actual >= dianacimiento)
                {
                    txtedad.Text = (año_actual - añonacimiento).ToString();
                }
                else
                {
                    txtedad.Text = ((año_actual - añonacimiento) - 1).ToString();
                }
                
            }
            else
            {
                txtedad.Text = ((año_actual - añonacimiento) - 1).ToString();
            }
            
        }
    }
}
