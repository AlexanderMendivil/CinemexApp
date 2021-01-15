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
    public partial class frmEliminarDulceria : Form
    {
        public frmEliminarDulceria()
        {
            InitializeComponent();
        }
        ConexionDulceria dulceria = new ConexionDulceria();

        private void frmEliminarDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        private void cmbTipoDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            dulceria.TipodeDulceSeleccionado(cmbTipoDulce.SelectedItem.ToString());
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbDulce.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBorrar.Enabled = false;
            dulceria.LlenarItemsDulce(cmbDulce);
        }

        private void cmbDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            dulceria.DulceSeleccionado(cmbDulce.SelectedItem.ToString());
            dulceria.LlenarTxtMarca(txtMarca);
            dulceria.LlenarTxtPrecio(txtPrecio);
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dulceria.Eliminar(cmbDulce.SelectedItem.ToString());
            cmbTipoDulce.Items.Clear();
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbDulce.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimpiar.Enabled = false;
            //dulceria.LlenarItemsTipoDulce(cmbTipoDulce);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoDulce.Items.Clear();
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbDulce.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimpiar.Enabled = false;
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
