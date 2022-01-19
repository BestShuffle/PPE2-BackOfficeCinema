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
    public partial class FrameProjectionAdd : Form
    {

        // Fonction de chargement de la fenêtre
        public FrameProjectionAdd()
        {
            InitializeComponent();
        }

        // Chargement de la frame
        private void FrameProjection_Load(object sender, EventArgs e)
        {
            // Rafraichissement des DataGridViews
            refreshDataGridViewFilm();
            refreshcbosalle();
        }

        // Fonction de rafraichissement du datagridview de salle
        private void refreshcbosalle()
        {
            // Vide du cbo
            cbosalle.Items.Clear();

            // Connexion et récupération des données
            Server.connect();
            Server.execute("SELECT nosalle FROM salle ORDER BY nosalle ASC",
                true);

            while (Server.read())
            {
                // Ajout dans le DataGridView
                cbosalle.Items.Add(Server.getReader()["nosalle"]);
            }

            Server.disconnect();
        }

        // Fonction de rafraichissement du datagridview de film
        private void refreshDataGridViewFilm()
        {
            // Vide du DataGridView
            dataGridViewFilm.Rows.Clear();

            // Connexion et récupération des données
            Server.connect();
            Server.execute("SELECT nofilm, titre FROM film ORDER BY nofilm ASC",
                true);
            while (Server.read())
            {
                // Ajout dans le DataGridView
                dataGridViewFilm.Rows.Add(Server.getReader()["nofilm"], Server.getReader()["titre"]);
            }
            Server.disconnect();
        }

        // Event de clic sur le bouton d'ajout de projection
        private void btnvalider_Click(object sender, EventArgs e)
        {
            // Récupération des données entrées par l'utilisateur
            string strdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string strheure = dateTimePicker2.Value.ToString("HH:mm");
            string infos = txtInfos.Text.Replace("'", "''");

            // Correction des données entrées
            CinemaMethods.correctTextField(ref infos);

            // Ajout en base de données
            Server.connect();
            Server.executeUpdate("INSERT into projection (nofilm, dateproj,heureproj,infoproj,nosalle) VALUES ('" + dataGridViewFilm[0, dataGridViewFilm.CurrentCell.RowIndex].Value + "', '" + strdate + "','" + strheure + "', '" + infos + "', '" + cbosalle.Items[cbosalle.SelectedIndex] + "')",
                true);
            CinemaMethods.alert("Votre projection a bien été ajouté");
            Server.disconnect();

            this.Close();
        }
    }
}
