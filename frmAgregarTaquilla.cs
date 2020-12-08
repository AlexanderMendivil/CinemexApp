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
        public frmAgregarTaquilla()
        {
            InitializeComponent();
        }
        ConexionDulceria dulceria = new ConexionDulceria();
        private void frmAgregarTaquilla_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }
    }
}
