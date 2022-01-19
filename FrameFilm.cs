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
    // Classe de fenêtre de gestion de film
    public partial class FrameFilm : Form
    {
        List<Genre> filmGenres = new List<Genre>();
        List<Genre> genres;
        List<Public> publics;
        List<Film> films;

        // Initialisation de la fenêtre de gestion de film
        public FrameFilm()
        {
            InitializeComponent();
        }

        // Chargement de la frame
        private void FrameFilm_Load(object sender, EventArgs e)
        {
            // Chargement des genres et des publics
            loadGenres();
            loadPublics();
            // Chargement des films
            loadFilms();
            // Rafraichissement du DataGridView à partir de la base de données
            refreshDataGridViewFilms();
        }

        // Evènement de changement de ligne sur le grdFilms
        private void dataGridViewFilms_SelectionChanged(object sender, EventArgs e)
        {
            // Vérification qu'une ligne a bien été sélectionnée
            if (dataGridViewFilms.CurrentCell.RowIndex != -1)
            {
                // Récupération du film sélectionné et initialisation des variables
                // En cas de bug dû à une suppression on ne fait rien (try catch)
                try
                {
                    Film selectedFilm = films[dataGridViewFilms.CurrentCell.RowIndex];
                    Film whileFilm = films[0];
                    bool isFound = false;
                    int i = 0;

                    // Mise à jour des valeurs présentes dans les textbox
                    while (!isFound && i < films.Count)
                    {
                        whileFilm = films[i];
                        if (whileFilm.getId().Equals(selectedFilm.getId()))
                        {
                            txtFilmNo.Text = whileFilm.getId().ToString();
                            txtFilmTitle.Text = whileFilm.getTitle();
                            txtFilmDirectors.Text = whileFilm.getDirectors();
                            txtFilmActors.Text = whileFilm.getActors();
                            txtFilmLength.Text = whileFilm.getLength();
                            txtFilmSynop.Text = whileFilm.getSynopsis();
                            txtFilmInfos.Text = whileFilm.getInfos();
                            txtFilmAffiche.Text = whileFilm.getImage();
                            isFound = true;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    // Si la première recherche a aboutie on continue de charger les données
                    if (isFound)
                    {
                        // Réinitialisation des variables de la boucle while
                        isFound = false;
                        i = 0;

                        // Mise à jour du public du film actuel dans le combobox
                        while (!isFound && i < publics.Count)
                        {
                            if (selectedFilm.getPublic().getId() == publics[i].getId())
                            {
                                cboPublics.SelectedIndex = i;
                                isFound = true;
                            }
                            else
                            {
                                i++;
                            }
                        }

                        // Affichage des genres du film
                        if (isFound)
                        {
                            filmGenres = selectedFilm.getGenres();
                            loadLstGenres();
                        }
                    }
                }
                // En cas de suppression
                catch (ArgumentOutOfRangeException ex) {
                    txtFilmNo.Text = "";
                    txtFilmTitle.Text = "";
                    txtFilmDirectors.Text = "";
                    txtFilmActors.Text = "";
                    txtFilmLength.Text = "";
                    txtFilmSynop.Text = "";
                    txtFilmInfos.Text = "";
                    txtFilmAffiche.Text = "";
                    lstGenres.Items.Clear();
                    cboGenres.SelectedIndex = 0;
                    cboPublics.SelectedIndex = 0;
                }
            }
        }

        // Evènement de clic sur le bouton d'ajout de film
        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            /** Affichage de la fenêtre d'ajout de film en tant que fenêtre dialogue et
              * exécution de la fonction frameFilmAdd_FormClosed() en cas de fermeture. */
            FrameFilmAdd frameFilmAdd = new FrameFilmAdd();
            frameFilmAdd.FormClosing += new FormClosingEventHandler(frameFilmAdd_FormClosed);
            frameFilmAdd.ShowDialog();
        }

        // Evènement de fermeture de fenêtre d'ajout de serveur
        private void frameFilmAdd_FormClosed(Object sender, FormClosingEventArgs e)
        {
            // Rafraichissement du DataGridView
            loadFilms();
            refreshDataGridViewFilms();
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
            if (lstGenres.SelectedIndex != -1)
            {
                Genre genre = CinemaMethods.searchGenreByName(genres, lstGenres.Items[lstGenres.SelectedIndex].ToString());
                Console.WriteLine(genre.getName());
                if (filmGenres.Contains(genre))
                {
                    filmGenres.Remove(genre);
                    loadLstGenres();
                    CinemaMethods.alert("Le genre '" + genre.getName() + "' a été supprimé.");
                }
            }
        }

        // Evènement de clic sur le bouton d'édition de film
        private void btnEditFilm_Click(object sender, EventArgs e)
        {
            // Récupération du film sélectionné
            try
            {
                Film selectedFilm = films[dataGridViewFilms.CurrentCell.RowIndex];

                // Affichage d'une fenêtre de dialogue demandant si le film choisi doit bien être modifié
                DialogResult result = MessageBox.Show("Modification du film '" + selectedFilm.getTitle() + "' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    // Récupération des données présentes dans les champs
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

                    // Affectation des données locales sur la base de données
                    Server.connect();

                    Server.executeUpdate("UPDATE film SET "
                    + "titre='" + title + "', "
                    + "realisateurs='" + directors + "', "
                    + "acteurs='" + actors + "', "
                    + "duree='" + length + "', "
                    + "synopsis='" + synopsis + "', "
                    + "infofilm='" + informations + "', "
                    + "imgaffiche='" + affiche + "', "
                    + "nopublic=" + publicNb
                    + " WHERE nofilm='" + selectedFilm.getId() + "'",
                    true);

                    // Suppression des anciens genres
                    Server.executeUpdate("DELETE FROM concerner WHERE " + "nofilm=" + selectedFilm.getId(), true);

                    // Ajout des genres du film dans la base de données
                    foreach (Genre genre in filmGenres)
                    {
                        Server.executeUpdate("INSERT INTO concerner VALUES ("
                            + selectedFilm.getId() + ", "
                            + genre.getId() + ")", true);
                    }

                    Server.disconnect();

                    // Rafraichissement du DataGridView
                    loadFilms();
                    refreshDataGridViewFilms();
                    CinemaMethods.alert("Le film '" + selectedFilm.getTitle() + "' a été modifié.");
                }
            }
            catch (NullReferenceException ex)
            {
                CinemaMethods.alert("Aucun film sélectionné");
            }
        }

        // Evènement de clic sur le bouton de suppression de film
        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            // Récupération du film sélectionné
            Film selectedFilm = films[dataGridViewFilms.CurrentCell.RowIndex];

            // Affichage d'une fenêtre de dialogue demandant si le film choisi doit bien être modifié
            DialogResult result = MessageBox.Show("Suppression du film '" + selectedFilm.getTitle() + "' ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Suppression du film sur la base de données
                Server.connect();
                // Suppression des projections associées (pour éviter les bugs associés à la dépendance des foreign keys)
                Server.executeUpdate("DELETE FROM projection WHERE " + "nofilm=" + selectedFilm.getId(), true);
                // Suppression des genres (pour éviter les bugs associés à la dépendance des foreign keys)
                Server.executeUpdate("DELETE FROM concerner WHERE " + "nofilm=" + selectedFilm.getId(), true);
                // Suppression du film
                Server.executeUpdate("DELETE FROM film WHERE nofilm=" + selectedFilm.getId(),
                    true);
                Server.disconnect();

                CinemaMethods.alert("Le film '" + selectedFilm.getTitle() + "' a été supprimé.");

                // Rafraichissement du DataGridView
                loadFilms();
                refreshDataGridViewFilms();
            }
        }

        // Fonction de chargement de la listbox de genres du film
        private void loadLstGenres()
        {
            // Vide de la liste
            lstGenres.Items.Clear();

            // Ajout de la liste dans la listbox
            foreach (Genre genre in filmGenres)
            {
                lstGenres.Items.Add(genre.getName());
            }
        }

        // Fonction de chargement des genres des films
        private void loadFilmGenres()
        {
            foreach (Film film in films)
            {
                // Récupération des genres et intégration dans la liste et dans le ComboBox
                Server.connect();
                Server.execute("SELECT nogenre from concerner WHERE nofilm=" + film.getId(),
                             true);

                while (Server.getReader().Read())
                {
                    film.addGenre(CinemaMethods.searchGenreById(genres, (int)Server.getReader()["nogenre"]));
                }

                Server.disconnect();
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

        // Fonction de chargement de la liste des publics
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

        // Fonction de chargement des films
        public void loadFilms()
        {
            // On vide la liste
            films = new List<Film>();

            // Récupération des films et de leur type de public associé
            Server.connect();

            Server.execute("SELECT * FROM film, public WHERE film.nopublic = public.nopublic ORDER BY nofilm ASC", true);

            // Ajout des films dans la liste
            while (Server.getReader().Read())
            {
                int noFilm = Convert.ToInt32(Server.getReader()["nofilm"]);
                String title = (String)Server.getReader()["titre"];
                String directors = (String)Server.getReader()["realisateurs"];
                String actors = (String)Server.getReader()["acteurs"];
                String length = (String)Server.getReader()["duree"];
                String synopsis = (String)Server.getReader()["synopsis"];
                String informations = (String)Server.getReader()["infofilm"];
                String affiche = (String)Server.getReader()["imgaffiche"];

                int publicNb = Convert.ToInt32(Server.getReader()["nopublic"]);
                String publicLib = (String)Server.getReader()["libpublic"];

                films.Add(new Film(noFilm, title, directors, actors, length, synopsis, informations, affiche, new List<Genre>(), new Public(publicNb, publicLib)));
            }

            Server.disconnect();

            // Chargement des genres de chaque films
            loadFilmGenres();
        }

        // Fonction de rafraichissement du DataGridView de film
        public void refreshDataGridViewFilms()
        {
            // On vide le DataGridView
            dataGridViewFilms.Rows.Clear();

            // Ajout des films dans le datagridview
            foreach (Film film in films)
            {
                dataGridViewFilms.Rows.Add(film.getId(), film.getTitle());
            }
        }
    }
}
