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
    // Classe de fenêtre de gestion de démarrage
    public partial class FrameCinema : Form
    {
        DateTimePicker dateHebdoPicker;
        FrameFilm frameFilm;
        FrameGenre frameGenre;
        FrameSalle frameSalle;
        FrameProjection frameProjection;

        // Initialisation de la fenêtre de gestion de démarrage
        public FrameCinema()
        {
            InitializeComponent();
        }

        // Chargement de la frame
        private void FormCinema_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            
            // Ajout du DateTimePicker dans le MenuStrip
            dateHebdoPicker = new DateTimePicker();
            ToolStripControlHost pickerToolStrip = new ToolStripControlHost(dateHebdoPicker);
            menuStrip1.Items.Add(pickerToolStrip);

            // Chargement de la config
            Server.loadProperties();
        }

        // Evènement de clic sur le strip de film
        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frameFilm == null || frameFilm.IsDisposed)
            {
                frameFilm = new FrameFilm();
                frameFilm.MdiParent = this;
                frameFilm.Show();
            }
        }

        // Evènement de clic sur le strip de genre
        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frameGenre == null || frameGenre.IsDisposed)
            {
                frameGenre = new FrameGenre();
                frameGenre.MdiParent = this;
                frameGenre.Show();
            }
        }

        // Evènement de clic sur le strip de salle
        private void salleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frameSalle == null || frameSalle.IsDisposed)
            {
                frameSalle = new FrameSalle();
                frameSalle.MdiParent = this;
                frameSalle.Show();
            }
        }

        // Evènement de clic sur le strip de projection
        private void projectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frameProjection == null || frameProjection.IsDisposed)
            {
                frameProjection = new FrameProjection();
                frameProjection.MdiParent = this;
                frameProjection.Show();
            }
        }

        // Evènement de 
        private void listeDesProjectionsHebdomadaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook claexcel = appExcel.Workbooks.Add();
            // Récupération de la date choisie par l'utilisateur et de la date dans 7 jours
            DateTime dateFirstDay = dateHebdoPicker.Value;
            DateTime dateLastDay = dateFirstDay.AddDays(7);

            // Définition des lignes et colonnes à utiliser par défaut
            int titleRow = 1;
            int descRow = 2;
            int projColumn = 2;
            int firstDateRow = 4;

            // Mise en place du style des premières cellules
            for (int row = titleRow; row <= descRow; row++)
            {
                centerTextInCell(appExcel, row, 1);
                setCellFont(appExcel, row, 1, "Calibri");
                appExcel.Sheets[1].cells[row, 1].ColumnWidth = 45;
                appExcel.Sheets[1].cells[row, 1].RowHeight = 30;
                appExcel.Sheets[1].cells[row, 1].Font.Size = 15;
            }

            // Définition de la valeur de la cellule de titre
            appExcel.Sheets[1].cells[titleRow, 1].value = "Programmation du CineDechDimitrio";

            // Définition de la valeur de la cellule de description
            appExcel.Sheets[1].cells[descRow, 1].value = "Du " + dateFirstDay.ToString("dd/MM/yyyy") + " au " + dateLastDay.ToString("dd/MM/yyyy");

            // Définition de la largeur des cellules de projection
            appExcel.Sheets[1].cells[1, projColumn].ColumnWidth = 45;

            int lastRow = firstDateRow;

            // Boucle permettant d'avancer de jour en jour (et de ligne en ligne)
            for (DateTime date = dateFirstDay; date < dateLastDay; date = date.AddDays(1), lastRow += 2)
            {
                // Mise en place du style de la cellule de date
                centerTextInCell(appExcel, lastRow, 1);
                setCellFont(appExcel, lastRow, 1, "Calibri");
                appExcel.Sheets[1].cells[lastRow, 1].RowHeight = 20;
                appExcel.Sheets[1].cells[lastRow, 1].Font.Size = 13;

                // Définition de la valeur de la cellule de date
                appExcel.Sheets[1].cells[lastRow, 1].value = date.ToString("MM/dd/yyyy");

                Server.connect();

                // Récupération des projections associées à ce jour
                Server.execute("SELECT heureproj, nosalle, titre FROM film, projection WHERE "
                    + "dateproj = '" + date.ToString("yyyy-MM-dd") + "' AND "
                    + "projection.nofilm = film.nofilm "
                    + "ORDER BY heureproj",
                    true);

                while (Server.read())
                {
                    // On avance d'une ligne
                    lastRow++;

                    // Ajout de la projection à la table excel
                    addProjToTab(appExcel, Server.getReader(), lastRow, projColumn);
                }

                Server.disconnect();
            }

            // Affichage du planning
            appExcel.Visible = true;

            claexcel = null;
            appExcel = null;
        }

        // Fonction définissant la police d'écriture dans une cellule
        private void setCellFont(Excel.Application appExcel, int row, int column, String fontName)
        {
            appExcel.Sheets[1].cells[row, column].Font.Name = fontName;
        }

        // Fonction centrant le texte dans une cellule
        private void centerTextInCell(Excel.Application appExcel, int row, int column)
        {
            appExcel.Sheets[1].cells[row, column].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            appExcel.Sheets[1].cells[row, column].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }

        // Fonction d'ajout de projection dans la table excel
        private void addProjToTab(Excel.Application appExcel, OdbcDataReader reader, int row, int column)
        {
            TimeSpan hourProj = (TimeSpan)reader["heureproj"];
            String title = (String)reader["titre"];
            String noSalle = (String)reader["nosalle"];

            // Mise en place du style des cellules utilisées    
            for (int actualColumn = column - 1; actualColumn < column + 1; actualColumn++)
            {
                centerTextInCell(appExcel, row, actualColumn);
                appExcel.Sheets[1].cells[row, actualColumn].Font.Name = "Calibri";
                appExcel.Sheets[1].cells[row, actualColumn].Font.Size = 12;
                appExcel.Sheets[1].cells[row, actualColumn].RowHeight = 20;
            }

            // Entrée des valeurs dans les cellules
            appExcel.Sheets[1].cells[row, column - 1].Value = hourProj.ToString(@"hh\hmm");
            appExcel.Sheets[1].cells[row, column].Value = title;
            appExcel.Sheets[1].cells[row, column + 1].Value = "Salle " + noSalle;
        }
    }
}
