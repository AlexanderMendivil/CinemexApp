namespace CinemexApp
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBot = new System.Windows.Forms.Panel();
            this.lblSloganCinemex = new System.Windows.Forms.Label();
            this.lblCerra = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlContainerTaquilla = new System.Windows.Forms.Panel();
            this.btnModificarTaquilla = new System.Windows.Forms.Button();
            this.btnAgregarTaquilla = new System.Windows.Forms.Button();
            this.btnConsultarTaquilla = new System.Windows.Forms.Button();
            this.btnElimarTaquilla = new System.Windows.Forms.Button();
            this.pnlContainerDulceria = new System.Windows.Forms.Panel();
            this.btnEliminarDulceria = new System.Windows.Forms.Button();
            this.btnConsultarDulceria = new System.Windows.Forms.Button();
            this.btnAgregarDulceria = new System.Windows.Forms.Button();
            this.btnModificarDulceria = new System.Windows.Forms.Button();
            this.pbDulceria = new System.Windows.Forms.PictureBox();
            this.pbTaquilla = new System.Windows.Forms.PictureBox();
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pnlBot.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlContainerTaquilla.SuspendLayout();
            this.pnlContainerDulceria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDulceria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaquilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.lblSloganCinemex);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 564);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1017, 66);
            this.pnlBot.TabIndex = 13;
            // 
            // lblSloganCinemex
            // 
            this.lblSloganCinemex.AutoSize = true;
            this.lblSloganCinemex.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSloganCinemex.ForeColor = System.Drawing.Color.White;
            this.lblSloganCinemex.Location = new System.Drawing.Point(288, 18);
            this.lblSloganCinemex.Name = "lblSloganCinemex";
            this.lblSloganCinemex.Size = new System.Drawing.Size(247, 30);
            this.lblSloganCinemex.TabIndex = 4;
            this.lblSloganCinemex.Text = "“Esta es la magia del cine”";
            this.lblSloganCinemex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCerra
            // 
            this.lblCerra.AutoSize = true;
            this.lblCerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerra.ForeColor = System.Drawing.Color.White;
            this.lblCerra.Location = new System.Drawing.Point(974, 9);
            this.lblCerra.Name = "lblCerra";
            this.lblCerra.Size = new System.Drawing.Size(19, 21);
            this.lblCerra.TabIndex = 18;
            this.lblCerra.Text = "X";
            this.lblCerra.Click += new System.EventHandler(this.lblCerra_Click);
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.ForeColor = System.Drawing.Color.White;
            this.lblMinimo.Location = new System.Drawing.Point(909, 9);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(24, 21);
            this.lblMinimo.TabIndex = 17;
            this.lblMinimo.Text = "__";
            this.lblMinimo.Click += new System.EventHandler(this.lblMinimo_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.pnlContainerTaquilla);
            this.pnlContainer.Controls.Add(this.pnlContainerDulceria);
            this.pnlContainer.Controls.Add(this.pbDulceria);
            this.pnlContainer.Controls.Add(this.pbTaquilla);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainer.Location = new System.Drawing.Point(0, 112);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(200, 452);
            this.pnlContainer.TabIndex = 19;
            // 
            // pnlContainerTaquilla
            // 
            this.pnlContainerTaquilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.pnlContainerTaquilla.Controls.Add(this.btnModificarTaquilla);
            this.pnlContainerTaquilla.Controls.Add(this.btnAgregarTaquilla);
            this.pnlContainerTaquilla.Controls.Add(this.btnConsultarTaquilla);
            this.pnlContainerTaquilla.Controls.Add(this.btnElimarTaquilla);
            this.pnlContainerTaquilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContainerTaquilla.Location = new System.Drawing.Point(0, 230);
            this.pnlContainerTaquilla.Name = "pnlContainerTaquilla";
            this.pnlContainerTaquilla.Size = new System.Drawing.Size(198, 114);
            this.pnlContainerTaquilla.TabIndex = 20;
            this.pnlContainerTaquilla.Visible = false;
            // 
            // btnModificarTaquilla
            // 
            this.btnModificarTaquilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModificarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnModificarTaquilla.Location = new System.Drawing.Point(0, 8);
            this.btnModificarTaquilla.Name = "btnModificarTaquilla";
            this.btnModificarTaquilla.Size = new System.Drawing.Size(198, 27);
            this.btnModificarTaquilla.TabIndex = 29;
            this.btnModificarTaquilla.Text = "MODIFICAR";
            this.btnModificarTaquilla.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTaquilla
            // 
            this.btnAgregarTaquilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTaquilla.Location = new System.Drawing.Point(0, 35);
            this.btnAgregarTaquilla.Name = "btnAgregarTaquilla";
            this.btnAgregarTaquilla.Size = new System.Drawing.Size(198, 25);
            this.btnAgregarTaquilla.TabIndex = 30;
            this.btnAgregarTaquilla.Text = "AGREGAR";
            this.btnAgregarTaquilla.UseVisualStyleBackColor = true;
            // 
            // btnConsultarTaquilla
            // 
            this.btnConsultarTaquilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConsultarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTaquilla.Location = new System.Drawing.Point(0, 60);
            this.btnConsultarTaquilla.Name = "btnConsultarTaquilla";
            this.btnConsultarTaquilla.Size = new System.Drawing.Size(198, 26);
            this.btnConsultarTaquilla.TabIndex = 31;
            this.btnConsultarTaquilla.Text = "CONSULTAR";
            this.btnConsultarTaquilla.UseVisualStyleBackColor = true;
            this.btnConsultarTaquilla.Click += new System.EventHandler(this.btnConsultarTaquilla_Click);
            // 
            // btnElimarTaquilla
            // 
            this.btnElimarTaquilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnElimarTaquilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimarTaquilla.ForeColor = System.Drawing.Color.White;
            this.btnElimarTaquilla.Location = new System.Drawing.Point(0, 86);
            this.btnElimarTaquilla.Name = "btnElimarTaquilla";
            this.btnElimarTaquilla.Size = new System.Drawing.Size(198, 28);
            this.btnElimarTaquilla.TabIndex = 28;
            this.btnElimarTaquilla.Text = "ELIMINAR";
            this.btnElimarTaquilla.UseVisualStyleBackColor = true;
            // 
            // pnlContainerDulceria
            // 
            this.pnlContainerDulceria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.pnlContainerDulceria.Controls.Add(this.btnEliminarDulceria);
            this.pnlContainerDulceria.Controls.Add(this.btnConsultarDulceria);
            this.pnlContainerDulceria.Controls.Add(this.btnAgregarDulceria);
            this.pnlContainerDulceria.Controls.Add(this.btnModificarDulceria);
            this.pnlContainerDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainerDulceria.Location = new System.Drawing.Point(0, 129);
            this.pnlContainerDulceria.Name = "pnlContainerDulceria";
            this.pnlContainerDulceria.Size = new System.Drawing.Size(198, 95);
            this.pnlContainerDulceria.TabIndex = 20;
            this.pnlContainerDulceria.Visible = false;
            // 
            // btnEliminarDulceria
            // 
            this.btnEliminarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDulceria.Location = new System.Drawing.Point(0, 69);
            this.btnEliminarDulceria.Name = "btnEliminarDulceria";
            this.btnEliminarDulceria.Size = new System.Drawing.Size(198, 23);
            this.btnEliminarDulceria.TabIndex = 22;
            this.btnEliminarDulceria.Text = "ELIMINAR";
            this.btnEliminarDulceria.UseVisualStyleBackColor = true;
            this.btnEliminarDulceria.Click += new System.EventHandler(this.btnEliminarDulceria_Click);
            // 
            // btnConsultarDulceria
            // 
            this.btnConsultarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDulceria.Location = new System.Drawing.Point(0, 46);
            this.btnConsultarDulceria.Name = "btnConsultarDulceria";
            this.btnConsultarDulceria.Size = new System.Drawing.Size(198, 23);
            this.btnConsultarDulceria.TabIndex = 20;
            this.btnConsultarDulceria.Text = "CONSULTAR";
            this.btnConsultarDulceria.UseVisualStyleBackColor = true;
            this.btnConsultarDulceria.Click += new System.EventHandler(this.btnConsultarDulceria_Click);
            // 
            // btnAgregarDulceria
            // 
            this.btnAgregarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDulceria.Location = new System.Drawing.Point(0, 23);
            this.btnAgregarDulceria.Name = "btnAgregarDulceria";
            this.btnAgregarDulceria.Size = new System.Drawing.Size(198, 23);
            this.btnAgregarDulceria.TabIndex = 21;
            this.btnAgregarDulceria.Text = "AGREGAR";
            this.btnAgregarDulceria.UseVisualStyleBackColor = true;
            this.btnAgregarDulceria.Click += new System.EventHandler(this.btnAgregarDulceria_Click);
            // 
            // btnModificarDulceria
            // 
            this.btnModificarDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarDulceria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDulceria.ForeColor = System.Drawing.Color.White;
            this.btnModificarDulceria.Location = new System.Drawing.Point(0, 0);
            this.btnModificarDulceria.Name = "btnModificarDulceria";
            this.btnModificarDulceria.Size = new System.Drawing.Size(198, 23);
            this.btnModificarDulceria.TabIndex = 23;
            this.btnModificarDulceria.Text = "MODIFICAR";
            this.btnModificarDulceria.UseVisualStyleBackColor = true;
            this.btnModificarDulceria.Click += new System.EventHandler(this.btnModificarDulceria_Click);
            // 
            // pbDulceria
            // 
            this.pbDulceria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDulceria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbDulceria.Image = global::CinemexApp.Properties.Resources.dulces;
            this.pbDulceria.Location = new System.Drawing.Point(0, 0);
            this.pbDulceria.Name = "pbDulceria";
            this.pbDulceria.Size = new System.Drawing.Size(198, 129);
            this.pbDulceria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDulceria.TabIndex = 15;
            this.pbDulceria.TabStop = false;
            this.pbDulceria.Click += new System.EventHandler(this.pbDulceria_Click);
            // 
            // pbTaquilla
            // 
            this.pbTaquilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTaquilla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTaquilla.Image = global::CinemexApp.Properties.Resources.cartelera;
            this.pbTaquilla.Location = new System.Drawing.Point(0, 344);
            this.pbTaquilla.Name = "pbTaquilla";
            this.pbTaquilla.Size = new System.Drawing.Size(198, 106);
            this.pbTaquilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTaquilla.TabIndex = 14;
            this.pbTaquilla.TabStop = false;
            this.pbTaquilla.Click += new System.EventHandler(this.pbTaquilla_Click);
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(200, 112);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(817, 452);
            this.pnlChildForms.TabIndex = 20;
            // 
            // pcLogo
            // 
            this.pcLogo.BackgroundImage = global::CinemexApp.Properties.Resources.logoCine;
            this.pcLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcLogo.Image = global::CinemexApp.Properties.Resources.logoCine;
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(1017, 112);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 16;
            this.pcLogo.TabStop = false;
            this.pcLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcLogo_MouseDown);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1017, 630);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblCerra);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.pcLogo);
            this.Controls.Add(this.pnlBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "CINEMEX";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainerTaquilla.ResumeLayout(false);
            this.pnlContainerDulceria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDulceria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaquilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Label lblSloganCinemex;
        private System.Windows.Forms.PictureBox pbTaquilla;
        private System.Windows.Forms.PictureBox pbDulceria;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Label lblCerra;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlContainerTaquilla;
        private System.Windows.Forms.Button btnModificarTaquilla;
        private System.Windows.Forms.Button btnAgregarTaquilla;
        private System.Windows.Forms.Button btnConsultarTaquilla;
        private System.Windows.Forms.Button btnElimarTaquilla;
        private System.Windows.Forms.Panel pnlContainerDulceria;
        private System.Windows.Forms.Button btnEliminarDulceria;
        private System.Windows.Forms.Button btnConsultarDulceria;
        private System.Windows.Forms.Button btnAgregarDulceria;
        private System.Windows.Forms.Button btnModificarDulceria;
        private System.Windows.Forms.Panel pnlChildForms;
    }
}

