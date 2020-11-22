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
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.pbDulceria = new System.Windows.Forms.PictureBox();
            this.pbTaquilla = new System.Windows.Forms.PictureBox();
            this.pnlBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDulceria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaquilla)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.lblSloganCinemex);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 400);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(822, 66);
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
            this.lblCerra.Location = new System.Drawing.Point(791, 9);
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
            this.lblMinimo.Location = new System.Drawing.Point(726, 9);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(24, 21);
            this.lblMinimo.TabIndex = 17;
            this.lblMinimo.Text = "__";
            this.lblMinimo.Click += new System.EventHandler(this.lblMinimo_Click);
            // 
            // pcLogo
            // 
            this.pcLogo.BackgroundImage = global::CinemexApp.Properties.Resources.logoCine;
            this.pcLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcLogo.Image = global::CinemexApp.Properties.Resources.logoCine;
            this.pcLogo.Location = new System.Drawing.Point(0, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(822, 132);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 16;
            this.pcLogo.TabStop = false;
            this.pcLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcLogo_MouseDown);
            // 
            // pbDulceria
            // 
            this.pbDulceria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDulceria.Image = global::CinemexApp.Properties.Resources.dulces;
            this.pbDulceria.Location = new System.Drawing.Point(178, 164);
            this.pbDulceria.Name = "pbDulceria";
            this.pbDulceria.Size = new System.Drawing.Size(195, 168);
            this.pbDulceria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDulceria.TabIndex = 15;
            this.pbDulceria.TabStop = false;
            this.pbDulceria.Click += new System.EventHandler(this.pbDulceria_Click);
            // 
            // pbTaquilla
            // 
            this.pbTaquilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTaquilla.Image = global::CinemexApp.Properties.Resources.cartelera;
            this.pbTaquilla.Location = new System.Drawing.Point(451, 164);
            this.pbTaquilla.Name = "pbTaquilla";
            this.pbTaquilla.Size = new System.Drawing.Size(195, 168);
            this.pbTaquilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTaquilla.TabIndex = 14;
            this.pbTaquilla.TabStop = false;
            this.pbTaquilla.Click += new System.EventHandler(this.pbTaquilla_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(822, 466);
            this.Controls.Add(this.lblCerra);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.pcLogo);
            this.Controls.Add(this.pbDulceria);
            this.Controls.Add(this.pbTaquilla);
            this.Controls.Add(this.pnlBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "CINEMEX";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDulceria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaquilla)).EndInit();
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
    }
}

