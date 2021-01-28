using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemexApp
{
    public partial class frmTaquilla : Form
    {
        private int sumaTotal = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);

        const int GRIP_SIZE = 15;
        public bool visible = false;

        public frmTaquilla()
        {
            InitializeComponent();
        }

        //SqlConnection conexion;
        ConexionTaquilla taquilla = new ConexionTaquilla();

        private void frmTaquilla_Load(object sender, EventArgs e)
        {
            taquilla.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
            taquilla.LlenarItemsPelicula(cmbPelícula);
        }

        private void frmTaquilla_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cmbPelícula_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbIdioma.Items.Clear();
            cmbFuncion.Items.Clear();
            txtCantidad.Clear();
            cmbFuncion.Enabled = false;
            txtCantidad.Enabled = false;
            btnComprar.Enabled = false;
            taquilla.PeliculaSeleccionada(cmbPelícula.SelectedItem.ToString());
            taquilla.LlenarItemsIdioma(cmbIdioma);
            cmbIdioma.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void cmbIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbFuncion.Items.Clear();
            txtCantidad.Clear();
            txtCantidad.Enabled = false;
            taquilla.IdiomaSeleccionado(cmbIdioma.SelectedItem.ToString());
            taquilla.LlenarItemsFuncion(cmbFuncion);
            cmbFuncion.Enabled = true;
        }

        private void cmbFuncion_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                string preciofinal = taquilla.Comprar
                    (cmbPelícula.SelectedItem.ToString(), 
                    Convert.ToInt32(txtCantidad.Text));

                bool band = taquilla.LlenarCompra(cmbPelícula.SelectedItem.ToString(),
                    cmbIdioma.SelectedItem.ToString(), cmbFuncion.SelectedItem.ToString(),
                    preciofinal, Convert.ToInt32(txtCantidad.Text));

                if (band)
                {
                    dgvTaquilla.Rows.Add(cmbPelícula.SelectedItem.ToString(),
                    cmbIdioma.SelectedItem.ToString(),
                    cmbFuncion.SelectedItem.ToString(), txtCantidad.Text,
                    preciofinal);

                    sumaTotal = sumaTotal + Convert.ToInt32(taquilla.Comprar(cmbPelícula.SelectedItem.ToString(),
                        Convert.ToInt32(txtCantidad.Text)));
                    txtPago.Enabled = true;
                    btnLimpiarDgv.Enabled = true;
                }

                lblTotal.Visible = true;
                txtTotal.Visible = true;
                txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + Convert.ToInt32(preciofinal)).ToString();

                LimpiarTodo();
            }
            catch (Exception)
            {
                MessageBox.Show("Indique la cantidad de boletos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarTodo()
        {
            cmbPelícula.Items.Clear();
            cmbIdioma.Items.Clear();
            cmbFuncion.Items.Clear();
            txtCantidad.Clear();
            btnComprar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnCompraFinal_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Compra realizada por $" + sumaTotal + " pesos"
                + "\n"
                + "\nPagó con $" + txtPago.Text + " pesos"
                + "\n"
                + "\nSu cambio es de $" + (Convert.ToInt32(txtPago.Text) - sumaTotal) + " pesos");
                dgvTaquilla.Rows.Clear();
                LimpiarTotal();
                sumaTotal = 0;
                btnCompraFinal.Enabled = false;
                btnLimpiarDgv.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Indique con cuánto va a pagar el cliente");
            }
            
        }

        private void btnLimpiarDgv_Click(object sender, EventArgs e)
        {
            dgvTaquilla.Rows.Clear();
            LimpiarTotal();
            sumaTotal = 0;
            btnCompraFinal.Enabled = false;
            btnLimpiarDgv.Enabled = false;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            btnComprar.Enabled = true;
        }

        private void cmbPelícula_Click(object sender, EventArgs e)
        {
            cmbPelícula.Items.Clear();
            taquilla.LlenarItemsPelicula(cmbPelícula);
        }

        private void LimpiarTotal()
        {
            lblTotal.Visible = false;
            txtTotal.Visible = false;
            txtTotal.Text = "0";

            txtPago.Clear();
            txtPago.Enabled = false;
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
    }
}
