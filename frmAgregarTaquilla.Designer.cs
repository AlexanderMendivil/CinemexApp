﻿namespace CinemexApp
{
    partial class frmAgregarTaquilla
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.txtAnioPel = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbxLogoCinemex = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(500, 17);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 17);
            this.lblEmpleado.TabIndex = 21;
            this.lblEmpleado.Text = "Empleado...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.cmbSala);
            this.groupBox1.Controls.Add(this.txtIdioma);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblSala);
            this.groupBox1.Controls.Add(this.lblIdioma);
            this.groupBox1.Controls.Add(this.txtAnioPel);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtPelicula);
            this.groupBox1.Controls.Add(this.txtDuracion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 257);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Peliculas";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Enabled = false;
            this.txtIdioma.Location = new System.Drawing.Point(309, 73);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(136, 25);
            this.txtIdioma.TabIndex = 33;
            this.txtIdioma.TextChanged += new System.EventHandler(this.txtIdioma_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(309, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(136, 25);
            this.txtPrecio.TabIndex = 32;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(249, 150);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 17);
            this.lblPrecio.TabIndex = 31;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtHora
            // 
            this.txtHora.AcceptsTab = true;
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(309, 111);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(136, 25);
            this.txtHora.TabIndex = 30;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(249, 114);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(40, 17);
            this.lblHora.TabIndex = 29;
            this.lblHora.Text = "Hora:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(247, 37);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(35, 17);
            this.lblSala.TabIndex = 26;
            this.lblSala.Text = "Sala:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(249, 76);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(51, 17);
            this.lblIdioma.TabIndex = 27;
            this.lblIdioma.Text = "Idioma:";
            // 
            // txtAnioPel
            // 
            this.txtAnioPel.Enabled = false;
            this.txtAnioPel.Location = new System.Drawing.Point(90, 73);
            this.txtAnioPel.Name = "txtAnioPel";
            this.txtAnioPel.Size = new System.Drawing.Size(136, 25);
            this.txtAnioPel.TabIndex = 25;
            this.txtAnioPel.TextChanged += new System.EventHandler(this.txtAnioPel_TextChanged);
            // 
            // txtDirector
            // 
            this.txtDirector.Enabled = false;
            this.txtDirector.Location = new System.Drawing.Point(90, 147);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(136, 25);
            this.txtDirector.TabIndex = 24;
            this.txtDirector.TextChanged += new System.EventHandler(this.txtDirector_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Director:";
            // 
            // txtGenero
            // 
            this.txtGenero.AcceptsTab = true;
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(90, 111);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(136, 25);
            this.txtGenero.TabIndex = 21;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Genero:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(370, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(90, 34);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(136, 25);
            this.txtPelicula.TabIndex = 18;
            this.txtPelicula.TextChanged += new System.EventHandler(this.txtPelicula_TextChanged);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(90, 182);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(136, 25);
            this.txtDuracion.TabIndex = 17;
            this.txtDuracion.TextChanged += new System.EventHandler(this.txtDuracion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Duracion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(289, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 36);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pelicula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Año:";
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(500, 42);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(269, 164);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 20;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnCerrar.Image = global::CinemexApp.Properties.Resources.baseline_disabled_by_default_white_18dp;
            this.btnCerrar.Location = new System.Drawing.Point(742, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 24);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(503, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 34;
            // 
            // cmbSala
            // 
            this.cmbSala.Enabled = false;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(309, 34);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(136, 25);
            this.cmbSala.TabIndex = 34;
            this.cmbSala.SelectedValueChanged += new System.EventHandler(this.cmbSala_SelectedValueChanged);
            // 
            // frmAgregarTaquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(781, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.pbxLogoCinemex);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarTaquilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarTaquilla";
            this.Load += new System.EventHandler(this.frmAgregarTaquilla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.PictureBox pbxLogoCinemex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnioPel;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSala;
    }
}