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
    public partial class FrameProjection : Form
    {
        // Chargement de la fenêtre
        public FrameProjection()
        {
            InitializeComponent();
        }

        // Chargement de l'interface de la fenêtre
        private void FrameProjectionAdd_Load(object sender, EventArgs e)
        {
            // Rafraichissement du DataGridView
            refreshgrdProj();
        }

        // Event de clic sur le bouton de retour a la page FrameProjection.cs
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /** Affichage de la fenêtre d'ajout de film en tant que fenêtre dialogue et
              * exécution de la fonction frameprojectionAdd_FormClosed() en cas de fermeture. */
            FrameProjectionAdd frameProjectionAdd = new FrameProjectionAdd();
            frameProjectionAdd.FormClosing += new FormClosingEventHandler(frameProjectionAdd_FormClosed);
            frameProjectionAdd.ShowDialog();
        }

        // Evènement de fermeture de fenêtre d'ajout de serveur
        private void frameProjectionAdd_FormClosed(Object sender, FormClosingEventArgs e)
        {
            // Rafraichissement du DataGridView
            refreshgrdProj();
        }

        // Fonction de rafraichissement du datagridview de projection
        private void refreshgrdProj()
        {
            // Vide du DataGridView
            grdProj.Rows.Clear();

            // Récupération des données
            Server.connect();
            Server.execute("SELECT titre, dateproj, heureproj, infoproj, nosalle FROM film, projection WHERE film.nofilm=projection.nofilm",
                true);
            while (Server.read())
            {
                DateTime date = Convert.ToDateTime(Server.getReader()["dateproj"]);
                TimeSpan heure = TimeSpan.Parse(Server.getReader()["heureproj"].ToString());

                // Ajout des données dans le DataGridView
                grdProj.Rows.Add(Server.getReader()["titre"], date.ToString("dd/MM/yyyy"), heure.ToString(@"hh\hmm"), Server.getReader()["infoproj"], Server.getReader()["nosalle"]);
            }
            Server.disconnect();
        }
    }
}
