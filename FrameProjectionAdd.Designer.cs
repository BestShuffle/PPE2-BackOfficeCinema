namespace CineDechDimitrio
{
    partial class FrameProjectionAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameProjectionAdd));
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnvalider = new System.Windows.Forms.Button();
            this.txtInfos = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbosalle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.AllowUserToAddRows = false;
            this.dataGridViewFilm.AllowUserToDeleteRows = false;
            this.dataGridViewFilm.AllowUserToResizeColumns = false;
            this.dataGridViewFilm.AllowUserToResizeRows = false;
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.film});
            this.dataGridViewFilm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFilm.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewFilm.MultiSelect = false;
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.ReadOnly = true;
            this.dataGridViewFilm.RowHeadersVisible = false;
            this.dataGridViewFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilm.ShowEditingIcon = false;
            this.dataGridViewFilm.Size = new System.Drawing.Size(179, 371);
            this.dataGridViewFilm.TabIndex = 1;
            // 
            // num
            // 
            this.num.HeaderText = "Numéro";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 65;
            // 
            // film
            // 
            this.film.HeaderText = "Film";
            this.film.Name = "film";
            this.film.ReadOnly = true;
            this.film.Width = 109;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2017, 1, 18, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(27, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2017, 1, 18, 0, 0, 0, 0);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(255, 404);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(114, 33);
            this.btnvalider.TabIndex = 6;
            this.btnvalider.Text = "Ajouter";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // txtInfos
            // 
            this.txtInfos.Location = new System.Drawing.Point(27, 42);
            this.txtInfos.Multiline = true;
            this.txtInfos.Name = "txtInfos";
            this.txtInfos.Size = new System.Drawing.Size(186, 63);
            this.txtInfos.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtInfos);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(197, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 126);
            this.panel5.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Informations";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbosalle);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(197, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 101);
            this.panel6.TabIndex = 20;
            // 
            // cbosalle
            // 
            this.cbosalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosalle.FormattingEnabled = true;
            this.cbosalle.Location = new System.Drawing.Point(28, 50);
            this.cbosalle.Name = "cbosalle";
            this.cbosalle.Size = new System.Drawing.Size(186, 21);
            this.cbosalle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choisir une salle";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dateTimePicker2);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Location = new System.Drawing.Point(197, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 132);
            this.panel7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Définir dates et horaires";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Choisir un film";
            // 
            // FrameProjectionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnvalider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrameProjectionAdd";
            this.Text = "Gestion de projection";
            this.Load += new System.EventHandler(this.FrameProjection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.TextBox txtInfos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbosalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn film;

    }
}