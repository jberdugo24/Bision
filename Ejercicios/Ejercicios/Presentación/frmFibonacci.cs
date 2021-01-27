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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i; int numero;
            numero = Convert.ToInt32(txtSecuencia.Text);
            FibonacciL f = new FibonacciL ();
            ltsFibo.Items.Clear();
            for (i = 0; i < (numero-1); i++)
            {
                ltsFibo.Items.Add(Convert.ToString(f.fibonacci(i)));
            }            
        }

      
    }
}
