namespace CinemexApp
{
    partial class frmModificarDulce
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
            this.gbxPrincipal = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDulce = new System.Windows.Forms.TextBox();
            this.lblDulce = new System.Windows.Forms.Label();
            this.cmbTipoDulce = new System.Windows.Forms.ComboBox();
            this.cmbDulce = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtTipoDulce = new System.Windows.Forms.TextBox();
            this.lblTipoDulce = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDulceSelect = new System.Windows.Forms.Label();
            this.lblTipoDulceSelect = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.pbxLogoCinemex = new System.Windows.Forms.PictureBox();
            this.gbxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.gbxPrincipal.Controls.Add(this.btnLimpiar);
            this.gbxPrincipal.Controls.Add(this.txtDulce);
            this.gbxPrincipal.Controls.Add(this.lblDulce);
            this.gbxPrincipal.Controls.Add(this.cmbTipoDulce);
            this.gbxPrincipal.Controls.Add(this.cmbDulce);
            this.gbxPrincipal.Controls.Add(this.txtPrecio);
            this.gbxPrincipal.Controls.Add(this.lblPrecio);
            this.gbxPrincipal.Controls.Add(this.txtTipoDulce);
            this.gbxPrincipal.Controls.Add(this.lblTipoDulce);
            this.gbxPrincipal.Controls.Add(this.txtMarca);
            this.gbxPrincipal.Controls.Add(this.btnModificar);
            this.gbxPrincipal.Controls.Add(this.lblDulceSelect);
            this.gbxPrincipal.Controls.Add(this.lblTipoDulceSelect);
            this.gbxPrincipal.Controls.Add(this.lblMarca);
            this.gbxPrincipal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrincipal.Location = new System.Drawing.Point(12, 35);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Size = new System.Drawing.Size(333, 311);
            this.gbxPrincipal.TabIndex = 16;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "Modificar dulces";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(244, 265);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDulce
            // 
            this.txtDulce.Enabled = false;
            this.txtDulce.Location = new System.Drawing.Point(121, 143);
            this.txtDulce.Name = "txtDulce";
            this.txtDulce.Size = new System.Drawing.Size(198, 23);
            this.txtDulce.TabIndex = 4;
            // 
            // lblDulce
            // 
            this.lblDulce.AutoSize = true;
            this.lblDulce.Location = new System.Drawing.Point(11, 146);
            this.lblDulce.Name = "lblDulce";
            this.lblDulce.Size = new System.Drawing.Size(45, 15);
            this.lblDulce.TabIndex = 22;
            this.lblDulce.Text = "Dulce";
            // 
            // cmbTipoDulce
            // 
            this.cmbTipoDulce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDulce.FormattingEnabled = true;
            this.cmbTipoDulce.Location = new System.Drawing.Point(119, 29);
            this.cmbTipoDulce.Name = "cmbTipoDulce";
            this.cmbTipoDulce.Size = new System.Drawing.Size(200, 23);
            this.cmbTipoDulce.TabIndex = 1;
            this.cmbTipoDulce.SelectedValueChanged += new System.EventHandler(this.cmbTipoDulce_SelectedValueChanged);
            this.cmbTipoDulce.Click += new System.EventHandler(this.cmbTipoDulce_Click);
            // 
            // cmbDulce
            // 
            this.cmbDulce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDulce.Enabled = false;
            this.cmbDulce.FormattingEnabled = true;
            this.cmbDulce.Location = new System.Drawing.Point(119, 67);
            this.cmbDulce.Name = "cmbDulce";
            this.cmbDulce.Size = new System.Drawing.Size(200, 23);
            this.cmbDulce.TabIndex = 2;
            this.cmbDulce.SelectedValueChanged += new System.EventHandler(this.cmbDulce_SelectedValueChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(119, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 23);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(11, 221);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 15);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio";
            // 
            // txtTipoDulce
            // 
            this.txtTipoDulce.Enabled = false;
            this.txtTipoDulce.Location = new System.Drawing.Point(119, 105);
            this.txtTipoDulce.Name = "txtTipoDulce";
            this.txtTipoDulce.Size = new System.Drawing.Size(200, 23);
            this.txtTipoDulce.TabIndex = 3;
            // 
            // lblTipoDulce
            // 
            this.lblTipoDulce.AutoSize = true;
            this.lblTipoDulce.Location = new System.Drawing.Point(11, 108);
            this.lblTipoDulce.Name = "lblTipoDulce";
            this.lblTipoDulce.Size = new System.Drawing.Size(97, 15);
            this.lblTipoDulce.TabIndex = 13;
            this.lblTipoDulce.Text = "Tipo de dulce:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(119, 180);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 23);
            this.txtMarca.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(146, 265);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDulceSelect
            // 
            this.lblDulceSelect.AutoSize = true;
            this.lblDulceSelect.Location = new System.Drawing.Point(11, 70);
            this.lblDulceSelect.Name = "lblDulceSelect";
            this.lblDulceSelect.Size = new System.Drawing.Size(45, 15);
            this.lblDulceSelect.TabIndex = 9;
            this.lblDulceSelect.Text = "Dulce";
            // 
            // lblTipoDulceSelect
            // 
            this.lblTipoDulceSelect.AutoSize = true;
            this.lblTipoDulceSelect.Location = new System.Drawing.Point(11, 32);
            this.lblTipoDulceSelect.Name = "lblTipoDulceSelect";
            this.lblTipoDulceSelect.Size = new System.Drawing.Size(95, 15);
            this.lblTipoDulceSelect.TabIndex = 5;
            this.lblTipoDulceSelect.Text = "Tipo de Dulce";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(11, 183);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 15);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(376, 35);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(84, 15);
            this.lblEmpleado.TabIndex = 21;
            this.lblEmpleado.Text = "Empleado...";
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(369, 72);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(308, 204);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 20;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // frmModificarDulce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(738, 351);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.pbxLogoCinemex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarDulce";
            this.Text = "frmModificarDulce";
            this.Load += new System.EventHandler(this.frmModificarDulce_Load);
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtTipoDulce;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTipoDulce;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblDulceSelect;
        private System.Windows.Forms.Label lblTipoDulceSelect;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.PictureBox pbxLogoCinemex;
        private System.Windows.Forms.TextBox txtDulce;
        private System.Windows.Forms.Label lblDulce;
        private System.Windows.Forms.ComboBox cmbTipoDulce;
        private System.Windows.Forms.ComboBox cmbDulce;
        private System.Windows.Forms.Button btnLimpiar;
    }
}