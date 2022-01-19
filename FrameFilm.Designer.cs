namespace CineDechDimitrio
{
    partial class FrameFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameFilm));
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.txtFilmTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstGenres = new System.Windows.Forms.ListBox();
            this.cboGenres = new System.Windows.Forms.ComboBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnRemoveGenre = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPublics = new System.Windows.Forms.ComboBox();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnDeleteFilm = new System.Windows.Forms.Button();
            this.txtFilmInfos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilmAffiche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilmSynop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilmActors = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmDirectors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtNumSalle = new System.Windows.Forms.Label();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.numFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modification de film";
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.Location = new System.Drawing.Point(107, 316);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(110, 23);
            this.btnEditFilm.TabIndex = 16;
            this.btnEditFilm.Text = "Modifier";
            this.btnEditFilm.UseVisualStyleBackColor = true;
            this.btnEditFilm.Click += new System.EventHandler(this.btnEditFilm_Click);
            // 
            // txtFilmTitle
            // 
            this.txtFilmTitle.Location = new System.Drawing.Point(110, 67);
            this.txtFilmTitle.Name = "txtFilmTitle";
            this.txtFilmTitle.Size = new System.Drawing.Size(182, 20);
            this.txtFilmTitle.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstGenres);
            this.panel1.Controls.Add(this.cboGenres);
            this.panel1.Controls.Add(this.btnAddGenre);
            this.panel1.Controls.Add(this.btnRemoveGenre);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboPublics);
            this.panel1.Controls.Add(this.btnAddFilm);
            this.panel1.Controls.Add(this.btnDeleteFilm);
            this.panel1.Controls.Add(this.txtFilmInfos);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFilmAffiche);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFilmSynop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFilmLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFilmActors);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFilmDirectors);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEditFilm);
            this.panel1.Controls.Add(this.txtFilmTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFilmNo);
            this.panel1.Controls.Add(this.txtNumSalle);
            this.panel1.Location = new System.Drawing.Point(268, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 353);
            this.panel1.TabIndex = 11;
            // 
            // lstGenres
            // 
            this.lstGenres.FormattingEnabled = true;
            this.lstGenres.Location = new System.Drawing.Point(385, 124);
            this.lstGenres.Name = "lstGenres";
            this.lstGenres.Size = new System.Drawing.Size(181, 69);
            this.lstGenres.TabIndex = 11;
            // 
            // cboGenres
            // 
            this.cboGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(384, 199);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.Size = new System.Drawing.Size(182, 21);
            this.cboGenres.TabIndex = 12;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(362, 226);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(93, 23);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Ajouter un genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnRemoveGenre
            // 
            this.btnRemoveGenre.Location = new System.Drawing.Point(461, 226);
            this.btnRemoveGenre.Name = "btnRemoveGenre";
            this.btnRemoveGenre.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveGenre.TabIndex = 14;
            this.btnRemoveGenre.Text = "Supprimer le genre";
            this.btnRemoveGenre.UseVisualStyleBackColor = true;
            this.btnRemoveGenre.Click += new System.EventHandler(this.btnRemoveGenre_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Genre(s)";
            // 
            // cboPublics
            // 
            this.cboPublics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublics.FormattingEnabled = true;
            this.cboPublics.Location = new System.Drawing.Point(109, 279);
            this.cboPublics.Name = "cboPublics";
            this.cboPublics.Size = new System.Drawing.Size(182, 21);
            this.cboPublics.TabIndex = 8;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(10, 316);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(91, 23);
            this.btnAddFilm.TabIndex = 15;
            this.btnAddFilm.Text = "Ajouter un film";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.Location = new System.Drawing.Point(223, 316);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteFilm.TabIndex = 17;
            this.btnDeleteFilm.Text = "Supprimer";
            this.btnDeleteFilm.UseVisualStyleBackColor = true;
            this.btnDeleteFilm.Click += new System.EventHandler(this.btnDeleteFilm_Click);
            // 
            // txtFilmInfos
            // 
            this.txtFilmInfos.Location = new System.Drawing.Point(383, 44);
            this.txtFilmInfos.Multiline = true;
            this.txtFilmInfos.Name = "txtFilmInfos";
            this.txtFilmInfos.Size = new System.Drawing.Size(183, 75);
            this.txtFilmInfos.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Type de public";
            // 
            // txtFilmAffiche
            // 
            this.txtFilmAffiche.Location = new System.Drawing.Point(110, 253);
            this.txtFilmAffiche.Name = "txtFilmAffiche";
            this.txtFilmAffiche.Size = new System.Drawing.Size(182, 20);
            this.txtFilmAffiche.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Affiche";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Informations";
            // 
            // txtFilmSynop
            // 
            this.txtFilmSynop.Location = new System.Drawing.Point(109, 171);
            this.txtFilmSynop.Multiline = true;
            this.txtFilmSynop.Name = "txtFilmSynop";
            this.txtFilmSynop.Size = new System.Drawing.Size(183, 75);
            this.txtFilmSynop.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Synopsis";
            // 
            // txtFilmLength
            // 
            this.txtFilmLength.Location = new System.Drawing.Point(109, 145);
            this.txtFilmLength.Name = "txtFilmLength";
            this.txtFilmLength.Size = new System.Drawing.Size(85, 20);
            this.txtFilmLength.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durée";
            // 
            // txtFilmActors
            // 
            this.txtFilmActors.Location = new System.Drawing.Point(109, 119);
            this.txtFilmActors.Name = "txtFilmActors";
            this.txtFilmActors.Size = new System.Drawing.Size(183, 20);
            this.txtFilmActors.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Acteurs";
            // 
            // txtFilmDirectors
            // 
            this.txtFilmDirectors.Location = new System.Drawing.Point(109, 93);
            this.txtFilmDirectors.Name = "txtFilmDirectors";
            this.txtFilmDirectors.Size = new System.Drawing.Size(183, 20);
            this.txtFilmDirectors.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Réalisateurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titre";
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Enabled = false;
            this.txtFilmNo.Location = new System.Drawing.Point(110, 41);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.Size = new System.Drawing.Size(84, 20);
            this.txtFilmNo.TabIndex = 1;
            // 
            // txtNumSalle
            // 
            this.txtNumSalle.AutoSize = true;
            this.txtNumSalle.Location = new System.Drawing.Point(19, 44);
            this.txtNumSalle.Name = "txtNumSalle";
            this.txtNumSalle.Size = new System.Drawing.Size(77, 13);
            this.txtNumSalle.TabIndex = 3;
            this.txtNumSalle.Text = "Numéro de film";
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.AllowUserToAddRows = false;
            this.dataGridViewFilms.AllowUserToDeleteRows = false;
            this.dataGridViewFilms.AllowUserToResizeColumns = false;
            this.dataGridViewFilms.AllowUserToResizeRows = false;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFilm,
            this.title});
            this.dataGridViewFilms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFilms.Location = new System.Drawing.Point(8, 30);
            this.dataGridViewFilms.MultiSelect = false;
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.ReadOnly = true;
            this.dataGridViewFilms.RowHeadersVisible = false;
            this.dataGridViewFilms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilms.ShowEditingIcon = false;
            this.dataGridViewFilms.Size = new System.Drawing.Size(254, 353);
            this.dataGridViewFilms.TabIndex = 10;
            this.dataGridViewFilms.SelectionChanged += new System.EventHandler(this.dataGridViewFilms_SelectionChanged);
            // 
            // numFilm
            // 
            this.numFilm.HeaderText = "Numéro";
            this.numFilm.Name = "numFilm";
            this.numFilm.ReadOnly = true;
            this.numFilm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numFilm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numFilm.Width = 75;
            // 
            // title
            // 
            this.title.HeaderText = "Titre";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.title.Width = 175;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Choisir un film";
            // 
            // FrameFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 390);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewFilms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrameFilm";
            this.Text = "Gestion de film";
            this.Load += new System.EventHandler(this.FrameFilm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.TextBox txtFilmTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.Label txtNumSalle;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilmAffiche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFilmSynop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilmActors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmDirectors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmInfos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btnDeleteFilm;
        private System.Windows.Forms.ComboBox cboPublics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnRemoveGenre;
        private System.Windows.Forms.ListBox lstGenres;
        private System.Windows.Forms.ComboBox cboGenres;
    }
}