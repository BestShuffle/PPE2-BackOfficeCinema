namespace CineDechDimitrio
{
    partial class FrameCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameCinema));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProjectionsHebdomadaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.salleToolStripMenuItem,
            this.projectionToolStripMenuItem,
            this.listeDesProjectionsHebdomadaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "cinemaMenuStrip";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.filmToolStripMenuItem.Text = "Film";
            this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // salleToolStripMenuItem
            // 
            this.salleToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salleToolStripMenuItem.Name = "salleToolStripMenuItem";
            this.salleToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.salleToolStripMenuItem.Text = "Salle";
            this.salleToolStripMenuItem.Click += new System.EventHandler(this.salleToolStripMenuItem_Click);
            // 
            // projectionToolStripMenuItem
            // 
            this.projectionToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectionToolStripMenuItem.Name = "projectionToolStripMenuItem";
            this.projectionToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.projectionToolStripMenuItem.Text = "Projection";
            this.projectionToolStripMenuItem.Click += new System.EventHandler(this.projectionToolStripMenuItem_Click);
            // 
            // listeDesProjectionsHebdomadaireToolStripMenuItem
            // 
            this.listeDesProjectionsHebdomadaireToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeDesProjectionsHebdomadaireToolStripMenuItem.Name = "listeDesProjectionsHebdomadaireToolStripMenuItem";
            this.listeDesProjectionsHebdomadaireToolStripMenuItem.Size = new System.Drawing.Size(339, 23);
            this.listeDesProjectionsHebdomadaireToolStripMenuItem.Text = "Liste hebdomadaire des projections à partir du";
            this.listeDesProjectionsHebdomadaireToolStripMenuItem.Click += new System.EventHandler(this.listeDesProjectionsHebdomadaireToolStripMenuItem_Click);
            // 
            // FrameCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CineDechDimitrio.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 541);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrameCinema";
            this.Text = "Cinemarivaux";
            this.Load += new System.EventHandler(this.FormCinema_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProjectionsHebdomadaireToolStripMenuItem;

    }
}