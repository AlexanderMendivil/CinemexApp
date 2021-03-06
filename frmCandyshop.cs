﻿using System;
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
    public partial class frmCandyshop : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmCandyshop()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 100);
            pnlContainerDulceria.Controls.Add(leftBorderBtn);
            InitializeComponent();
        }
        private struct RGBColors
        {
            public static Color color5 = Color.White;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
                //iconCurrentChildForm.Visible = true;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void AbrirForm<SubForm>() where SubForm : Form, new()
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
        }
        private void btnModificarDulceria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirForm<frmModificarDulce>();
        }

        private void btnAgregarDulceria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirForm<frmAgregarDulceria>();
        }

        private void btnConsultarDulceria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirForm<frmDulceria>();
        }

        private void btnEliminarDulceria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirForm<frmEliminarDulceria>();
        }
    }
}
