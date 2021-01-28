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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvTaquilla = new System.Windows.Forms.DataGridView();
            this.ColumnPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBoletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarDgv = new System.Windows.Forms.Button();
            this.btnCompraFinal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
            this.gbxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaquilla)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(714, 42);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(175, 109);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 0;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(376, 35);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 17);
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
            this.gbxPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrincipal.ForeColor = System.Drawing.Color.White;
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
            this.txtCantidad.Size = new System.Drawing.Size(100, 25);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidadBoletos
            // 
            this.lblCantidadBoletos.AutoSize = true;
            this.lblCantidadBoletos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadBoletos.Location = new System.Drawing.Point(20, 188);
            this.lblCantidadBoletos.Name = "lblCantidadBoletos";
            this.lblCantidadBoletos.Size = new System.Drawing.Size(127, 17);
            this.lblCantidadBoletos.TabIndex = 13;
            this.lblCantidadBoletos.Text = "Cantidad de boletos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(237, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 38);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnComprar.Enabled = false;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(152, 240);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 38);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Text = "Agregar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Enabled = false;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(94, 85);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(218, 25);
            this.cmbIdioma.TabIndex = 10;
            this.cmbIdioma.SelectedValueChanged += new System.EventHandler(this.cmbIdioma_SelectedValueChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(20, 88);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(48, 17);
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
            this.cmbFuncion.Size = new System.Drawing.Size(218, 25);
            this.cmbFuncion.TabIndex = 8;
            this.cmbFuncion.SelectedValueChanged += new System.EventHandler(this.cmbFuncion_SelectedValueChanged);
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.ForeColor = System.Drawing.Color.White;
            this.lblPelicula.Location = new System.Drawing.Point(20, 40);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(51, 17);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Película";
            // 
            // cmbPelícula
            // 
            this.cmbPelícula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelícula.FormattingEnabled = true;
            this.cmbPelícula.Location = new System.Drawing.Point(94, 37);
            this.cmbPelícula.Name = "cmbPelícula";
            this.cmbPelícula.Size = new System.Drawing.Size(218, 25);
            this.cmbPelícula.TabIndex = 6;
            this.cmbPelícula.SelectedValueChanged += new System.EventHandler(this.cmbPelícula_SelectedValueChanged);
            this.cmbPelícula.Click += new System.EventHandler(this.cmbPelícula_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.ForeColor = System.Drawing.Color.White;
            this.lblFuncion.Location = new System.Drawing.Point(20, 137);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(52, 17);
            this.lblFuncion.TabIndex = 7;
            this.lblFuncion.Text = "Función";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnCerrar.Image = global::CinemexApp.Properties.Resources.baseline_disabled_by_default_white_18dp;
            this.btnCerrar.Location = new System.Drawing.Point(862, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 24);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvTaquilla
            // 
            this.dgvTaquilla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTaquilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaquilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPelicula,
            this.ColumnIdioma,
            this.ColumnFuncion,
            this.ColumnBoletos,
            this.ColumnPrecio});
            this.dgvTaquilla.Location = new System.Drawing.Point(351, 157);
            this.dgvTaquilla.Name = "dgvTaquilla";
            this.dgvTaquilla.Size = new System.Drawing.Size(544, 162);
            this.dgvTaquilla.TabIndex = 18;
            // 
            // ColumnPelicula
            // 
            this.ColumnPelicula.HeaderText = "Pelicula";
            this.ColumnPelicula.Name = "ColumnPelicula";
            this.ColumnPelicula.ReadOnly = true;
            // 
            // ColumnIdioma
            // 
            this.ColumnIdioma.HeaderText = "Idioma";
            this.ColumnIdioma.Name = "ColumnIdioma";
            this.ColumnIdioma.ReadOnly = true;
            // 
            // ColumnFuncion
            // 
            this.ColumnFuncion.HeaderText = "Funcion";
            this.ColumnFuncion.Name = "ColumnFuncion";
            this.ColumnFuncion.ReadOnly = true;
            // 
            // ColumnBoletos
            // 
            this.ColumnBoletos.HeaderText = "Boletos";
            this.ColumnBoletos.Name = "ColumnBoletos";
            this.ColumnBoletos.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio total";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // btnLimpiarDgv
            // 
            this.btnLimpiarDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiarDgv.Enabled = false;
            this.btnLimpiarDgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDgv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDgv.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarDgv.Location = new System.Drawing.Point(814, 325);
            this.btnLimpiarDgv.Name = "btnLimpiarDgv";
            this.btnLimpiarDgv.Size = new System.Drawing.Size(75, 33);
            this.btnLimpiarDgv.TabIndex = 20;
            this.btnLimpiarDgv.Text = "Limpiar";
            this.btnLimpiarDgv.UseVisualStyleBackColor = false;
            this.btnLimpiarDgv.Click += new System.EventHandler(this.btnLimpiarDgv_Click);
            // 
            // btnCompraFinal
            // 
            this.btnCompraFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnCompraFinal.Enabled = false;
            this.btnCompraFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraFinal.ForeColor = System.Drawing.Color.White;
            this.btnCompraFinal.Location = new System.Drawing.Point(729, 325);
            this.btnCompraFinal.Name = "btnCompraFinal";
            this.btnCompraFinal.Size = new System.Drawing.Size(75, 33);
            this.btnCompraFinal.TabIndex = 19;
            this.btnCompraFinal.Text = "Comprar";
            this.btnCompraFinal.UseVisualStyleBackColor = false;
            this.btnCompraFinal.Click += new System.EventHandler(this.btnCompraFinal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(379, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 21;
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(630, 332);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(76, 20);
            this.txtPago.TabIndex = 23;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.White;
            this.lblPago.Location = new System.Drawing.Point(436, 333);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(188, 16);
            this.lblPago.TabIndex = 22;
            this.lblPago.Text = "Indique con cuánto va a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(630, 125);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.Text = "0";
            this.txtTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(585, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // frmTaquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(901, 370);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarDgv);
            this.Controls.Add(this.btnCompraFinal);
            this.Controls.Add(this.dgvTaquilla);
            this.Controls.Add(this.btnCerrar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaquilla)).EndInit();
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
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvTaquilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBoletos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.Button btnLimpiarDgv;
        private System.Windows.Forms.Button btnCompraFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}