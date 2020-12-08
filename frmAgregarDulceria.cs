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
    public partial class frmAgregarDulceria : Form
    {
        public frmAgregarDulceria()
        {
            InitializeComponent();
        }

            ConexionDulceria dulceria = new ConexionDulceria();
        private void frmAgregarDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        private void txtIdDulce_TextChanged(object sender, EventArgs e)
        {
            txtTipoDulce.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void txtTipoDulce_TextChanged(object sender, EventArgs e)
        {
            txtNombreDulce.Enabled = true;
        }

        private void txtNombreDulce_TextChanged(object sender, EventArgs e)
        {
            txtMarcaDulce.Enabled = true;
        }

        private void txtMarcaDulce_TextChanged(object sender, EventArgs e)
        {
            txtPrecioDulce.Enabled = true;
        }

        private void txtPrecioDulce_TextChanged(object sender, EventArgs e)
        {
            btnAgregarDulce.Enabled = true;
        }

        private void btnAgregarDulce_Click(object sender, EventArgs e)
        {
            try
            {
                dulceria.Agregar(Convert.ToInt32(txtIdDulce.Text), txtTipoDulce.Text, txtNombreDulce.Text, txtMarcaDulce.Text, Convert.ToInt32(txtPrecioDulce.Text));
                txtIdDulce.Clear();
                txtTipoDulce.Clear();
                txtNombreDulce.Clear();
                txtMarcaDulce.Clear();
                txtPrecioDulce.Clear();
                txtTipoDulce.Enabled = false;
                txtNombreDulce.Enabled = false;
                txtMarcaDulce.Enabled = false;
                txtPrecioDulce.Enabled = false;
                btnAgregarDulce.Enabled = false;
                btnLimpiar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Uno de los campos ha quedado vacio o es incorrecto");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdDulce.Clear();
            txtTipoDulce.Clear();
            txtNombreDulce.Clear();
            txtMarcaDulce.Clear();
            txtPrecioDulce.Clear();
            txtTipoDulce.Enabled = false;
            txtNombreDulce.Enabled = false;
            txtMarcaDulce.Enabled = false;
            txtPrecioDulce.Enabled = false;
            btnAgregarDulce.Enabled = false;
            btnLimpiar.Enabled = false;
        }
    }
}
