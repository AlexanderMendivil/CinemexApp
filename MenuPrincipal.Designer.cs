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
            this.pnlChildForms = new System.Windows.Forms.Panel();
            this.pbTaquilla = new System.Windows.Forms.PictureBox();
            this.pbDulceria = new System.Windows.Forms.PictureBox();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pnlBot.SuspendLayout();
            this.pnlChildForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaquilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDulceria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.lblSloganCinemex);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 694);
            this.pnlBot.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1356, 81);
            this.pnlBot.TabIndex = 13;
            // 
            // lblSloganCinemex
            // 
            this.lblSloganCinemex.AutoSize = true;
            this.lblSloganCinemex.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSloganCinemex.ForeColor = System.Drawing.Color.White;
            this.lblSloganCinemex.Location = new System.Drawing.Point(585, 22);
            this.lblSloganCinemex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSloganCinemex.Name = "lblSloganCinemex";
            this.lblSloganCinemex.Size = new System.Drawing.Size(323, 37);
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
            this.lblCerra.Location = new System.Drawing.Point(1299, 11);
            this.lblCerra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerra.Name = "lblCerra";
            this.lblCerra.Size = new System.Drawing.Size(24, 28);
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
            this.lblMinimo.Location = new System.Drawing.Point(1218, 11);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(28, 28);
            this.lblMinimo.TabIndex = 17;
            this.lblMinimo.Text = "__";
            this.lblMinimo.Click += new System.EventHandler(this.lblMinimo_Click);
            // 
            // pnlChildForms
            // 
            this.pnlChildForms.Controls.Add(this.pbTaquilla);
            this.pnlChildForms.Controls.Add(this.pbDulceria);
            this.pnlChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForms.Location = new System.Drawing.Point(0, 137);
            this.pnlChildForms.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForms.Name = "pnlChildForms";
            this.pnlChildForms.Size = new System.Drawing.Size(1356, 557);
            this.pnlChildForms.TabIndex = 20;
            // 
            // pbTaquilla
            // 
            this.pbTaquilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.pbTaquilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTaquilla.Image = global::CinemexApp.Properties.Resources.cartelera;
            this.pbTaquilla.Location = new System.Drawing.Point(160, 161);
            this.pbTaquilla.Margin = new System.Windows.Forms.Padding(4);
            this.pbTaquilla.Name = "pbTaquilla";
            this.pbTaquilla.Size = new System.Drawing.Size(434, 213);
            this.pbTaquilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTaquilla.TabIndex = 14;
            this.pbTaquilla.TabStop = false;
            this.pbTaquilla.Click += new System.EventHandler(this.pbTaquilla_Click);
            // 
            // pbDulceria
            // 
            this.pbDulceria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDulceria.Image = global::CinemexApp.Properties.Resources.dulces;
            this.pbDulceria.Location = new System.Drawing.Point(776, 161);
            this.pbDulceria.Margin = new System.Windows.Forms.Padding(4);
            this.pbDulceria.Name = "pbDulceria";
            this.pbDulceria.Size = new System.Drawing.Size(402, 213);
            this.pbDulceria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDulceria.TabIndex = 15;
            this.pbDulceria.TabStop = false;
            this.pbDulceria.Click += new System.EventHandler(this.pbDulceria_Click);
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
            this.pcLogo.Size = new System.Drawing.Size(1356, 137);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 16;
            this.pcLogo.TabStop = false;
            this.pcLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcLogo_MouseDown);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1356, 775);
            this.Controls.Add(this.pnlChildForms);
            this.Controls.Add(this.lblCerra);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.pcLogo);
            this.Controls.Add(this.pnlBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "CINEMEX";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            this.pnlChildForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTaquilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDulceria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Label lblSloganCinemex;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Label lblCerra;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Panel pnlChildForms;
        private System.Windows.Forms.PictureBox pbTaquilla;
        private System.Windows.Forms.PictureBox pbDulceria;
    }
}

