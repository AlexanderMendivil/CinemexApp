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
        ConexionDulceria dulceria = new ConexionDulceria();
        private void frmEliminarTaquilla_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }
    }
}
