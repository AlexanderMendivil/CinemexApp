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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LoginCine.Enabled = true;
            LoginCine.ShowDialog();
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

            pnlContainerTaquilla.Visible = true;

            if (visible == false)
            {
                visible = true;
            }
            else
            {
                pnlContainerTaquilla.Visible = false;
                visible = false;
            }
        }

        private void pbDulceria_Click(object sender, EventArgs e)
        {

            pnlContainerDulceria.Visible = true;

            if (visible == false)
            {
                visible = true;
            }
            else
            {
                pnlContainerDulceria.Visible = false;
                visible = false;
            }
        }
        private void AbrirForm<SubForm>() where SubForm : Form, new()
        {
            Form frmChild;
            frmChild = pnlChildForms.Controls.OfType<SubForm>().FirstOrDefault();

            if (frmChild == null)
            {
                frmChild = new SubForm();
                frmChild.TopLevel = false;
                frmChild.Dock = DockStyle.Fill;
                pnlChildForms.Controls.Add(frmChild);
                pnlChildForms.Tag = frmChild;
                frmChild.Show();
                frmChild.BringToFront();
            }
            else
            {
                frmChild.BringToFront();
            }
        }

        public void btnConsultarDulceria_Click(object sender, EventArgs e)
        {
            AbrirForm<frmDulceria>();
        }

        private void btnConsultarTaquilla_Click(object sender, EventArgs e)
        {
            AbrirForm<frmTaquilla>();
        }

        private void btnAgregarDulceria_Click(object sender, EventArgs e)
        {
            AbrirForm<frmAgregarDulceria>();
        }

        private void btnEliminarDulceria_Click(object sender, EventArgs e)
        {
            AbrirForm<frmEliminarDulceria>();
        }

        private void btnModificarDulceria_Click(object sender, EventArgs e)
        {
            AbrirForm<frmModificarDulce>();
        }

        private void btnModificarTaquilla_Click(object sender, EventArgs e)
        {
            AbrirForm<frmModificarTaquilla>();
        }

        private void btnElimarTaquilla_Click(object sender, EventArgs e)
        {
            AbrirForm<frmEliminarTaquilla>();
        }

        private void btnAgregarTaquilla_Click(object sender, EventArgs e)
        {
            AbrirForm<frmAgregarTaquilla>();
        }
    }
}
