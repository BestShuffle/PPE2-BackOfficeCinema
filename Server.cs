using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CineDechDimitrio
{
    // Classe de serveur
    class Server
    {
        // Base de données utilisée dans tout le projet
        public static Database database;

        // Fonction de chargement des propriétés serveur
        public static void loadProperties()
        {
            String[] properties = System.IO.File.ReadAllLines(Application.StartupPath + "\\config.ini");

            try
            {
                database = new Database(properties[0], properties[1], properties[2], properties[3]);
            }
            catch (Exception)
            {
                CinemaMethods.alert("Erreur de chargement du fichier de configuration");
                Application.Exit();
            }
        }

        // Fonction de connexion à la base de données
        public static void connect()
        {
            database.connect();
        }

        // Fonction de déconnexion à la base de données
        public static void disconnect()
        {
            database.disconnect();
        }

        // Fonction d'envoi de requête à la base de données
        public static Boolean execute(String request, Boolean showError)
        {
            return database.execute(request, showError);
        }

        // Fonction d'envoi de requête avec première ligne retournée
        public static Object executeScalar(String request, Boolean showError)
        {
            return database.executeScalar(request, showError);
        }

        // Fonction d'envoi de requête de mise à jour de données à la base de données
        public static Boolean executeUpdate(String request, Boolean showError)
        {
            return database.executeUpdate(request, showError);
        }

        // Fonction de lecture du reader
        public static bool read()
        {
            return database.read();
        }

        // Fonction de récupération du reader
        public static OdbcDataReader getReader()
        {
            return database.getReader();
        }
    }
}
