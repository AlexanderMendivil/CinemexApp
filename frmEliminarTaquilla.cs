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
    public partial class frmEliminarTaquilla : Form
    {
        public frmEliminarTaquilla()
        {
            InitializeComponent();
        }

        ConexionTaquilla taquilla = new ConexionTaquilla();
        
        private void frmEliminarTaquilla_Load(object sender, EventArgs e)
        {
            taquilla.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPelicula_SelectedValueChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void cmbPelicula_Click(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();
            taquilla.LlenarItemsPelicula(cmbPelicula);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            taquilla.Eliminar(cmbPelicula.SelectedItem.ToString());
        }
    }
}
