namespace CinemexApp
{
    partial class frmCartelera
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
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainerCartelera = new System.Windows.Forms.Panel();
            this.btnEliminarTaquilla = new System.Windows.Forms.Button();
            this.btnConsultarTaquilla = new System.Windows.Forms.Button();
            this.btnAgregarTaquilla = new System.Windows.Forms.Button();
            this.btnModificarTaquilla = new System.Windows.Forms.Button();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pnlChildForms.SuspendLayout();
            this.pnlContainerCartelera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.pnlChildForms.Controls.Add(this.label1);
            this.pnlChildForms.Controls.Add(this.pnlContainerCartelera);
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(0, 137);
            this.pnlChildForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(1224, 588);
            this.pnlChildForms.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 55);
            this.label1.TabIndex = 22;
            this.label1.Text = "CARTELERA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlContainerCartelera
            // 
            this.pnlContainerCartelera.Controls.Add(this.btnEliminarTaquilla);
            this.pnlContainerCartelera.Controls.Add(this.btnConsultarTaquilla);
            this.pnlContainerCartelera.Controls.Add(this.btnAgregarTaquilla);
            this.pnlContainerCartelera.Controls.Add(this.btnModificarTaquilla);
            this.pnlContainerCartelera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainerCartelera.Location = new System.Drawing.Point(0, 0);
            this.pnlContainerCartelera.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainerCartelera.Name = "pnlContainerCartelera";
            this.pnlContainerCartelera.Size = new System.Drawing.Size(264, 588);
            this.pnlContainerCartelera.TabIndex = 21;
            this.pnlContainerCartelera.Visible = false;
            // 
            // btnEliminarTaquilla
            // 
            this.btnEliminarTaquilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnEliminarTaquilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTaquilla.Location = new System.Drawing.Point(0, 300);
            this.btnEliminarTaquilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTaquilla.Name = "btnEliminarTaquilla";
            this.btnEliminarTaquilla.Size = new System.Drawing.Size(264, 100);
            this.btnEliminarTaquilla.TabIndex = 22;
            this.btnEliminarTaquilla.Text = "ELIMINAR";
            this.btnEliminarTaquilla.UseVisualStyleBackColor = false;
            this.btnEliminarTaquilla.Click += new System.EventHandler(this.btnEliminarTaquilla_Click);
            // 
            // btnConsultarTaquilla
            // 
            this.btnConsultarTaquilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnConsultarTaquilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTaquilla.Location = new System.Drawing.Point(0, 200);
            this.btnConsultarTaquilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarTaquilla.Name = "btnConsultarTaquilla";
            this.btnConsultarTaquilla.Size = new System.Drawing.Size(264, 100);
            this.btnConsultarTaquilla.TabIndex = 20;
            this.btnConsultarTaquilla.Text = "COMPRAR";
            this.btnConsultarTaquilla.UseVisualStyleBackColor = false;
            this.btnConsultarTaquilla.Click += new System.EventHandler(this.btnConsultarTaquilla_Click);
            // 
            // btnAgregarTaquilla
            // 
            this.btnAgregarTaquilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnAgregarTaquilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTaquilla.Location = new System.Drawing.Point(0, 100);
            this.btnAgregarTaquilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTaquilla.Name = "btnAgregarTaquilla";
            this.btnAgregarTaquilla.Size = new System.Drawing.Size(264, 100);
            this.btnAgregarTaquilla.TabIndex = 21;
            this.btnAgregarTaquilla.Text = "AGREGAR";
            this.btnAgregarTaquilla.UseVisualStyleBackColor = false;
            this.btnAgregarTaquilla.Click += new System.EventHandler(this.btnAgregarTaquilla_Click);
            // 
            // btnModificarTaquilla
            // 
            this.btnModificarTaquilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnModificarTaquilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnModificarTaquilla.Location = new System.Drawing.Point(0, 0);
            this.btnModificarTaquilla.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarTaquilla.Name = "btnModificarTaquilla";
            this.btnModificarTaquilla.Size = new System.Drawing.Size(264, 100);
            this.btnModificarTaquilla.TabIndex = 23;
            this.btnModificarTaquilla.Text = "MODIFICAR";
            this.btnModificarTaquilla.UseVisualStyleBackColor = false;
            this.btnModificarTaquilla.Click += new System.EventHandler(this.btnModificarTaquilla_Click);
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
            this.pcLogo.Size = new System.Drawing.Size(1224, 137);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 17;
            this.pcLogo.TabStop = false;
            // 
            // frmCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 725);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.pcLogo);
            this.Name = "frmCartelera";
            this.Text = "frmCartelera";
            this.Load += new System.EventHandler(this.frmCartelera_Load);
            this.pnlChildForms.ResumeLayout(false);
            this.pnlChildForms.PerformLayout();
            this.pnlContainerCartelera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.Panel pnlContainerCartelera;
        private System.Windows.Forms.Button btnEliminarTaquilla;
        private System.Windows.Forms.Button btnConsultarTaquilla;
        private System.Windows.Forms.Button btnAgregarTaquilla;
        private System.Windows.Forms.Button btnModificarTaquilla;
        private System.Windows.Forms.Label label1;
    }
}