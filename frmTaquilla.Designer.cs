namespace CinemexApp
{
    partial class frmTaquilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaquilla));
            this.pbxLogoCinemex = new System.Windows.Forms.PictureBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.gbxPrincipal = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidadBoletos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.cmbPelícula = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblCerra = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
            this.gbxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(369, 72);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(308, 204);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 0;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(376, 35);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(84, 15);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado...";
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.gbxPrincipal.Controls.Add(this.txtCantidad);
            this.gbxPrincipal.Controls.Add(this.lblCantidadBoletos);
            this.gbxPrincipal.Controls.Add(this.btnLimpiar);
            this.gbxPrincipal.Controls.Add(this.btnComprar);
            this.gbxPrincipal.Controls.Add(this.cmbIdioma);
            this.gbxPrincipal.Controls.Add(this.lblIdioma);
            this.gbxPrincipal.Controls.Add(this.cmbFuncion);
            this.gbxPrincipal.Controls.Add(this.lblPelicula);
            this.gbxPrincipal.Controls.Add(this.cmbPelícula);
            this.gbxPrincipal.Controls.Add(this.lblFuncion);
            this.gbxPrincipal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrincipal.Location = new System.Drawing.Point(12, 35);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Size = new System.Drawing.Size(333, 284);
            this.gbxPrincipal.TabIndex = 1;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "Venta de boletos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(188, 185);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 14;
            // 
            // lblCantidadBoletos
            // 
            this.lblCantidadBoletos.AutoSize = true;
            this.lblCantidadBoletos.Location = new System.Drawing.Point(20, 188);
            this.lblCantidadBoletos.Name = "lblCantidadBoletos";
            this.lblCantidadBoletos.Size = new System.Drawing.Size(136, 15);
            this.lblCantidadBoletos.TabIndex = 13;
            this.lblCantidadBoletos.Text = "Cantidad de boletos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(237, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(152, 240);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Enabled = false;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(94, 85);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(218, 23);
            this.cmbIdioma.TabIndex = 10;
            this.cmbIdioma.SelectedValueChanged += new System.EventHandler(this.cmbIdioma_SelectedValueChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(20, 88);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(51, 15);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.Enabled = false;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Location = new System.Drawing.Point(94, 134);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(218, 23);
            this.cmbFuncion.TabIndex = 8;
            this.cmbFuncion.SelectedValueChanged += new System.EventHandler(this.cmbFuncion_SelectedValueChanged);
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(20, 40);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(60, 15);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Película";
            // 
            // cmbPelícula
            // 
            this.cmbPelícula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelícula.FormattingEnabled = true;
            this.cmbPelícula.Location = new System.Drawing.Point(94, 37);
            this.cmbPelícula.Name = "cmbPelícula";
            this.cmbPelícula.Size = new System.Drawing.Size(218, 23);
            this.cmbPelícula.TabIndex = 6;
            this.cmbPelícula.SelectedValueChanged += new System.EventHandler(this.cmbPelícula_SelectedValueChanged);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(20, 137);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(59, 15);
            this.lblFuncion.TabIndex = 7;
            this.lblFuncion.Text = "Función";
            // 
            // lblCerra
            // 
            this.lblCerra.AutoSize = true;
            this.lblCerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerra.ForeColor = System.Drawing.Color.White;
            this.lblCerra.Location = new System.Drawing.Point(708, 9);
            this.lblCerra.Name = "lblCerra";
            this.lblCerra.Size = new System.Drawing.Size(19, 21);
            this.lblCerra.TabIndex = 10;
            this.lblCerra.Text = "X";
            this.lblCerra.Click += new System.EventHandler(this.lblCerra_Click);
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.ForeColor = System.Drawing.Color.White;
            this.lblMinimo.Location = new System.Drawing.Point(643, 9);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(24, 21);
            this.lblMinimo.TabIndex = 9;
            this.lblMinimo.Text = "__";
            this.lblMinimo.Click += new System.EventHandler(this.lblMinimo_Click);
            // 
            // frmTaquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(747, 353);
            this.Controls.Add(this.lblCerra);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.pbxLogoCinemex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTaquilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAQUILLA";
            this.Load += new System.EventHandler(this.frmTaquilla_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTaquilla_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).EndInit();
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogoCinemex;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cmbPelícula;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidadBoletos;
        private System.Windows.Forms.Label lblCerra;
        private System.Windows.Forms.Label lblMinimo;
    }
}