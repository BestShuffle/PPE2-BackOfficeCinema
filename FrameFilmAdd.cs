using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CineDechDimitrio
{
    // Classe de fenêtre d'ajout de film
    public partial class FrameFilmAdd : Form
    {
        List<Genre> filmGenres = new List<Genre>();
        List<Genre> genres;
        List<Public> publics;

        // Initialisation de la fenêtre d'ajout de film
        public FrameFilmAdd()
        {
            InitializeComponent();
        }

        // Evènement de chargement de la fenêtre
        private void FrameFilmAdd_Load(object sender, EventArgs e)
        {
            // Chargement des genres et publics
            loadGenres();
            loadPublics();
        }


        // Evènement de clic sur le bouton d'ajout de film
        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            // Récupération des données entrées par l'utilisateur
            String title = txtFilmTitle.Text;
            String directors = txtFilmDirectors.Text;
            String actors = txtFilmActors.Text;
            String length = txtFilmLength.Text;
            String synopsis = txtFilmSynop.Text;
            String informations = txtFilmInfos.Text;
            String affiche = txtFilmAffiche.Text;
            int publicNb = publics[cboPublics.SelectedIndex].getId();

            // Correction du contenu des champs
            CinemaMethods.correctTextField(ref title);
            CinemaMethods.correctTextField(ref directors);
            CinemaMethods.correctTextField(ref actors);
            CinemaMethods.correctTextField(ref length);
            CinemaMethods.correctTextField(ref synopsis);
            CinemaMethods.correctTextField(ref informations);
            CinemaMethods.correctTextField(ref affiche);
            
            Server.connect();

            // Ajout du film dans la base de données
            Server.executeUpdate("INSERT INTO film (titre, realisateurs, acteurs, duree, synopsis, infofilm, imgaffiche, nopublic) VALUES ('"
                                     + title + "', '" + directors + "', '" + actors + "', '" + length + "', '" + synopsis + "', '"
                                     + informations + "', '" + affiche + "', " + publicNb + ")",
                                  true);

            // Récupération du numéro de film par son synopsis (qui est sensé être unique)
            int noFilm = (int)Server.executeScalar("SELECT nofilm FROM film WHERE synopsis = '" + synopsis + "'", true);

            // Ajout des genres du film dans la base de données
            foreach (Genre genre in filmGenres)
            {
                Server.executeUpdate("INSERT INTO concerner VALUES ("
                    + noFilm + ", "
                    + genre.getId() + ")", true);
            }

            Server.disconnect();

            this.Close();
        }

        // Fonction d'ajout de genre
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            Genre genre = genres[cboGenres.SelectedIndex];

            if (!filmGenres.Contains(genre))
            {
                filmGenres.Add(genre);
                CinemaMethods.alert("Le genre '" + genre.getName() + "' a été ajouté.");
                loadLstGenres();
            }
        }

        // Fonction de suppression de genre
        private void btnRemoveGenre_Click(object sender, EventArgs e)
        {
            // On cherche l'objet genre à partir du nom sélectionné
            Genre genre = CinemaMethods.searchGenreByName(genres, lstGenres.Items[lstGenres.SelectedIndex].ToString());
            Console.WriteLine(genre.getName());
            if (filmGenres.Contains(genre))
            {
                filmGenres.Remove(genre);
                loadLstGenres();
                CinemaMethods.alert("Le genre '" + genre.getName() + "' a été supprimé.");
            }
        }

        // Fonction de chargement de la listbox de genres du film
        private void loadLstGenres()
        {
            // Vide de la liste
            lstGenres.Items.Clear();

            // Ajout des genres dans la listbox
            foreach (Genre genre in filmGenres)
            {
                lstGenres.Items.Add(genre.getName());
            }
        }

        // Fonction de chargement des genres
        private void loadGenres()
        {
            // Vide du ComboBox puis réinitialisation de la liste de genres
            cboGenres.Items.Clear();

            genres = new List<Genre>();

            // Récupération des genres et intégration dans la liste et dans le ComboBox
            Server.connect();
            Server.execute("SELECT * from genre ORDER BY libgenre",
                         true);

            while (Server.getReader().Read())
            {
                int idGenre = Convert.ToInt32(Server.getReader()["nogenre"]);
                String libGenre = (String)Server.getReader()["libgenre"];

                cboGenres.Items.Add(libGenre);

                genres.Add(new Genre(idGenre, libGenre));
            }

            /* Sélection du tout premier genre par défaut pour ne pas laisser le
             * comboBox vide */
            cboGenres.SelectedIndex = 0;

            Server.disconnect();
        }

        // Fonction de chargement des publics
        private void loadPublics()
        {
            // Vide du ComboBox puis réinitialisation de la liste de publics
            cboPublics.Items.Clear();

            publics = new List<Public>();

            // Récupération des publics et intégration dans la liste et dans le ComboBox
            Server.connect();
            Server.execute("SELECT * from public",
                         true);

            while (Server.getReader().Read())
            {
                int nbPublic = Convert.ToInt32(Server.getReader()["nopublic"]);
                String libPublic = (String)Server.getReader()["libpublic"];

                cboPublics.Items.Add(libPublic);

                publics.Add(new Public(nbPublic, libPublic));
            }

            /* Sélection du tout premier publics par défaut pour ne pas laisser le
             * comboBox vide */
            cboPublics.SelectedIndex = 0;

            Server.disconnect();
        }
    }
}
