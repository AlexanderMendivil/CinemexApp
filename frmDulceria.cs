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
        string idEmpleados;

        public frmDulceria(string idEmpleado)
        {
            InitializeComponent();
            idEmpleados = idEmpleado;
        }

        SqlConnection conexion;
        ConexionDulceria dulceria = new ConexionDulceria();

        private void lblCerra_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            Owner.Visible = true;
            this.Close();
        }

        private void lblMinimo_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, idEmpleados);
            dulceria.LlenarItemsTipoDulce(cmbTipoDeDulce);
            cmbDulce.Enabled = false;
            txtCantidad.Enabled = false;
        }

        private void cmbTipoDeDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            dulceria.TipodeDulceSeleccionado(cmbTipoDeDulce.SelectedItem.ToString());
            dulceria.LlenarItemsDulce(cmbDulce);
            cmbDulce.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void cmbDulce_SelectedValueChanged(object sender, EventArgs e)
        {
            conexion = new SqlConnection("Data Source=DESKTOP-UMHCMCU;Initial Catalog=CINEMEX;Integrated Security=True");
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
                cmbDulce.Enabled = false;
                txtCantidad.Enabled = false;
                cmbDulce.Items.Clear();
                txtMarca.Clear();
                txtCantidad.Clear();
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
            cmbDulce.Enabled = false;
            txtCantidad.Enabled = false;
            cmbDulce.Items.Clear();
            txtMarca.Clear();
            txtCantidad.Clear();
        }
    }
}
