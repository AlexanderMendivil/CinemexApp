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
        ConexionDulceria dulceria = new ConexionDulceria();
        Random rand = new Random();

        public frmAgregarDulceria()
        {
            InitializeComponent();
        }      
        private void frmAgregarDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        #region textbox
        private void txtTipoDulce_TextChanged(object sender, EventArgs e)
        {
            txtNombreDulce.Enabled = true;
            btnLimpiar.Enabled = true;
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
        #endregion

        #region Agregar y Limpiar 
        private void btnAgregarDulce_Click(object sender, EventArgs e)
        {
            try
            {
                dulceria.Agregar(rand.Next(), txtTipoDulce.Text, txtNombreDulce.Text, txtMarcaDulce.Text, Convert.ToInt32(txtPrecioDulce.Text));
                txtTipoDulce.Clear();
                txtNombreDulce.Clear();
                txtMarcaDulce.Clear();
                txtPrecioDulce.Clear();
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
            txtTipoDulce.Clear();
            txtNombreDulce.Clear();
            txtMarcaDulce.Clear();
            txtPrecioDulce.Clear();
            txtNombreDulce.Enabled = false;
            txtMarcaDulce.Enabled = false;
            txtPrecioDulce.Enabled = false;
            btnAgregarDulce.Enabled = false;
            btnLimpiar.Enabled = false;
        }
        #endregion
    }
}
