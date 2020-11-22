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

namespace CinemexApp
{
    public partial class frmTaquilla : Form
    {
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

        private void frmTaquilla_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
