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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresarPlataforma = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlChildForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.Color.White;
            this.BtnIngreso.Location = new System.Drawing.Point(0, 0);
            this.BtnIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(264, 41);
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
            this.SloganCinemex.Location = new System.Drawing.Point(160, 9);
            this.SloganCinemex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SloganCinemex.Name = "SloganCinemex";
            this.SloganCinemex.Size = new System.Drawing.Size(323, 37);
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
            this.lblCerrar.Location = new System.Drawing.Point(1093, 11);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(33, 37);
            this.lblCerrar.TabIndex = 4;
            this.lblCerrar.Text = "X";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(1003, 11);
            this.lblMinimizar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinimizar.Size = new System.Drawing.Size(39, 37);
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
            this.pcLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(1143, 204);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 6;
            this.pcLogo.TabStop = false;
            this.pcLogo.Click += new System.EventHandler(this.pcLogo_Click);
            this.pcLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcLogo_MouseDown_1);
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.ForeColor = System.Drawing.Color.White;
            this.lblMinimo.Location = new System.Drawing.Point(1007, 11);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(28, 28);
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
            this.lblCerra.Location = new System.Drawing.Point(1093, 11);
            this.lblCerra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerra.Name = "lblCerra";
            this.lblCerra.Size = new System.Drawing.Size(24, 28);
            this.lblCerra.TabIndex = 8;
            this.lblCerra.Text = "X";
            this.lblCerra.Click += new System.EventHandler(this.lblCerra_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSide.Controls.Add(this.BtnIngreso);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 204);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(266, 395);
            this.pnlSide.TabIndex = 9;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.SloganCinemex);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(266, 542);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(877, 57);
            this.pnlBottom.TabIndex = 11;
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlChildForms.Controls.Add(this.lblError);
            this.pnlChildForms.Controls.Add(this.btnIngresarPlataforma);
            this.pnlChildForms.Controls.Add(this.pnl2);
            this.pnlChildForms.Controls.Add(this.pnl1);
            this.pnlChildForms.Controls.Add(this.lblPassword);
            this.pnlChildForms.Controls.Add(this.lblUser);
            this.pnlChildForms.Controls.Add(this.txtPassword);
            this.pnlChildForms.Controls.Add(this.txtUser);
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(266, 204);
            this.pnlChildForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(877, 338);
            this.pnlChildForms.TabIndex = 12;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(647, 294);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 22;
            // 
            // btnIngresarPlataforma
            // 
            this.btnIngresarPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarPlataforma.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPlataforma.ForeColor = System.Drawing.Color.White;
            this.btnIngresarPlataforma.Location = new System.Drawing.Point(307, 274);
            this.btnIngresarPlataforma.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarPlataforma.Name = "btnIngresarPlataforma";
            this.btnIngresarPlataforma.Size = new System.Drawing.Size(211, 28);
            this.btnIngresarPlataforma.TabIndex = 21;
            this.btnIngresarPlataforma.Text = "Ingresar Plataforma";
            this.btnIngresarPlataforma.UseVisualStyleBackColor = true;
            this.btnIngresarPlataforma.Visible = false;
            this.btnIngresarPlataforma.Click += new System.EventHandler(this.btnIngresarPlataforma_Click);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Black;
            this.pnl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl2.Location = new System.Drawing.Point(219, 240);
            this.pnl2.Margin = new System.Windows.Forms.Padding(4);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(400, 1);
            this.pnl2.TabIndex = 20;
            this.pnl2.Visible = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Black;
            this.pnl1.Location = new System.Drawing.Point(219, 167);
            this.pnl1.Margin = new System.Windows.Forms.Padding(4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(400, 1);
            this.pnl1.TabIndex = 19;
            this.pnl1.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(215, 217);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 17);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(221, 144);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(27, 20);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "ID:";
            this.lblUser.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(301, 218);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(380, 15);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "Prueba";
            this.txtPassword.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(301, 146);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(380, 15);
            this.txtUser.TabIndex = 14;
            this.txtUser.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1143, 599);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlChildForms.ResumeLayout(false);
            this.pnlChildForms.PerformLayout();
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
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresarPlataforma;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.TextBox txtUser;
    }
}