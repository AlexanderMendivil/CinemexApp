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
    public partial class frmDulceria : Form
    {
        public frmDulceria()
        {
            InitializeComponent();
        }

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
    }
}
