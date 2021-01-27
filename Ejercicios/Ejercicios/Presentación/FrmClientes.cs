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
using Ejercicios.Datos;

namespace Ejercicios.Presentación
{
    public partial class FrmClientes : Form
    {

        ClientesD clientD;
        public FrmClientes()
        {
            clientD = new ClientesD();
            InitializeComponent();
            llenarGrid();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {                   
            
            clientD.Agregar(TraeInformacion());
            llenarGrid();
            LimpiarEntradas();
        }

        private ClientesL TraeInformacion()
        {
            ClientesL OclientL = new ClientesL();
            
            int ID = 0; int.TryParse(txtID.Text, out ID);
            OclientL.ID = ID;            
            OclientL.nombreC = txtNombre.Text;
            OclientL.telefonoC = txtTelefono.Text;
            OclientL.correoC = txtEmail.Text;

            return OclientL;

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvClientes.ClearSelection();
            if(indice >= 0)
            {
                txtID.Text = dgvClientes.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.Rows[indice].Cells[1].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[indice].Cells[2].Value.ToString();
                txtEmail.Text = dgvClientes.Rows[indice].Cells[3].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = true;
            }                
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clientD.Eliminar(TraeInformacion());
            llenarGrid();
            LimpiarEntradas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clientD.Modificar(TraeInformacion());
            llenarGrid();
            LimpiarEntradas();

        }

        public void llenarGrid()
        {
            dgvClientes.DataSource = clientD.MostrarClientes().Tables[0];
        }

        public void LimpiarEntradas()
        {
            txtID.Text = " ";
            txtNombre.Text = " ";
            txtTelefono.Text = " ";
            txtEmail.Text = " ";

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }
    }
}
