using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CineDechDimitrio
{
    public partial class FrameGenre : Form
    {
        // Chargemetn de la fenêtre
        public FrameGenre()
        {
            InitializeComponent();
        }

        // Chargement de l'interface de la fenêtre
        private void TableGenre_Load(object sender, EventArgs e)
        {
            // Rafraichissement du DataGridView
            refreshDataGridViewGenre();
        }

        // Event de clic sur le bouton d'ajout de genre
        private void btnajouter_Click(object sender, EventArgs e)
        {
            // Récupération des données entrées par l'utilisateur
            String libgenre = txtadd.Text;

            // Correction des données entrées
            CinemaMethods.correctTextField(ref libgenre);

            Server.connect();

            // Ajout du genre en base de données
            Server.executeUpdate("INSERT into genre (libgenre) VALUES ('" + libgenre + "')",
                true);
            Server.disconnect();

            refreshDataGridViewGenre();
            txtadd.Text = " ";
            CinemaMethods.alert("Votre genre a bien été ajouté");
        }

        // Event de clic sur le bouton d'édition de genre
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des données entrées par l'utilisateur
                String libgenre = txtupd.Text;

                // Correction des données entrées
                CinemaMethods.correctTextField(ref libgenre);

                // Vérification si les valeurs récupérées sont valides
                if (CinemaMethods.verifIdField(ref libgenre))
                {
                    // Récupération de la ligne et du genre sélectionné
                    int ligne = dataGridViewGenre.CurrentCell.RowIndex;
                    String genreSelect = Convert.ToString(dataGridViewGenre[0, ligne].Value);
                    String nomgenre = Convert.ToString(dataGridViewGenre[1, ligne].Value);

                    // Mise à jour du genre en base de données
                    DialogResult result = MessageBox.Show("Etes vous sur de vouloir modifier '" + nomgenre + "' en '" + txtupd.Text + "' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        Server.connect();
                        Server.executeUpdate("UPDATE genre SET libgenre=('" + libgenre + "') WHERE nogenre='" + genreSelect + "'",
                            true);
                        CinemaMethods.alert("Votre genre a bien été modifié");

                        Server.disconnect();
                        refreshDataGridViewGenre();
                        txtupd.Text = " ";
                    }
                }
                else
                {
                    CinemaMethods.alert("Valeurs entrées invalides.");
                }
            }
            catch (NullReferenceException ex)
            {
                CinemaMethods.alert("Genre sélectionné invalide.");
            }
        }

        // Event de clic sur le bouton de suppression de genre
        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            // Récupération de la ligne et du genre sélectionné
            int ligne = dataGridViewGenre.CurrentCell.RowIndex;
            String genreSelect = Convert.ToString(dataGridViewGenre[0, ligne].Value);
            String nomgenre = Convert.ToString(dataGridViewGenre[1, ligne].Value);

            DialogResult result = MessageBox.Show("Etes vous sur de vouloir supprimer le genre  '" + nomgenre + "' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Suppression du genre
                Server.connect();
                Server.execute("DELETE FROM genre WHERE nogenre='" + genreSelect + "'",
                        true);
                CinemaMethods.alert("Votre genre a bien été supprimé");

                Server.disconnect();
                refreshDataGridViewGenre();
            }
        }

        private void dataGridViewGenre_SelectionChanged(object sender, EventArgs e)
        {
            //Affiche le genre selectionner dans un textbox
            int ligne = dataGridViewGenre.CurrentCell.RowIndex;
            txtupd.Text = Convert.ToString(dataGridViewGenre[1, ligne].Value);
        }

        // Fonction de rafraichissement du datagridview de genre
        private void refreshDataGridViewGenre()
        {
            // Vide du DataGridView
            dataGridViewGenre.Rows.Clear();

            // Récupération des données
            Server.connect();
            Server.execute("SELECT * FROM genre",
                true);

            while (Server.read())
            {
                // Ajout des données dans le DataGridView
                dataGridViewGenre.Rows.Add(Server.getReader()["nogenre"], Server.getReader()["libgenre"]);
            }

            Server.disconnect();
        }
    }
}
