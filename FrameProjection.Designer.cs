namespace CineDechDimitrio
{
    partial class FrameProjection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameProjection));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.grdProj = new System.Windows.Forms.DataGridView();
            this.nofilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoproj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProj)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.grdProj);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(526, 338);
            this.panel5.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Projections programmées:";
            // 
            // grdProj
            // 
            this.grdProj.AllowUserToAddRows = false;
            this.grdProj.AllowUserToDeleteRows = false;
            this.grdProj.AllowUserToResizeColumns = false;
            this.grdProj.AllowUserToResizeRows = false;
            this.grdProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nofilm,
            this.date,
            this.heure,
            this.infoproj,
            this.nosalle});
            this.grdProj.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProj.Location = new System.Drawing.Point(10, 55);
            this.grdProj.MultiSelect = false;
            this.grdProj.Name = "grdProj";
            this.grdProj.ReadOnly = true;
            this.grdProj.RowHeadersVisible = false;
            this.grdProj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProj.ShowEditingIcon = false;
            this.grdProj.Size = new System.Drawing.Size(504, 264);
            this.grdProj.TabIndex = 1;
            // 
            // nofilm
            // 
            this.nofilm.HeaderText = "Film";
            this.nofilm.Name = "nofilm";
            this.nofilm.ReadOnly = true;
            this.nofilm.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 75;
            // 
            // heure
            // 
            this.heure.HeaderText = "Heure";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            this.heure.Width = 50;
            // 
            // infoproj
            // 
            this.infoproj.HeaderText = "Infos";
            this.infoproj.Name = "infoproj";
            this.infoproj.ReadOnly = true;
            this.infoproj.Width = 175;
            // 
            // nosalle
            // 
            this.nosalle.HeaderText = "Salle";
            this.nosalle.Name = "nosalle";
            this.nosalle.ReadOnly = true;
            this.nosalle.Width = 45;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(211, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter une projection";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrameProjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 397);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrameProjection";
            this.Text = "Projections programmées";
            this.Load += new System.EventHandler(this.FrameProjectionAdd_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView grdProj;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nofilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoproj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosalle;
    }
}