using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CineDechDimitrio
{
    // Classe d'objet projection
    class Projection
    {
        private int id;
        private DateTime date;
        private DateTime hour;
        private String infos;
        private Salle salle;
        private Film film;

        // Construit un objet projection
        public Projection(int id, DateTime date, DateTime hour,
            String infos, Salle salle, Film film)
        {
            this.id = id;
            this.date = date;
            this.hour = hour;
            this.infos = infos;
            this.salle = salle;
            this.film = film;
        }

        // Fonction de récupération de l'identifiant
        public int getId()
        {
            return this.id;
        }

        // Fonction de récupération de la date de projection
        public DateTime getDate()
        {
            return this.date;
        }

        // Fonction de définition de la date de projection
        public void setDate(DateTime date)
        {
            this.date = date;
        }

        // Fonction de récupération de l'heure de projection
        public DateTime getHour()
        {
            return this.hour;
        }

        // Fonction de définition de l'heure de projection
        public void setHour(DateTime hour)
        {
            this.hour = hour;
        }

        // Fonction de récupération des informations
        public String getInfos()
        {
            return this.infos;
        }

        // Fonction de définition des informations
        public void setInfos(String infos)
        {
            this.infos = infos;
        }

        // Fonction de récupération de la salle associée
        public Salle getSalle()
        {
            return this.salle;
        }

        // Fonction de définition de la salle associée
        public void setSalle(Salle salle)
        {
            this.salle = salle;
        }

        // Fonction de récupération du film associé
        public Film getFilm()
        {
            return this.film;
        }

        // Fonction de définition du film associé
        public void setFilm(Film film)
        {
            this.film = film;
        }
    }
}
