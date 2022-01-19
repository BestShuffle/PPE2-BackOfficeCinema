using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace CineDechDimitrio
{
    // Classe de base de données
    class Database
    {
        bool connected;

        public string host;
        public string databaseName;
        public string username;
        public string password;
        public OdbcConnection connection;
        public OdbcDataReader reader;
        public OdbcCommand command;

        // Construit un objet de base de données
        public Database(string host, string databaseName, string username, string password)
        {
            this.connected = false;
            this.host = host;
            this.databaseName = databaseName;
            this.username = username;
            this.password = password;
            this.connection = new OdbcConnection();
            // Définition de la chaîne de connexion à la base de données
            this.connection.ConnectionString = "Driver={MySQL ODBC 5.2 ANSI Driver};SERVER="
                + this.host + ";Database="
                + this.databaseName + ";uid="
                + this.username + ";pwd="
                + this.password;
        }

        // Fonction de connexion à la base de données
        public void connect()
        {
            if (this.isConnected())
            {
                this.disconnect();
            }
            this.connection.Open();
            this.command = new OdbcCommand();

            this.setConnected(true);
        }

        // Fonction de déconnexion à la base de données
        public void disconnect()
        {
            this.connection.Close();

            try
            {
                this.reader.Close();
            }
            catch (Exception ex) {}

            this.setConnected(false);
        }

        // Fonction d'envoi de requête avec récupération des données renvoyées par le serveur
        public Boolean execute(String request, Boolean showError)
        {
            try
            {
                this.command.CommandText = request;
                this.command.Connection = this.connection;
                this.reader = command.ExecuteReader();
                return true;
            }
            catch (OdbcException ex)
            {
                if (showError)
                {
                    CinemaMethods.alert("Erreur lors de l'envoi de la requête :\n" + ex.ToString());
                }
                disconnect();
                return false;
            }
        }

        // Fonction d'envoi de requête avec récupération de la première ligne retournée par le serveur
        public Object executeScalar(String request, Boolean showError)
        {
            try
            {
                this.command.CommandText = request;
                this.command.Connection = this.connection;
                return command.ExecuteScalar(); 
            }
            catch (OdbcException ex)
            {
                if (showError)
                {
                    CinemaMethods.alert("Erreur lors de l'envoi de la requête :\n" + ex.ToString());
                }
                disconnect();
                return new Object(); 
            }
        }

        // Fonction d'envoi de requête sans récupération des données renvoyées par le serveurs
        public Boolean executeUpdate(String request, Boolean showError)
        {
            try
            {
                this.command.CommandText = request;
                this.command.Connection = this.connection;
                this.command.ExecuteNonQuery();
                return true;
            }
            catch (OdbcException ex)
            {
                if (showError)
                {
                    CinemaMethods.alert("Erreur lors de l'envoi de la requête :\n" + ex.ToString());
                }
                disconnect();
                return false;
            }
        }

        // Fonction de lecture du reader
        public bool read()
        {
            return this.reader.Read();
        }

        // Fonction de récupération des données
        public Object getData(String dataName)
        {
            return this.reader[dataName];
        }

        // Fonction de récupération de l'adresse d'hôte
        public String getHost()
        {
            return this.host;
        }

        // Fonction de définition de l'adresse d'hôte
        public void setHost(String host)
        {
            this.host = host;
        }

        // Fonction de récupération du nom de la base de données
        public String getDatabaseName()
        {
            return this.databaseName;
        }

        // Fonction de définition du nom de la base de données
        public void setDatabaseName(String databaseName)
        {
            this.databaseName = databaseName;
        }

        // Fonction de récupération du nom d'utilisateur
        public String getUsername()
        {
            return this.username;
        }

        // Fonction de définition du nom d'utilisateur
        public void setUsername(String username)
        {
            this.username = username;
        }

        // Fonction de récupération du mot de passe
        public String getPassword()
        {
            return this.password;
        }

        // Fonction de définition du mot de passe
        public void setPassword(String password)
        {
            this.password = password;
        }

        // Fonction de récupération de la connexion
        public OdbcConnection getConnection()
        {
            return this.connection;
        }

        // Fonction de définition de la connexion
        public void setConnection(OdbcConnection connection)
        {
            this.connection = connection;
        }

        // Fonction de récupération du reader
        public OdbcDataReader getReader()
        {
            return this.reader;
        }

        // Fonction de définition du reader
        public void setReader(OdbcDataReader reader)
        {
            this.reader = reader;
        }

        // Fonction de récupération de l'état de la connexion
        public bool isConnected()
        {
            return this.connected;
        }

        // Fonction de définition d'état de la connexion
        public void setConnected(bool state)
        {
            this.connected = state;
        }
    }
}
