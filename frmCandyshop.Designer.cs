namespace CinemexApp
{
    partial class frmCandyshop
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
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.pnlContainerDulceria = new System.Windows.Forms.Panel();
            this.btnEliminarDulceria = new System.Windows.Forms.Button();
            this.btnConsultarDulceria = new System.Windows.Forms.Button();
            this.btnAgregarDulceria = new System.Windows.Forms.Button();
            this.btnModificarDulceria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.pnlChildForms.SuspendLayout();
            this.pnlContainerDulceria.SuspendLayout();
            this.SuspendLayout();
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
            this.pcLogo.Size = new System.Drawing.Size(1201, 137);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 18;
            this.pcLogo.TabStop = false;
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.pnlChildForms.Controls.Add(this.label1);
            this.pnlChildForms.Controls.Add(this.pnlContainerDulceria);
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(0, 137);
            this.pnlChildForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(1201, 587);
            this.pnlChildForms.TabIndex = 22;
            // 
            // pnlContainerDulceria
            // 
            this.pnlContainerDulceria.Controls.Add(this.btnEliminarDulceria);
            this.pnlContainerDulceria.Controls.Add(this.btnConsultarDulceria);
            this.pnlContainerDulceria.Controls.Add(this.btnAgregarDulceria);
            this.pnlContainerDulceria.Controls.Add(this.btnModificarDulceria);
            this.pnlContainerDulceria.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainerDulceria.Location = new System.Drawing.Point(0, 0);
            this.pnlContainerDulceria.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainerDulceria.Name = "pnlContainerDulceria";
            this.pnlContainerDulceria.Size = new System.Drawing.Size(264, 587);
            this.pnlContainerDulceria.TabIndex = 21;
            this.pnlContainerDulceria.Visible = false;
            // 
            // btnEliminarDulceria
            // 
            this.btnEliminarDulceria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnEliminarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDulceria.Location = new System.Drawing.Point(0, 300);
            this.btnEliminarDulceria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDulceria.Name = "btnEliminarDulceria";
            this.btnEliminarDulceria.Size = new System.Drawing.Size(264, 100);
            this.btnEliminarDulceria.TabIndex = 22;
            this.btnEliminarDulceria.Text = "ELIMINAR";
            this.btnEliminarDulceria.UseVisualStyleBackColor = false;
            this.btnEliminarDulceria.Click += new System.EventHandler(this.btnEliminarDulceria_Click);
            // 
            // btnConsultarDulceria
            // 
            this.btnConsultarDulceria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnConsultarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDulceria.Location = new System.Drawing.Point(0, 200);
            this.btnConsultarDulceria.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarDulceria.Name = "btnConsultarDulceria";
            this.btnConsultarDulceria.Size = new System.Drawing.Size(264, 100);
            this.btnConsultarDulceria.TabIndex = 20;
            this.btnConsultarDulceria.Text = "COMPRAR";
            this.btnConsultarDulceria.UseVisualStyleBackColor = false;
            this.btnConsultarDulceria.Click += new System.EventHandler(this.btnConsultarDulceria_Click);
            // 
            // btnAgregarDulceria
            // 
            this.btnAgregarDulceria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnAgregarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDulceria.Location = new System.Drawing.Point(0, 100);
            this.btnAgregarDulceria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDulceria.Name = "btnAgregarDulceria";
            this.btnAgregarDulceria.Size = new System.Drawing.Size(264, 100);
            this.btnAgregarDulceria.TabIndex = 21;
            this.btnAgregarDulceria.Text = "AGREGAR";
            this.btnAgregarDulceria.UseVisualStyleBackColor = false;
            this.btnAgregarDulceria.Click += new System.EventHandler(this.btnAgregarDulceria_Click);
            // 
            // btnModificarDulceria
            // 
            this.btnModificarDulceria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnModificarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnModificarDulceria.Location = new System.Drawing.Point(0, 0);
            this.btnModificarDulceria.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDulceria.Name = "btnModificarDulceria";
            this.btnModificarDulceria.Size = new System.Drawing.Size(264, 100);
            this.btnModificarDulceria.TabIndex = 23;
            this.btnModificarDulceria.Text = "MODIFICAR";
            this.btnModificarDulceria.UseVisualStyleBackColor = false;
            this.btnModificarDulceria.Click += new System.EventHandler(this.btnModificarDulceria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(573, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 55);
            this.label1.TabIndex = 22;
            this.label1.Text = "DULCERIA";
            // 
            // frmCandyshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 724);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.pcLogo);
            this.Name = "frmCandyshop";
            this.Text = "frmCandyshop";
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.pnlChildForms.ResumeLayout(false);
            this.pnlChildForms.PerformLayout();
            this.pnlContainerDulceria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.Panel pnlContainerDulceria;
        private System.Windows.Forms.Button btnEliminarDulceria;
        private System.Windows.Forms.Button btnConsultarDulceria;
        private System.Windows.Forms.Button btnAgregarDulceria;
        private System.Windows.Forms.Button btnModificarDulceria;
        private System.Windows.Forms.Label label1;
    }
}