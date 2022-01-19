namespace CineDechDimitrio
{
    partial class FrameSalle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSalle));
            this.dataGridViewSalles = new System.Windows.Forms.DataGridView();
            this.numSalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddNoSalle = new System.Windows.Forms.TextBox();
            this.txtNumSalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddNbPlaces = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddSalle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEditNbPlaces = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditNoSalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditSalle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalles)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSalles
            // 
            this.dataGridViewSalles.AllowUserToAddRows = false;
            this.dataGridViewSalles.AllowUserToDeleteRows = false;
            this.dataGridViewSalles.AllowUserToResizeColumns = false;
            this.dataGridViewSalles.AllowUserToResizeRows = false;
            this.dataGridViewSalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSalle,
            this.nomSalle});
            this.dataGridViewSalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSalles.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewSalles.MultiSelect = false;
            this.dataGridViewSalles.Name = "dataGridViewSalles";
            this.dataGridViewSalles.ReadOnly = true;
            this.dataGridViewSalles.RowHeadersVisible = false;
            this.dataGridViewSalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalles.ShowEditingIcon = false;
            this.dataGridViewSalles.Size = new System.Drawing.Size(179, 372);
            this.dataGridViewSalles.TabIndex = 1;
            this.dataGridViewSalles.SelectionChanged += new System.EventHandler(this.dataGridViewSalles_SelectionChanged);
            // 
            // numSalle
            // 
            this.numSalle.HeaderText = "Numéro";
            this.numSalle.Name = "numSalle";
            this.numSalle.ReadOnly = true;
            this.numSalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numSalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numSalle.Width = 75;
            // 
            // nomSalle
            // 
            this.nomSalle.HeaderText = "Nb. de places";
            this.nomSalle.Name = "nomSalle";
            this.nomSalle.ReadOnly = true;
            this.nomSalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtAddNoSalle
            // 
            this.txtAddNoSalle.Location = new System.Drawing.Point(119, 41);
            this.txtAddNoSalle.Name = "txtAddNoSalle";
            this.txtAddNoSalle.Size = new System.Drawing.Size(100, 20);
            this.txtAddNoSalle.TabIndex = 2;
            // 
            // txtNumSalle
            // 
            this.txtNumSalle.AutoSize = true;
            this.txtNumSalle.Location = new System.Drawing.Point(19, 44);
            this.txtNumSalle.Name = "txtNumSalle";
            this.txtNumSalle.Size = new System.Drawing.Size(83, 13);
            this.txtNumSalle.TabIndex = 3;
            this.txtNumSalle.Text = "Numéro de salle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de places";
            // 
            // txtAddNbPlaces
            // 
            this.txtAddNbPlaces.Location = new System.Drawing.Point(119, 67);
            this.txtAddNbPlaces.Name = "txtAddNbPlaces";
            this.txtAddNbPlaces.Size = new System.Drawing.Size(100, 20);
            this.txtAddNbPlaces.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddSalle);
            this.panel1.Controls.Add(this.txtAddNbPlaces);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddNoSalle);
            this.panel1.Controls.Add(this.txtNumSalle);
            this.panel1.Location = new System.Drawing.Point(196, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 132);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ajout de salle";
            // 
            // btnAddSalle
            // 
            this.btnAddSalle.Location = new System.Drawing.Point(66, 96);
            this.btnAddSalle.Name = "btnAddSalle";
            this.btnAddSalle.Size = new System.Drawing.Size(101, 23);
            this.btnAddSalle.TabIndex = 4;
            this.btnAddSalle.Text = "Ajouter";
            this.btnAddSalle.UseVisualStyleBackColor = true;
            this.btnAddSalle.Click += new System.EventHandler(this.btnAddSalle_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtEditNbPlaces);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEditNoSalle);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEditSalle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(196, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 134);
            this.panel2.TabIndex = 8;
            // 
            // txtEditNbPlaces
            // 
            this.txtEditNbPlaces.Location = new System.Drawing.Point(119, 77);
            this.txtEditNbPlaces.Name = "txtEditNbPlaces";
            this.txtEditNbPlaces.Size = new System.Drawing.Size(100, 20);
            this.txtEditNbPlaces.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de places";
            // 
            // txtEditNoSalle
            // 
            this.txtEditNoSalle.Enabled = false;
            this.txtEditNoSalle.Location = new System.Drawing.Point(119, 51);
            this.txtEditNoSalle.Name = "txtEditNoSalle";
            this.txtEditNoSalle.Size = new System.Drawing.Size(100, 20);
            this.txtEditNoSalle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Numéro de salle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modification";
            // 
            // btnEditSalle
            // 
            this.btnEditSalle.Location = new System.Drawing.Point(66, 103);
            this.btnEditSalle.Name = "btnEditSalle";
            this.btnEditSalle.Size = new System.Drawing.Size(101, 23);
            this.btnEditSalle.TabIndex = 7;
            this.btnEditSalle.Text = "Modifier";
            this.btnEditSalle.UseVisualStyleBackColor = true;
            this.btnEditSalle.Click += new System.EventHandler(this.btnEditSalle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modifier la salle sélectionnée";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(196, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 94);
            this.panel3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Suppression";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(66, 55);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Supprimer la salle sélectionnée";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Choisir une salle";
            // 
            // FrameSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 415);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrameSalle";
            this.Text = "Gestion de salle";
            this.Load += new System.EventHandler(this.Salle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalles;
        private System.Windows.Forms.TextBox txtAddNoSalle;
        private System.Windows.Forms.Label txtNumSalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddNbPlaces;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEditNbPlaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditNoSalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditSalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSalle;
        private System.Windows.Forms.Label label7;



    }
}

