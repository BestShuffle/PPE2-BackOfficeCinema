using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CineDechDimitrio
{
    // Classe d'objet salle
    class Salle
    {
        private String id;
        private int nbPlaces;

        // Construit un objet salle
        public Salle(String id, int nbPlaces)
        {
            this.id = id;
            this.nbPlaces = nbPlaces;
        }

        // Fonction de récupération de l'identifiant 
        public String getId()
        {
            return this.id;
        }

        // Fonction de récupération du nombre de places
        public int getNbPlaces()
        {
            return this.nbPlaces;
        }

        // Fonction de définition du nombre de places
        public void setNbPlaces(int nbPlaces)
        {
            this.nbPlaces = nbPlaces;
        }
    }
}
