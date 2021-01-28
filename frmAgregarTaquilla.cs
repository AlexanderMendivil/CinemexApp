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
    public partial class frmAgregarTaquilla : Form
    {
        ConexionTaquilla taquilla = new ConexionTaquilla();
        Random rand = new Random();
       
        public frmAgregarTaquilla()
        {
            InitializeComponent();
        }
        
        private void frmAgregarTaquilla_Load(object sender, EventArgs e)
        {
            taquilla.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
            LlenarcmbSala();
        }

        #region textbox
        private void txtPelicula_TextChanged(object sender, EventArgs e)
        {
            txtAnioPel.Enabled = true;
            btnLimpiar.Enabled = true;
        }
        private void txtAnioPel_TextChanged(object sender, EventArgs e)
        {
            txtGenero.Enabled = true;
        }
        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            txtDirector.Enabled = true;
        }
        private void txtDirector_TextChanged(object sender, EventArgs e)
        {
            txtDuracion.Enabled = true;
        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {
            cmbSala.Enabled = true;
        }

        private void cmbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            txtIdioma.Enabled = true;
        }

        /*private void txtSala_TextChanged(object sender, EventArgs e)
        {
            txtIdioma.Enabled = true;
        }*/

        private void txtIdioma_TextChanged(object sender, EventArgs e)
        {
            txtHora.Enabled = true;
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }
        #endregion

        #region Agregar y Limpiar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                taquilla.Agregar(rand.Next(), txtPelicula.Text, txtGenero.Text, txtAnioPel.Text, txtDirector.Text, txtDuracion.Text,
                    rand.Next(), cmbSala.SelectedItem.ToString(), txtIdioma.Text, txtHora.Text, Convert.ToInt32(txtPrecio.Text));
                LimpiarTodo();
            }
            catch (Exception)
            {
                MessageBox.Show("Uno de los campos ha quedado vacio o es incorrecto");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
        #endregion

        private void LimpiarTodo()
        {
            txtPelicula.Clear();
            txtAnioPel.Clear();
            txtGenero.Clear();
            txtDirector.Clear();
            txtDuracion.Clear();
            //txtSala.Clear();
            txtIdioma.Clear();
            txtHora.Clear();
            txtPrecio.Clear();
            txtAnioPel.Enabled = false;
            txtGenero.Enabled = false;
            txtDirector.Enabled = false;
            txtDuracion.Enabled = false;
            cmbSala.Enabled = false;
            txtIdioma.Enabled = false;
            txtHora.Enabled = false;
            txtPrecio.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void LlenarcmbSala()
        {
            cmbSala.Items.Add(1);
            cmbSala.Items.Add(2);
            cmbSala.Items.Add(3);
            cmbSala.Items.Add(4);
            cmbSala.Items.Add(5);
            cmbSala.Items.Add(6);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
