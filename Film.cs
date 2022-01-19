using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CineDechDimitrio
{
    // Classe d'objet film
    class Film
    {
        private int id;
        private String title;
        private String directors;
        private String actors;
        private String length;
        private String synopsis;
        private String infos;
        private String image;
        private List<Genre> genres;
        private Public publi;

        // Construit un objet film
        public Film(int id, String title, String directors, String actors,
            String length, String synopsis, String infos, String image,
            List<Genre> genres, Public publi)
        {
            this.id = id;
            this.title = title;
            this.directors = directors;
            this.actors = actors;
            this.length = length;
            this.synopsis = synopsis;
            this.infos = infos;
            this.image = image;
            this.genres = genres;
            this.publi = publi;
        }

        // Ajout d'un genre dans la liste s'il n'existe pas
        public void addGenre(Genre genre)
        {
            if (!genres.Contains(genre))
            {
                genres.Add(genre);
            }
        }

        // Fonction de suppression d'un genre dans la liste s'il existe
        public void removeGenre(Genre genre)
        {
            if (genres.Contains(genre))
            {
                genres.Remove(genre);
            }
        }

        // Fonction de récupération de l'identifiant
        public int getId()
        {
            return this.id;
        }

        // Fonction de récupération du titre
        public String getTitle()
        {
            return title;
        }
        
        // Fonction de définition dut itre
        public void setTitle(String title)
        {
            this.title = title;
        }

        // Fonction de récupération des directeurs
        public String getDirectors()
        {
            return directors;
        }

        // Fonction de définition des directeurs
        public void setDirectors(String director)
        {
            this.directors = director;
        }

        // Fonction de récupération des acteurs
        public String getActors()
        {
            return actors;
        }

        // Fonction de définition des acteurs
        public void setActors(String actors)
        {
            this.actors = actors;
        }

        // Fonction de récupération de la longueur du film
        public String getLength()
        {
            return length;
        }

        // Fonction de définition de la longueur du film
        public void setLength(String length)
        {
            this.length = length;
        }

        // Fonction de récupération du synopsis
        public String getSynopsis()
        {
            return synopsis;
        }

        // Fonction de définition du synopsis
        public void setSynopsis(String synopsis)
        {
            this.synopsis = synopsis;
        }

        // Fonction de récupération des informations
        public String getInfos()
        {
            return infos;
        }

        // Fonction de définition des informations
        public void setInfos(String infos)
        {
            this.infos = infos;
        }

        // Fonction de récupération de l'image d'affiche
        public String getImage()
        {
            return image;
        }

        // Fonction de définition de l'image d'affiche
        public void setImage(String image)
        {
            this.image = image;
        }

        // Fonction de récupération des genres associés
        public List<Genre> getGenres()
        {
            return genres;
        }

        // Fonction de définition des genres associés
        public void setGenres(List<Genre> genres)
        {
            this.genres = genres;
        }

        // Fonction de récupération du type de public associé
        public Public getPublic()
        {
            return publi;
        }

        // Fonction de définition du type de public associé
        public void setPublic(Public publi)
        {
            this.publi = publi;
        }
    }
}
