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
using System.Data.SqlClient;

namespace CinemexApp
{
    public partial class Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int Lparam);

        const int GRIP_SIZE = 15;

        //string cadenaConexion = "Data Source=LAPTOP-R35S94BS;Initial Catalog=CINEMEX;Integrated Security=True";
        //string cadenaConexion = "Data Source=DESKTOP-EAET5MJ;Initial Catalog=CINEMEX;Integrated Security=True";
        string cadenaConexion = "Data Source=DESKTOP-UMHCMCU;Initial Catalog=CINEMEX;Integrated Security=True";

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
            lblUser.Visible = true;
            lblPassword.Visible = true;
            pnl1.Visible = true;
            pnl2.Visible = true;
            txtUser.Visible = true;
            txtPassword.Visible = true;
            btnIngresarPlataforma.Visible = true;
            pnlChildForms.BackColor = Color.FromArgb(220, 81, 81);
        }


        #endregion

        private void btnIngresarPlataforma_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();
            SqlCommand comando = new SqlCommand("select idEmpleado, contrasena from EMPLEADO where idEmpleado="+txtUser.Text+ "and contrasena='" +txtPassword.Text+"'", conexion);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
            DatosEmpleado.idEmpleado = txtUser.Text;
            this.Close();
            }
            else
            {
                lblError.Text = "El usuario o contraseña son incorrectos";
            }
            }
            catch (Exception)
            {
                lblError.Enabled = true;
                lblError.Text = "Algun campo está vacio o es incorrecto";
            }
        }

        private void pcLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
