using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios.Presentación;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            frmFibonacci formularioFibo = new frmFibonacci();
            formularioFibo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes formularioClientes = new FrmClientes();
            formularioClientes.Show();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            FrmCalculoSalarial formularioCalculo = new FrmCalculoSalarial();
            formularioCalculo.Show();
        }
    }
}
