using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CineDechDimitrio
{
    // Classe d'objet public
    class Public
    {
        private int id;
        private String name;

        // Construit un objet public
        public Public(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        // Fonction de récupération de l'identifiant
        public int getId()
        {
            return this.id;
        }

        // Fonction de récupération du nom
        public String getName()
        {
            return this.name;
        }

        // Fonction de définition du nom
        public void setName(String name)
        {
            this.name = name;
        }
    }
}
