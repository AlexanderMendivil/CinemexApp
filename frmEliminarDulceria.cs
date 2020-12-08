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
    public partial class frmEliminarDulceria : Form
    {
        public frmEliminarDulceria()
        {
            InitializeComponent();
        }

        ConexionDulceria dulceria = new ConexionDulceria();
        private void frmEliminarDulceria_Load(object sender, EventArgs e)
        {
            dulceria.LlenarNombreEmpleado(lblEmpleado, DatosEmpleado.idEmpleado);
        }
    }
}
