using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemexApp
{
    public partial class frmDulceria : Form
    {
        private int sumaTotal=0;
        public frmDulceria()
        {
            InitializeComponent();
        }
        ConexionDulceria dulceria = new ConexionDulceria();

        private void frmDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        private void cmbTipoDeDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
            txtCantidad.Enabled = false;
            btnComprar.Enabled = false;
            dulceria.TipodeDulceSeleccionado(cmbTipoDeDulce.SelectedItem.ToString());
            dulceria.LlenarItemsDulce(cmbDulce);
            cmbDulce.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void cmbDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            dulceria.DulceSeleccionado(cmbDulce.SelectedItem.ToString());
            dulceria.LlenarTxtMarca(txtMarca);
            txtCantidad.Enabled = true;
            txtCantidad.Clear();
            btnComprar.Enabled = false;
        }

        private void cmbTipoDeDulce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            btnComprar.Enabled = true;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
            dgvDulces.Rows.Add(cmbTipoDeDulce.SelectedItem.ToString(), 
                cmbDulce.SelectedItem.ToString(), txtMarca.Text,
                dulceria.Comprar(cmbDulce.SelectedItem.ToString(), Convert.ToInt32(txtCantidad.Text)));
                dulceria.LlenarCompra(cmbDulce.SelectedItem.ToString());
            sumaTotal = sumaTotal + Convert.ToInt32(dulceria.Comprar(cmbDulce.SelectedItem.ToString(), Convert.ToInt32(txtCantidad.Text)));
            btnCompraFinal.Enabled = true;
            btnLimpiarDgv.Enabled = true;
                //dulceria.Comprar(cmbDulce.SelectedItem.ToString(), Convert.ToInt32(txtCantidad.Text));
                cmbTipoDeDulce.Items.Clear();
                //dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
                cmbDulce.Items.Clear();
                txtMarca.Clear();
                txtCantidad.Clear();
                cmbDulce.Enabled = false;
                txtCantidad.Enabled = false;
                txtMarca.Enabled = false;
                btnComprar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Indique la cantidad de producto");
                txtCantidad.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoDeDulce.Items.Clear();
            //dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
            cmbDulce.Enabled = false;
            txtCantidad.Enabled = false;
            txtMarca.Enabled = false;
            btnComprar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void cmbTipoDeDulce_Click(object sender, EventArgs e)
        {
            cmbTipoDeDulce.Items.Clear();
            dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarDgv_Click(object sender, EventArgs e)
        {
            dgvDulces.Rows.Clear();
            sumaTotal = 0;
            btnCompraFinal.Enabled = false;
            btnLimpiarDgv.Enabled = false;
        }

        private void btnCompraFinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada por $"+sumaTotal+" pesos");
            dgvDulces.Rows.Clear();
            sumaTotal = 0;
            btnCompraFinal.Enabled = false;
            btnLimpiarDgv.Enabled = false;
        }
    }
}
