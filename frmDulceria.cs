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
                int precioFinal = Convert.ToInt32(dulceria.Comprar(cmbDulce.SelectedItem.ToString(), Convert.ToInt32(txtCantidad.Text)));

                dgvDulces.Rows.Add(cmbTipoDeDulce.SelectedItem.ToString(), 
                cmbDulce.SelectedItem.ToString(), txtMarca.Text,
                precioFinal);
                
                dulceria.LlenarCompra(cmbDulce.SelectedItem.ToString(), precioFinal, cmbTipoDeDulce.SelectedItem.ToString());

                sumaTotal = sumaTotal + Convert.ToInt32(dulceria.Comprar(cmbDulce.SelectedItem.ToString(), Convert.ToInt32(txtCantidad.Text)));
                txtPago.Enabled = true;
                btnLimpiarDgv.Enabled = true;

                Limpiar();

                lblTotal.Visible = true;
                txtTotal.Visible = true;
                txtTotal.Text = sumaTotal.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Indique la cantidad de producto");
                txtCantidad.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
            LimpiarTotal();
            sumaTotal = 0;
            btnCompraFinal.Enabled = false;
            btnLimpiarDgv.Enabled = false;
        }

        private void btnCompraFinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada por $"+sumaTotal+" pesos"
                + "\n"
                + "\nPagó con $" + txtPago.Text + " pesos"
                + "\n"
                + "\nSu cambio es de $" + (Convert.ToInt32(txtPago.Text) - sumaTotal) + " pesos");
            dgvDulces.Rows.Clear();
            LimpiarTotal();
            sumaTotal = 0;
            btnCompraFinal.Enabled = false;
            btnLimpiarDgv.Enabled = false;
        }

        private void Limpiar()
        {
            cmbTipoDeDulce.Items.Clear();
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
            cmbDulce.Enabled = false;
            txtCantidad.Enabled = false;
            txtMarca.Enabled = false;
            btnComprar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (txtPago.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(txtPago.Text) > Convert.ToInt32(txtTotal.Text))
                    {
                        btnCompraFinal.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese la cantidad con un número entero");
                    txtPago.Clear();
                    btnCompraFinal.Enabled = false;
                }
            }
        }

        private void LimpiarTotal()
        {
            lblTotal.Visible = false;
            txtTotal.Visible = false;
            txtTotal.Text = "0";

            txtPago.Clear();
            txtPago.Enabled = false;
        }
    }
}
