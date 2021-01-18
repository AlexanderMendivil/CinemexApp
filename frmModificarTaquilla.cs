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
    public partial class frmModificarTaquilla : Form
    {
        public frmModificarTaquilla()
        {
            InitializeComponent();
        }

        ConexionTaquilla taquilla = new ConexionTaquilla();

        private void frmModificarTaquilla_Load(object sender, EventArgs e)
        {
            taquilla.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPelicula_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPelicula_Click(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();
            taquilla.LlenarItemsPelicula(cmbPelicula);
            txtNombre.Enabled = true;
            txtAnioPel.Enabled = true;
            txtGenero.Enabled = true;
            txtDirector.Enabled = true;
            txtDuracion.Enabled = true;
            btnModificar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            taquilla.Modificar(cmbPelicula.SelectedItem.ToString(), txtNombre.Text, txtAnioPel.Text, txtGenero.Text, txtDirector.Text, txtDuracion.Text);
            Limpiar();
        }

        private void Limpiar()
        {
            cmbPelicula.Items.Clear();
            txtNombre.Clear();
            txtAnioPel.Clear();
            txtGenero.Clear();
            txtDirector.Clear();
            txtDuracion.Clear();
            txtNombre.Enabled = false;
            txtAnioPel.Enabled = false;
            txtGenero.Enabled = false;
            txtDirector.Enabled = false;
            txtDuracion.Enabled = false;
            btnModificar.Enabled = false;
            btnLimpiar.Enabled = false;
        }
    }
}
