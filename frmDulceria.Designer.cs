namespace CinemexApp
{
    partial class frmDulceria
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
            this.gbxPrincipal = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidadBoletos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.cmbDulce = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.cmbTipoDeDulce = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxLogoCinemex = new System.Windows.Forms.PictureBox();
            this.dgvDulces = new System.Windows.Forms.DataGridView();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDulce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarDgv = new System.Windows.Forms.Button();
            this.btnCompraFinal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDulces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(376, 35);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 17);
            this.lblEmpleado.TabIndex = 13;
            this.lblEmpleado.Text = "Empleado...";
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.gbxPrincipal.Controls.Add(this.txtMarca);
            this.gbxPrincipal.Controls.Add(this.txtCantidad);
            this.gbxPrincipal.Controls.Add(this.lblCantidadBoletos);
            this.gbxPrincipal.Controls.Add(this.btnLimpiar);
            this.gbxPrincipal.Controls.Add(this.btnComprar);
            this.gbxPrincipal.Controls.Add(this.cmbDulce);
            this.gbxPrincipal.Controls.Add(this.lblIdioma);
            this.gbxPrincipal.Controls.Add(this.lblPelicula);
            this.gbxPrincipal.Controls.Add(this.cmbTipoDeDulce);
            this.gbxPrincipal.Controls.Add(this.lblFuncion);
            this.gbxPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrincipal.ForeColor = System.Drawing.Color.White;
            this.gbxPrincipal.Location = new System.Drawing.Point(12, 35);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Size = new System.Drawing.Size(333, 284);
            this.gbxPrincipal.TabIndex = 12;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "Venta de dulces";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(110, 131);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(202, 25);
            this.txtMarca.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(152, 185);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 25);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidadBoletos
            // 
            this.lblCantidadBoletos.AutoSize = true;
            this.lblCantidadBoletos.Location = new System.Drawing.Point(38, 188);
            this.lblCantidadBoletos.Name = "lblCantidadBoletos";
            this.lblCantidadBoletos.Size = new System.Drawing.Size(60, 17);
            this.lblCantidadBoletos.TabIndex = 13;
            this.lblCantidadBoletos.Text = "Cantidad";
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
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnComprar.Enabled = false;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Location = new System.Drawing.Point(152, 240);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 38);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Agregar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // cmbDulce
            // 
            this.cmbDulce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDulce.Enabled = false;
            this.cmbDulce.FormattingEnabled = true;
            this.cmbDulce.Location = new System.Drawing.Point(110, 88);
            this.cmbDulce.Name = "cmbDulce";
            this.cmbDulce.Size = new System.Drawing.Size(202, 25);
            this.cmbDulce.TabIndex = 2;
            this.cmbDulce.SelectedValueChanged += new System.EventHandler(this.cmbDulce_SelectedValueChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(55, 91);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(43, 17);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Dulce:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(9, 40);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(91, 17);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Tipo de dulce:";
            // 
            // cmbTipoDeDulce
            // 
            this.cmbTipoDeDulce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeDulce.FormattingEnabled = true;
            this.cmbTipoDeDulce.Location = new System.Drawing.Point(110, 37);
            this.cmbTipoDeDulce.Name = "cmbTipoDeDulce";
            this.cmbTipoDeDulce.Size = new System.Drawing.Size(202, 25);
            this.cmbTipoDeDulce.TabIndex = 1;
            this.cmbTipoDeDulce.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeDulce_SelectedIndexChanged);
            this.cmbTipoDeDulce.SelectedValueChanged += new System.EventHandler(this.cmbTipoDeDulce_SelectedValueChanged);
            this.cmbTipoDeDulce.Click += new System.EventHandler(this.cmbTipoDeDulce_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(52, 134);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(48, 17);
            this.lblFuncion.TabIndex = 7;
            this.lblFuncion.Text = "Marca:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnCerrar.Image = global::CinemexApp.Properties.Resources.baseline_disabled_by_default_white_18dp;
            this.btnCerrar.Location = new System.Drawing.Point(771, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 24);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(626, 35);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(172, 117);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 11;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // dgvDulces
            // 
            this.dgvDulces.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDulces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDulces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTipo,
            this.ColumnDulce,
            this.ColumnMarca,
            this.ColumnPrecio});
            this.dgvDulces.Location = new System.Drawing.Point(351, 158);
            this.dgvDulces.Name = "dgvDulces";
            this.dgvDulces.Size = new System.Drawing.Size(447, 161);
            this.dgvDulces.TabIndex = 15;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo de dulce";
            this.ColumnTipo.Name = "ColumnTipo";
            // 
            // ColumnDulce
            // 
            this.ColumnDulce.HeaderText = "Dulce";
            this.ColumnDulce.Name = "ColumnDulce";
            this.ColumnDulce.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
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
            this.btnLimpiarDgv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDgv.ForeColor = System.Drawing.Color.DimGray;
            this.btnLimpiarDgv.Location = new System.Drawing.Point(723, 325);
            this.btnLimpiarDgv.Name = "btnLimpiarDgv";
            this.btnLimpiarDgv.Size = new System.Drawing.Size(74, 32);
            this.btnLimpiarDgv.TabIndex = 16;
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
            this.btnCompraFinal.Location = new System.Drawing.Point(643, 325);
            this.btnCompraFinal.Name = "btnCompraFinal";
            this.btnCompraFinal.Size = new System.Drawing.Size(74, 32);
            this.btnCompraFinal.TabIndex = 17;
            this.btnCompraFinal.Text = "Comprar";
            this.btnCompraFinal.UseVisualStyleBackColor = false;
            this.btnCompraFinal.Click += new System.EventHandler(this.btnCompraFinal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(379, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 22;
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(561, 333);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(76, 20);
            this.txtPago.TabIndex = 25;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.White;
            this.lblPago.Location = new System.Drawing.Point(367, 334);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(188, 16);
            this.lblPago.TabIndex = 24;
            this.lblPago.Text = "Indique con cuánto va a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(544, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 27;
            this.txtTotal.Text = "0";
            this.txtTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(499, 133);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // frmDulceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(810, 359);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompraFinal);
            this.Controls.Add(this.btnLimpiarDgv);
            this.Controls.Add(this.dgvDulces);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.pbxLogoCinemex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDulceria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDulceria";
            this.Load += new System.EventHandler(this.frmDulceria_Load);
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDulces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidadBoletos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ComboBox cmbDulce;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cmbTipoDeDulce;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.PictureBox pbxLogoCinemex;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDulces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDulce;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
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