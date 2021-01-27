using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios.Lógica;
using Ejercicios.Presentación;

namespace Ejercicios.Presentación
{
    public partial class FrmCalculoSalarial : Form
    {
        public FrmCalculoSalarial()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text != null) & (txtHoras.Text != null)){
                int horas; int salario = 0;
                horas = Convert.ToInt32(txtHoras.Text);
                CalculoSalarioL cs = new CalculoSalarioL();
                salario = cs.calculoPago(horas);
                MessageBox.Show("Se debe pagar al trabajador:  " + txtNombre.Text + "  La suma de: $" + salario, "SUELDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoras.Text = " ";
                txtNombre.Text = " ";
            }
            
            

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                e.Cancel = true;
                txtNombre.Select(0, txtNombre.Text.Length);
              //  errorProvider1.SetError(txtNombre, "Debe introducir el nombre");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
           // errorProvider1.SetError(tb, "");
        }

        private void btnCancelarS_Click(object sender, EventArgs e)
        {
            txtHoras.Text = " ";
            txtNombre.Text = " ";
                    }
    }
}
