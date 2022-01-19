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
    // Classe de fenêtre de gestion de salle
    public partial class FrameSalle : Form
    {
        List<Salle> salles = new List<Salle>();

        // Construit la fenêtre de gestion des salles
        public FrameSalle()
        {
            InitializeComponent();
        }

        // Chargement de la fenêtre
        private void Salle_Load(object sender, EventArgs e)
        {
            // Rafraichissement du DataGridView
            refreshDataGridViewSalles();
        }

        // Event de clic sur le bouton d'ajout de salle
        private void btnAddSalle_Click(object sender, EventArgs e)
        {
            // Récupération des données entrées par l'utilisateur
            String numSalle = txtAddNoSalle.Text;
            String nbPlaces = txtAddNbPlaces.Text;

            // Vérification si les valeurs récupérées sont valides
            if (CinemaMethods.verifIdField(ref numSalle) &&
                CinemaMethods.verifIntField(ref nbPlaces))
            {
                // Tentative d'ajout
                // Ajout de la salle dans la base de données
                Server.connect();
                Boolean isCreated = Server.executeUpdate("INSERT INTO salle VALUES ('"
                    + numSalle + "', " + nbPlaces + ")", false);
                Server.disconnect();

                if (isCreated)
                {
                    txtAddNoSalle.Text = "";
                    txtAddNbPlaces.Text = "";

                    // Rafraichissement du DataGridView
                    refreshDataGridViewSalles();
                    CinemaMethods.alert("Salle " + numSalle + " créée.");
                }
                else
                {
                    CinemaMethods.alert("La salle " + numSalle + " existe déjà.");
                }

            }
            else
            {
                CinemaMethods.alert("Valeurs entrées invalides.");
            }
        }

        // Event de changement de sélection sur le DataGridView de salle
        private void dataGridViewSalles_SelectionChanged(object sender, EventArgs e)
        {
            // Récupération des données et affichage dans les TextBoxs
            Salle salle = salles[dataGridViewSalles.CurrentCell.RowIndex];
            txtEditNoSalle.Text = salle.getId();
            txtEditNbPlaces.Text = salle.getNbPlaces().ToString();
        }

        // Event de clic sur le bouton d'édition de salle
        private void btnEditSalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des valeurs entrées par les utilisateurs
                Salle salle;
                int rowIndex = dataGridViewSalles.CurrentCell.RowIndex;
                String numSalle = txtEditNoSalle.Text;
                String nbPlaces = txtEditNbPlaces.Text;

                if (CinemaMethods.verifIntField(ref nbPlaces))
                {
                    DialogResult result = MessageBox.Show("Modification de la salle '" + numSalle + "' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    // Vérification si les valeurs récupérées sont valides
                    if (result == DialogResult.Yes &&
                        CinemaMethods.verifIdField(ref numSalle) &&
                        CinemaMethods.verifIntField(ref nbPlaces) &&
                        numSalle.Length == 1)
                    {
                        // Mise à jour dans la base de données
                        Server.connect();
                        Server.executeUpdate("UPDATE salle SET nbplaces="
                            + nbPlaces + " WHERE nosalle='" + numSalle + "'",
                            true);
                        Server.disconnect();

                        // Rafraichissement du DataGridView
                        refreshDataGridViewSalles();

                        salle = salles[rowIndex];

                        txtEditNoSalle.Text = salle.getId();
                        txtEditNbPlaces.Text = salle.getNbPlaces().ToString();

                        CinemaMethods.alert("La salle " + salle.getId() + " a été modifiée.");
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                CinemaMethods.alert("Salle sélectionnée invalide.");
            }
        }

        // Event de clic sur le bouton de suppression de salle
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Récupération de l'identifiant de la salle saisit
            String numSalle = txtEditNoSalle.Text;

            // Affichage d'une fenêtre de dialogue demandant si le film choisi doit bien être modifié
            DialogResult result = MessageBox.Show("Suppression de la salle '" + numSalle + "' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Suppression de la salle sur la base de données
                Server.connect();
                Server.executeUpdate("DELETE FROM salle WHERE nosalle='" + numSalle + "'",
                         true);
                Server.disconnect();

                // Rafraichissement du DataGridView
                refreshDataGridViewSalles();

                CinemaMethods.alert("La salle " + numSalle + " a été supprimée");
            }
        }

        // Fonction de rafraichissement du datagridview de salle
        private void refreshDataGridViewSalles()
        {
            // Vide du DataGridView et réinitialisation la liste de salles
            dataGridViewSalles.Rows.Clear();
            salles = new List<Salle>();

            // Récupération de toutes lse salles
            Server.connect();
            Server.execute("SELECT * FROM salle ORDER BY nosalle ASC",
                true);

            while (Server.getReader().Read())
            {
                String noSalle = (String)Server.getReader()["nosalle"];
                int nbPlaces = (int)Server.getReader()["nbplaces"];
                salles.Add(new Salle(noSalle, nbPlaces));
                dataGridViewSalles.Rows.Add(noSalle, nbPlaces);
            }

            Server.disconnect();
        }
    }
}
