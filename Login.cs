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
    public partial class Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);

        const int GRIP_SIZE = 15;
        public bool visible = false;

        public Login()
        {
            InitializeComponent();
        }

        #region Funcionalidad form
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;
        }

        private void lblMinimo_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblCerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcLogo_MouseDown_1(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = true;

            if (visible == false)
            {
                visible = true;
            }
            else
            {
                pnlSubMenu.Visible = false;
                visible = false;
            }  
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirForm<Empleado>();
        }
        private void btnGerente_Click(object sender, EventArgs e)
        {
            AbrirForm<Gerente>();
        }
        #endregion

        private void AbrirForm<SubForm>() where SubForm: Form, new()
        {
            Form LoginEmpleado;
            LoginEmpleado = pnlChildForms.Controls.OfType<SubForm>().FirstOrDefault();

            if(LoginEmpleado == null){
                LoginEmpleado = new SubForm();
                LoginEmpleado.TopLevel = false;
                LoginEmpleado.Dock = DockStyle.Fill;
                pnlChildForms.Controls.Add(LoginEmpleado);
                pnlChildForms.Tag = LoginEmpleado;
                LoginEmpleado.Show();
                LoginEmpleado.BringToFront();
            }
            else
            {
                LoginEmpleado.BringToFront();
            }
        }

    }
}
