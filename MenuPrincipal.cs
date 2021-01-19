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

        ConexionTaquilla taquilla = new ConexionTaquilla();
        ConexionDulceria dulceria = new ConexionDulceria();

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

        //private void pbTaquilla_Click(object sender, EventArgs e)
        //{

        //    pnlContainerTaquilla.Visible = true;

        //    if (visible == false)
        //    {
        //        visible = true;
        //    }
        //    else
        //    {
        //        pnlContainerTaquilla.Visible = false;
        //        visible = false;
        //    }
        //}

        //private void pbDulceria_Click(object sender, EventArgs e)
        //{

        //    pnlContainerDulceria.Visible = true;

        //    if (visible == false)
        //    {
        //        visible = true;
        //    }
        //    else
        //    {
        //        pnlContainerDulceria.Visible = false;
        //        visible = false;
        //    }
        //}
        /*private void AbrirForm<SubForm>() where SubForm : Form, new()
        {
            Form frmChild = new Form();
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
        }*/

        private void pbTaquilla_Click(object sender, EventArgs e)
        {
            //AbrirForm<frmCartelera>();
            if (pnlBotonesCartelera.Visible == false)
            {
                pnlBotonesCartelera.Visible = true;
            }
            else
            {
                pnlBotonesCartelera.Visible = false;
            }
        }

        private void pbDulceria_Click(object sender, EventArgs e)
        {
            //AbrirForm<frmCandyshop>();
            if (pnlBotonesDulceria.Visible==false)
            {
                pnlBotonesDulceria.Visible = true;
            }
            else
            {
                pnlBotonesDulceria.Visible = false;
            }
        }

        #region Cambiando de color dulceria

        #region PictureBox
        private void pbDulceria_MouseHover(object sender, EventArgs e)
        {
            pbDulceria.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void pbDulceria_MouseLeave(object sender, EventArgs e)
        {
            pbDulceria.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void pbDulceria_MouseClick(object sender, MouseEventArgs e)
        {
            pbDulceria.BackColor = Color.FromArgb(180, 17, 43);
        }
        #endregion

        #region boton 1
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(180, 17, 43);
        }
        #endregion

        #region boton 2
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(180, 17, 43);
        }
        #endregion

        #region boton 3
        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(180, 17, 43);
        }
        #endregion

        #region boton 4
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.FromArgb(180, 17, 43);
        }
        #endregion

        #endregion

        #region Botones dulceria
        private void button1_Click(object sender, EventArgs e)
        {
            frmDulceria dulceriaComprar = new frmDulceria();
            dulceriaComprar.Enabled = true;
            dulceriaComprar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgregarDulceria dulceriaAgregar = new frmAgregarDulceria();
            dulceriaAgregar.Enabled = true;
            dulceriaAgregar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEliminarDulceria dulceriaEliminar = new frmEliminarDulceria();
            dulceriaEliminar.Enabled = true;
            dulceriaEliminar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmModificarDulce dulceriaModificar = new frmModificarDulce();
            dulceriaModificar.Enabled = true;
            dulceriaModificar.Show();
        }
        #endregion

        #region Cambiando de color taquilla

        #region PictureBox
        private void pbTaquilla_MouseHover(object sender, EventArgs e)
        {
            pbTaquilla.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void pbTaquilla_MouseLeave(object sender, EventArgs e)
        {
            pbTaquilla.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void pbTaquilla_MouseClick(object sender, MouseEventArgs e)
        {
            pbTaquilla.BackColor = Color.FromArgb(180, 17, 43);
        }


        #endregion

        #region boton 1
        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            button8.BackColor = Color.FromArgb(180, 17, 43);
        }

        #endregion

        #region boton 2
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.FromArgb(180, 17, 43);
        }

        #endregion

        #region boton 3
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            button6.BackColor = Color.FromArgb(180, 17, 43);
        }

        #endregion

        #region boton 4
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(195, 17, 43);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(207, 17, 43);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.FromArgb(180, 17, 43);
        }
        #endregion

        #endregion

        #region Botones cartelera
        private void button8_Click(object sender, EventArgs e)
        {
            frmTaquilla taquillaComprar = new frmTaquilla();
            taquillaComprar.Enabled = true;
            taquillaComprar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAgregarTaquilla taquillaAgregar = new frmAgregarTaquilla();
            taquillaAgregar.Enabled = true;
            taquillaAgregar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEliminarTaquilla taquillaEliminar = new frmEliminarTaquilla();
            taquillaEliminar.Enabled = true;
            taquillaEliminar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmModificarTaquilla taquillaModificar = new frmModificarTaquilla();
            taquillaModificar.Enabled = true;
            taquillaModificar.Show();
        }


        #endregion

        private void btnReporteTaquilla_Click(object sender, EventArgs e)
        {
            taquilla.CrearPDF();
        }

        private void btnReporteDulceria_Click(object sender, EventArgs e)
        {
            dulceria.CrearPDF();
        }
    }
}
