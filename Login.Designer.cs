namespace CinemexApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.SloganCinemex = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblCerra = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnTaquilla = new System.Windows.Forms.Button();
            this.btnDulceria = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlChildForms = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.Color.White;
            this.BtnIngreso.Location = new System.Drawing.Point(0, 0);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(198, 33);
            this.BtnIngreso.TabIndex = 1;
            this.BtnIngreso.Text = "Ingresar";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // SloganCinemex
            // 
            this.SloganCinemex.AutoSize = true;
            this.SloganCinemex.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SloganCinemex.ForeColor = System.Drawing.Color.White;
            this.SloganCinemex.Location = new System.Drawing.Point(120, 7);
            this.SloganCinemex.Name = "SloganCinemex";
            this.SloganCinemex.Size = new System.Drawing.Size(247, 30);
            this.SloganCinemex.TabIndex = 3;
            this.SloganCinemex.Text = "“Esta es la magia del cine”";
            this.SloganCinemex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.White;
            this.lblCerrar.Location = new System.Drawing.Point(820, 9);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(25, 30);
            this.lblCerrar.TabIndex = 4;
            this.lblCerrar.Text = "X";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(752, 9);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinimizar.Size = new System.Drawing.Size(31, 30);
            this.lblMinimizar.TabIndex = 5;
            this.lblMinimizar.Text = "__";
            // 
            // pcLogo
            // 
            this.pcLogo.BackgroundImage = global::CinemexApp.Properties.Resources.logoCine;
            this.pcLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcLogo.Image = global::CinemexApp.Properties.Resources.logoCine;
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(857, 166);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 6;
            this.pcLogo.TabStop = false;
            this.pcLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcLogo_MouseDown_1);
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.ForeColor = System.Drawing.Color.White;
            this.lblMinimo.Location = new System.Drawing.Point(755, 9);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(24, 21);
            this.lblMinimo.TabIndex = 7;
            this.lblMinimo.Text = "__";
            this.lblMinimo.Click += new System.EventHandler(this.lblMinimo_Click);
            // 
            // lblCerra
            // 
            this.lblCerra.AutoSize = true;
            this.lblCerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerra.ForeColor = System.Drawing.Color.White;
            this.lblCerra.Location = new System.Drawing.Point(820, 9);
            this.lblCerra.Name = "lblCerra";
            this.lblCerra.Size = new System.Drawing.Size(19, 21);
            this.lblCerra.TabIndex = 8;
            this.lblCerra.Text = "X";
            this.lblCerra.Click += new System.EventHandler(this.lblCerra_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSide.Controls.Add(this.pnlSubMenu);
            this.pnlSide.Controls.Add(this.BtnIngreso);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 166);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 321);
            this.pnlSide.TabIndex = 9;
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlSubMenu.Controls.Add(this.btnTaquilla);
            this.pnlSubMenu.Controls.Add(this.btnDulceria);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 33);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(198, 68);
            this.pnlSubMenu.TabIndex = 2;
            // 
            // btnTaquilla
            // 
            this.btnTaquilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaquilla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnTaquilla.Location = new System.Drawing.Point(0, 32);
            this.btnTaquilla.Name = "btnTaquilla";
            this.btnTaquilla.Size = new System.Drawing.Size(198, 31);
            this.btnTaquilla.TabIndex = 11;
            this.btnTaquilla.Text = "Taquilla";
            this.btnTaquilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaquilla.UseVisualStyleBackColor = true;
            this.btnTaquilla.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnDulceria
            // 
            this.btnDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDulceria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDulceria.ForeColor = System.Drawing.Color.White;
            this.btnDulceria.Location = new System.Drawing.Point(0, 0);
            this.btnDulceria.Name = "btnDulceria";
            this.btnDulceria.Size = new System.Drawing.Size(198, 32);
            this.btnDulceria.TabIndex = 10;
            this.btnDulceria.Text = "Dulceriaía";
            this.btnDulceria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDulceria.UseVisualStyleBackColor = true;
            this.btnDulceria.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.SloganCinemex);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(200, 441);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(657, 46);
            this.pnlBottom.TabIndex = 11;
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(200, 166);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(657, 275);
            this.pnlChildForms.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(857, 487);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.lblCerra);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.pcLogo);
            this.Controls.Add(this.lblMinimizar);
            this.Controls.Add(this.lblCerrar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.Label SloganCinemex;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblCerra;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Button btnTaquilla;
        private System.Windows.Forms.Button btnDulceria;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlChildForms;
    }
}