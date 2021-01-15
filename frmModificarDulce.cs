using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemexApp
{
    public partial class frmModificarDulce : Form
    {
        public frmModificarDulce()
        {
            InitializeComponent();
        }
        ConexionDulceria dulceria = new ConexionDulceria();

        private void frmModificarDulce_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        private void cmbTipoDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDulce.Items.Clear();
            txtTipoDulce.Clear();
            txtDulce.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbDulce.Enabled = true;
            btnModificar.Enabled = false;
            btnLimpiar.Enabled = true;
            dulceria.TipodeDulceSeleccionado(cmbTipoDulce.SelectedItem.ToString());
            dulceria.LlenarItemsDulce(cmbDulce);
        }

        private void cmbDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTipoDulce.Text = cmbTipoDulce.SelectedItem.ToString();
            txtDulce.Text = cmbDulce.SelectedItem.ToString();
            dulceria.DulceSeleccionado(cmbDulce.SelectedItem.ToString());
            dulceria.LlenarTxtMarca(txtMarca);
            dulceria.LlenarTxtPrecio(txtPrecio);
            txtTipoDulce.Enabled = true;
            txtDulce.Enabled = true;
            txtMarca.Enabled = true;
            txtPrecio.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dulceria.Modificar(cmbDulce.SelectedItem.ToString(), txtTipoDulce.Text, 
                txtDulce.Text, txtMarca.Text, Convert.ToInt32(txtPrecio.Text));
            cmbTipoDulce.Items.Clear();
            cmbDulce.Items.Clear();
            txtTipoDulce.Clear();
            txtDulce.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbDulce.Enabled = false;
            txtTipoDulce.Enabled = false;
            txtDulce.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecio.Enabled = false;
            btnLimpiar.Enabled = false;
            btnModificar.Enabled = false;
            //dulceria.LlenarItemsTipoDulce(cmbTipoDulce);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoDulce.Items.Clear();
            cmbDulce.Items.Clear();
            txtTipoDulce.Clear();
            txtDulce.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbDulce.Enabled = false;
            txtTipoDulce.Enabled = false;
            txtDulce.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecio.Enabled = false;
            btnLimpiar.Enabled = false;
            btnModificar.Enabled = false;
            //dulceria.LlenarItemsTipoDulce(cmbTipoDulce);
        }

        private void cmbTipoDulce_Click(object sender, EventArgs e)
        {
            cmbTipoDulce.Items.Clear();
            dulceria.LlenarItemsTipoDulce(cmbTipoDulce);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
