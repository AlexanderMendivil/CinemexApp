namespace CinemexApp
{
    partial class frmAgregarDulceria
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPrecioDulce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDulce = new System.Windows.Forms.TextBox();
            this.txtNombreDulce = new System.Windows.Forms.TextBox();
            this.lblTipoDulce = new System.Windows.Forms.Label();
            this.txtMarcaDulce = new System.Windows.Forms.TextBox();
            this.btnAgregarDulce = new System.Windows.Forms.Button();
            this.lblNombreDulce = new System.Windows.Forms.Label();
            this.lblMarcaDulce = new System.Windows.Forms.Label();
            this.pbxLogoCinemex = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).BeginInit();
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
            this.lblEmpleado.TabIndex = 14;
            this.lblEmpleado.Text = "Empleado...";
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.gbxPrincipal.Controls.Add(this.btnLimpiar);
            this.gbxPrincipal.Controls.Add(this.txtPrecioDulce);
            this.gbxPrincipal.Controls.Add(this.label1);
            this.gbxPrincipal.Controls.Add(this.txtTipoDulce);
            this.gbxPrincipal.Controls.Add(this.txtNombreDulce);
            this.gbxPrincipal.Controls.Add(this.lblTipoDulce);
            this.gbxPrincipal.Controls.Add(this.txtMarcaDulce);
            this.gbxPrincipal.Controls.Add(this.btnAgregarDulce);
            this.gbxPrincipal.Controls.Add(this.lblNombreDulce);
            this.gbxPrincipal.Controls.Add(this.lblMarcaDulce);
            this.gbxPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrincipal.ForeColor = System.Drawing.Color.White;
            this.gbxPrincipal.Location = new System.Drawing.Point(12, 35);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Size = new System.Drawing.Size(333, 311);
            this.gbxPrincipal.TabIndex = 15;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "Agregar dulces";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(240, 264);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 40);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPrecioDulce
            // 
            this.txtPrecioDulce.Enabled = false;
            this.txtPrecioDulce.Location = new System.Drawing.Point(115, 217);
            this.txtPrecioDulce.Name = "txtPrecioDulce";
            this.txtPrecioDulce.Size = new System.Drawing.Size(200, 25);
            this.txtPrecioDulce.TabIndex = 4;
            this.txtPrecioDulce.TextChanged += new System.EventHandler(this.txtPrecioDulce_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio";
            // 
            // txtTipoDulce
            // 
            this.txtTipoDulce.Location = new System.Drawing.Point(115, 49);
            this.txtTipoDulce.Name = "txtTipoDulce";
            this.txtTipoDulce.Size = new System.Drawing.Size(200, 25);
            this.txtTipoDulce.TabIndex = 1;
            this.txtTipoDulce.TextChanged += new System.EventHandler(this.txtTipoDulce_TextChanged);
            // 
            // txtNombreDulce
            // 
            this.txtNombreDulce.Enabled = false;
            this.txtNombreDulce.Location = new System.Drawing.Point(115, 104);
            this.txtNombreDulce.Name = "txtNombreDulce";
            this.txtNombreDulce.Size = new System.Drawing.Size(202, 25);
            this.txtNombreDulce.TabIndex = 2;
            this.txtNombreDulce.TextChanged += new System.EventHandler(this.txtNombreDulce_TextChanged);
            // 
            // lblTipoDulce
            // 
            this.lblTipoDulce.AutoSize = true;
            this.lblTipoDulce.Location = new System.Drawing.Point(11, 52);
            this.lblTipoDulce.Name = "lblTipoDulce";
            this.lblTipoDulce.Size = new System.Drawing.Size(91, 17);
            this.lblTipoDulce.TabIndex = 13;
            this.lblTipoDulce.Text = "Tipo de dulce:";
            // 
            // txtMarcaDulce
            // 
            this.txtMarcaDulce.Enabled = false;
            this.txtMarcaDulce.Location = new System.Drawing.Point(115, 160);
            this.txtMarcaDulce.Name = "txtMarcaDulce";
            this.txtMarcaDulce.Size = new System.Drawing.Size(200, 25);
            this.txtMarcaDulce.TabIndex = 3;
            this.txtMarcaDulce.TextChanged += new System.EventHandler(this.txtMarcaDulce_TextChanged);
            // 
            // btnAgregarDulce
            // 
            this.btnAgregarDulce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnAgregarDulce.Enabled = false;
            this.btnAgregarDulce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDulce.Location = new System.Drawing.Point(142, 264);
            this.btnAgregarDulce.Name = "btnAgregarDulce";
            this.btnAgregarDulce.Size = new System.Drawing.Size(92, 40);
            this.btnAgregarDulce.TabIndex = 5;
            this.btnAgregarDulce.Text = "Agregar";
            this.btnAgregarDulce.UseVisualStyleBackColor = false;
            this.btnAgregarDulce.Click += new System.EventHandler(this.btnAgregarDulce_Click);
            // 
            // lblNombreDulce
            // 
            this.lblNombreDulce.AutoSize = true;
            this.lblNombreDulce.Location = new System.Drawing.Point(13, 107);
            this.lblNombreDulce.Name = "lblNombreDulce";
            this.lblNombreDulce.Size = new System.Drawing.Size(57, 17);
            this.lblNombreDulce.TabIndex = 9;
            this.lblNombreDulce.Text = "Nombre";
            // 
            // lblMarcaDulce
            // 
            this.lblMarcaDulce.AutoSize = true;
            this.lblMarcaDulce.Location = new System.Drawing.Point(11, 163);
            this.lblMarcaDulce.Name = "lblMarcaDulce";
            this.lblMarcaDulce.Size = new System.Drawing.Size(48, 17);
            this.lblMarcaDulce.TabIndex = 7;
            this.lblMarcaDulce.Text = "Marca:";
            // 
            // pbxLogoCinemex
            // 
            this.pbxLogoCinemex.Image = global::CinemexApp.Properties.Resources._5ef1c4e91cfbc200047e7430;
            this.pbxLogoCinemex.Location = new System.Drawing.Point(369, 72);
            this.pbxLogoCinemex.Name = "pbxLogoCinemex";
            this.pbxLogoCinemex.Size = new System.Drawing.Size(308, 204);
            this.pbxLogoCinemex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoCinemex.TabIndex = 12;
            this.pbxLogoCinemex.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnCerrar.Image = global::CinemexApp.Properties.Resources.baseline_disabled_by_default_white_18dp;
            this.btnCerrar.Location = new System.Drawing.Point(699, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 24);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(379, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 22;
            // 
            // frmAgregarDulceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(738, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.pbxLogoCinemex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarDulceria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarDulceria";
            this.Load += new System.EventHandler(this.frmAgregarDulceria_Load);
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoCinemex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogoCinemex;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.TextBox txtPrecioDulce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoDulce;
        private System.Windows.Forms.TextBox txtNombreDulce;
        private System.Windows.Forms.TextBox txtMarcaDulce;
        private System.Windows.Forms.Label lblTipoDulce;
        private System.Windows.Forms.Button btnAgregarDulce;
        private System.Windows.Forms.Label lblNombreDulce;
        private System.Windows.Forms.Label lblMarcaDulce;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
    }
}