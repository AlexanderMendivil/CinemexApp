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
        }

        #region textbox
        private void txtPelicula_TextChanged(object sender, EventArgs e)
        {
            txtPelicula.Enabled = true;
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
            btnAgregar.Enabled = true;
        }
        #endregion

        #region Agregar y Limpiar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                taquilla.Agregar(rand.Next(), txtPelicula.Text, txtAnioPel.Text, txtGenero.Text,txtDirector.Text, txtDuracion.Text);
                txtPelicula.Clear();
                txtAnioPel.Clear();
                txtGenero.Clear();
                txtDirector.Clear();
                txtDuracion.Clear();
                txtPelicula.Enabled = false;
                txtAnioPel.Enabled = false;
                txtGenero.Enabled = false;
                txtDirector.Enabled = false;
                txtDuracion.Enabled = false;
                btnLimpiar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Uno de los campos ha quedado vacio o es incorrecto");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPelicula.Clear();
            txtAnioPel.Clear();
            txtGenero.Clear();
            txtDirector.Clear();
            txtDuracion.Clear();
            txtPelicula.Enabled = false;
            txtAnioPel.Enabled = false;
            txtGenero.Enabled = false;
            txtDirector.Enabled = false;
            txtDuracion.Enabled = false;
            btnLimpiar.Enabled = false;
        }
        #endregion
    }
}
