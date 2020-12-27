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
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
            this.gbxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(492, 89);
            this.pbxLogoCinemex.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(411, 251);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 0;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(501, 43);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(107, 20);
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
            this.gbxPrincipal.Location = new System.Drawing.Point(16, 43);
            this.gbxPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPrincipal.Size = new System.Drawing.Size(444, 350);
            this.gbxPrincipal.TabIndex = 1;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "Venta de boletos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(251, 228);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 26);
            this.txtCantidad.TabIndex = 14;
            // 
            // lblCantidadBoletos
            // 
            this.lblCantidadBoletos.AutoSize = true;
            this.lblCantidadBoletos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadBoletos.Location = new System.Drawing.Point(27, 231);
            this.lblCantidadBoletos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadBoletos.Name = "lblCantidadBoletos";
            this.lblCantidadBoletos.Size = new System.Drawing.Size(175, 20);
            this.lblCantidadBoletos.TabIndex = 13;
            this.lblCantidadBoletos.Text = "Cantidad de boletos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(316, 295);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnComprar.Enabled = false;
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(203, 295);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 28);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Enabled = false;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(125, 105);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(289, 26);
            this.cmbIdioma.TabIndex = 10;
            this.cmbIdioma.SelectedValueChanged += new System.EventHandler(this.cmbIdioma_SelectedValueChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(27, 108);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(65, 20);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.Enabled = false;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Location = new System.Drawing.Point(125, 165);
            this.cmbFuncion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(289, 26);
            this.cmbFuncion.TabIndex = 8;
            this.cmbFuncion.SelectedValueChanged += new System.EventHandler(this.cmbFuncion_SelectedValueChanged);
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.ForeColor = System.Drawing.Color.White;
            this.lblPelicula.Location = new System.Drawing.Point(27, 49);
            this.lblPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(75, 20);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Película";
            // 
            // cmbPelícula
            // 
            this.cmbPelícula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelícula.FormattingEnabled = true;
            this.cmbPelícula.Location = new System.Drawing.Point(125, 46);
            this.cmbPelícula.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPelícula.Name = "cmbPelícula";
            this.cmbPelícula.Size = new System.Drawing.Size(289, 26);
            this.cmbPelícula.TabIndex = 6;
            this.cmbPelícula.SelectedValueChanged += new System.EventHandler(this.cmbPelícula_SelectedValueChanged);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.ForeColor = System.Drawing.Color.White;
            this.lblFuncion.Location = new System.Drawing.Point(27, 169);
            this.lblFuncion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(74, 20);
            this.lblFuncion.TabIndex = 7;
            this.lblFuncion.Text = "Función";
            // 
            // frmTaquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(996, 434);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.pbxLogoCinemex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}