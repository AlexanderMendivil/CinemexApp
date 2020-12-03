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
    public partial class MenuPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);

        const int GRIP_SIZE = 15;
        public bool visible = false;

        public Login LoginCine = new Login();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public string idEmpleado;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LoginCine.Enabled = true;
            LoginCine.ShowDialog();
            idEmpleado = LoginCine.RegresarIDEmpleado();
        }

        private void lblCerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimo_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pcLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pbTaquilla_Click(object sender, EventArgs e)
        {

            this.Enabled = false;
            this.Visible = false;

            frmTaquilla Taquilla = new frmTaquilla(idEmpleado);
            Taquilla.Enabled = true;
            Taquilla.Show();
            Taquilla.Owner = this;
        }

        private void pbDulceria_Click(object sender, EventArgs e)
        {

            this.Enabled = false;
            this.Visible = false;

            frmDulceria Dulceria = new frmDulceria(idEmpleado);
            Dulceria.Enabled = true;
            Dulceria.Show();
            Dulceria.Owner = this;
        }
    }
}
