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

        public frmDulceria()
        {
            InitializeComponent();
        }

        SqlConnection conexion;
        ConexionDulceria dulceria = new ConexionDulceria();

        private void frmDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
            dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
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
            conexion = new SqlConnection("Data Source=LAPTOP-R35S94BS;Initial Catalog=CINEMEX;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select marca from DULCE where nombreDulce = '" + 
                cmbDulce.SelectedItem.ToString() + "'", conexion);
            conexion.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    txtMarca.Text = dr["marca"].ToString();
                }
            }
            conexion.Close();
            txtCantidad.Enabled = true;
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
                dulceria.Comprar(cmbDulce.SelectedItem.ToString(), Convert.ToInt32(txtCantidad.Text));
                cmbTipoDeDulce.Items.Clear();
                dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
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
            dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
            cmbDulce.Enabled = false;
            txtCantidad.Enabled = false;
            txtMarca.Enabled = false;
            btnComprar.Enabled = false;
            btnLimpiar.Enabled = false;
        }
    }
}
