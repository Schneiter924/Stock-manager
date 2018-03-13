using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Stock_manager
{
    public class Connection_mySQL
    {
        private MySqlConnection connection;
        private string serveur;
        private string baseDonnee;
        private string utilisateur;
        private string motPasse;

        //Constructor
        public Connection_mySQL()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            serveur = Properties.Settings.Default.serveur;
            baseDonnee = Properties.Settings.Default.baseDonnee;
            utilisateur = Properties.Settings.Default.utilisateur;
            motPasse = Properties.Settings.Default.motPasse;
            string connectionString;
            connectionString = "SERVER=" + serveur + ";" + "DATABASE=" +
            baseDonnee + ";" + "UID=" + utilisateur + ";" + "PASSWORD=" + motPasse + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        /// <summary>
        /// fonction qui test si le produit existe ou pas
        /// </summary>
        /// <param name="idProduit"></param>
        /// <returns>object</returns>
        public object TestIDProduit(int idProduit)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "Select * from Produit where idProduit =(@idProduit)";

            cmd.Parameters.AddWithValue("@idProduit", idProduit);

            object resultat = cmd.ExecuteScalar();

            connection.Close();

            return resultat;
        }


        /// <summary>
        /// fonction qui retourne le nom et la description du Produit qui a l'idProduit égale au paramètre passé
        /// </summary>
        /// <param name="idProduit"></param>
        /// <returns>Produit</returns>
        public Produit RetourProduit(int idProduit)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "Select idProduit, nomProduit, description from Produit where idProduit =(@idProduit)";

            cmd.Parameters.AddWithValue("@idProduit", idProduit);

            MySqlDataReader p = cmd.ExecuteReader();
            Produit produit = new Produit();
            while (p.Read())
            {
                produit.IdProduit = Convert.ToInt32(p[0]);
                produit.NomProduit = Convert.ToString(p[1]);
                produit.Description = Convert.ToString(p[2]);
            }
            connection.Close();

            return produit;
        }

        /// <summary>
        /// fonction qui ajout un nouveau produit dans la base de donnée
        /// </summary>
        /// <param name="produit"></param>
        public void NouveauProduit (Produit produit)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Produit (nomProduit, description) VALUES (@nomProduit, @description)";

            cmd.Parameters.AddWithValue("@nomProduit", produit.NomProduit);

            cmd.Parameters.AddWithValue("@description", produit.Description);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction qui modifier le produit dans la base de donnée
        /// </summary>
        /// <param name="produit"></param>
        public void ModificationProduit (Produit produit)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "update produit set nomProduit=(@nomProduit), description=(@description) where idProduit = (@idProduit)";

            cmd.Parameters.AddWithValue("@idProduit", produit.IdProduit);

            cmd.Parameters.AddWithValue("@nomProduit", produit.NomProduit);

            cmd.Parameters.AddWithValue("@description", produit.Description);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction qui retourne toutes les locations en cours
        /// </summary>
        /// <returns>retoure une liste de location</returns>
        public List<Location> LocationEnCours()
        {
            List<Location> lstlocations = new List<Location>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Location INNER JOIN Loueur ON idLoueur = fkLoueur INNER JOIN Produit ON idProduit = fkProduit WHERE endDate IS NULL ORDER BY startDate";

            MySqlDataReader l = cmd.ExecuteReader();

            while (l.Read())
            {
                Location location = new Location();
                Produit produit = new Produit();
                Loueur loueur = new Loueur();

                location.IdLocation = Convert.ToInt32(l["idLocation"]);
                location.StartDate = Convert.ToDateTime(l["startDate"]);
                produit.IdProduit = Convert.ToInt32(l["idProduit"]);
                produit.NomProduit = Convert.ToString(l["nomProduit"]);
                produit.Description = Convert.ToString(l["description"]);
                loueur.IdLoueur = Convert.ToInt32(l["idLoueur"]);
                loueur.NomLoueur = Convert.ToString(l["nomLoueur"]);
                location.Produit = produit;
                location.Loueur = loueur;
                lstlocations.Add(location);
            }

            connection.Close();

            return lstlocations;
        }

        /// <summary>
        /// fonction qui retour la location qui correspont à l'id du produit selectionner
        /// </summary>
        /// <param name="produit"></param>
        /// <returns></returns>
        public Location LocationSelectionner(int idProduit)
        {
            Location location = new Location();
            Produit produit = new Produit();
            Loueur loueur = new Loueur();

            connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT* FROM Location INNER JOIN Loueur ON idLoueur = fkLoueur INNER JOIN Produit ON idProduit = fkProduit WHERE endDate IS NULL and idProduit = @idProduit ORDER BY startDate";

            cmd.Parameters.AddWithValue("@idProduit", idProduit);

            MySqlDataReader l = cmd.ExecuteReader();

            while (l.Read())
            {
                location.IdLocation = Convert.ToInt32(l["idLocation"]);
                location.StartDate = Convert.ToDateTime(l["startDate"]);
                produit.IdProduit = Convert.ToInt32(l["idProduit"]);
                produit.NomProduit = Convert.ToString(l["nomProduit"]);
                produit.Description = Convert.ToString(l["description"]);
                loueur.IdLoueur = Convert.ToInt32(l["idLoueur"]);
                loueur.NomLoueur = Convert.ToString(l["nomLoueur"]);
                location.Produit = produit;
                location.Loueur = loueur; 
            }

            connection.Close();

            return location;
        }

        /// <summary>
        /// fonction qui efface le produit selectionner
        /// </summary>
        /// <param name="produit"></param>
        public void SupprimerProduit(Produit produit)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "DELETE FROM Produit WHERE idProduit = @idProduit";

            cmd.Parameters.AddWithValue("@idProduit", produit.IdProduit);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void SupprimerLoueur(Loueur loueur)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "DELETE FROM Loueur where idLoueur = @idLoueur";

            cmd.Parameters.AddWithValue("@idLoueur", loueur.IdLoueur);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction qui ajout une nouvelle location dans la base de donnée
        /// </summary>
        /// <param name="location"></param>
        public void NouvelleLocation(Location location)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Location (startDate, duree, fkLoueur, fkProduit) VALUES (@startDate, @duree, @fkLoueur, @fkProduit)";

            cmd.Parameters.AddWithValue("@startDate", location.StartDate);

            cmd.Parameters.AddWithValue("@duree", location.Duree);

            cmd.Parameters.AddWithValue("@fkLoueur", location.Loueur.IdLoueur);

            cmd.Parameters.AddWithValue("@fkProduit", location.Produit.IdProduit);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction qui fait la modification sur la location sélectionne pour mettre une date de retour
        /// </summary>
        /// <param name="location"></param>
        public void RetourLocation(Location location)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "UPDATE Location set endDate = @endDate where fkProduit = @idProduit and endDate is null";

            cmd.Parameters.AddWithValue("@endDate", location.EndDate.ToString("yyyy-MM-dd HH:mm:ss"));

            cmd.Parameters.AddWithValue("@idProduit",location.Produit.IdProduit);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction qui ajout un loueur dans la base de donnée
        /// </summary>
        /// <param name="nom"></param>
        public void AjoutLoueur (string nom)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Loueur (nomLoueur) VALUES (@nomLoueur)";

            cmd.Parameters.AddWithValue("@nomLoueur", nom);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        
        /// <summary>
        /// fonction qui test si le loueur existe dans la base de donnée
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>un object</returns>
        public object TestNomLoueur (string nom)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Loueur WHERE nomLoueur like (@nomLoueur)";

            cmd.Parameters.AddWithValue("@nomLoueur", nom);

            object resultat = cmd.ExecuteScalar();

            connection.Close();

            return resultat;
        }

        /// <summary>
        /// fonction qui modifier un loueur
        /// </summary>
        /// <param name="loueur"></param>
        public void ModificationLoueur(Loueur loueur)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "UPDATE Loueur set nomLoueur = @nomLoueur where idLoueur = @idLoueur";

            cmd.Parameters.AddWithValue("@nomLoueur", loueur.NomLoueur);

            cmd.Parameters.AddWithValue("@idLoueur", loueur.IdLoueur);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction sélectionne les produits en stock
        /// </summary>
        /// <returns>retourne une liste de produit</returns>
        public List<Produit> chargeProduitEnStock()
        {
            List<Produit> lstProduits = new List<Produit>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * from Produit WHERE idProduit NOT IN (SELECT fkproduit FROM Location WHERE enddate IS NULL) ORDER BY idproduit";

            MySqlDataReader p = cmd.ExecuteReader();

            while (p.Read())
            {
                Produit produit = new Produit();
                produit.IdProduit = Convert.ToInt32(p[0]);
                produit.NomProduit = Convert.ToString(p[1]);
                produit.Description = Convert.ToString(p[2]);
                lstProduits.Add(produit);
            }

            connection.Close();

            return lstProduits;
        }

        /// <summary>
        /// fonction qui compte le nombre total de produit dans la base de donnée
        /// </summary>
        /// <returns>retourne un int</returns>
        public int CompteProduitTotal()
        {
            object resultat;
            int nombre;

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "Select count(*) FROM Produit";

            resultat = cmd.ExecuteScalar();

            if (resultat != null)
            {
                nombre = Convert.ToInt32(resultat);
            }
            else
            {
                nombre = 0;
            }
            connection.Close();

            return nombre;
        }

        /// <summary>
        /// fonction qui compte le nombre de produit en stock
        /// </summary>
        /// <returns>retourne un int</returns>
        public int CompteProduitEnStock()
        {
            object resultat;
            int nombre;

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM Produit WHERE idProduit NOT IN (SELECT fkproduit FROM Location WHERE enddate IS NULL) ORDER BY idproduit";

            resultat = cmd.ExecuteScalar();

            if (resultat != null)
            {
                nombre = Convert.ToInt32(resultat);
            }
            else
            {
                nombre = 0;
            }

            connection.Close();

            return nombre;
        }

        /// <summary>
        /// fonction qui retourne un loueur avec comme paramétre le nom
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>loueur</returns>
        public Loueur LoueurSelectionnerNom(string nom)
        {
            connection.Open();

            Loueur loueur = new Loueur();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Loueur WHERE nomLoueur like @nomLoueur";

            cmd.Parameters.AddWithValue("@nomLoueur", nom);

            MySqlDataReader l = cmd.ExecuteReader();

            while (l.Read())
            {                
                loueur.IdLoueur = Convert.ToInt32(l["idLoueur"]);
                loueur.NomLoueur = Convert.ToString(l["nomLoueur"]);
            }

            connection.Close();

            return loueur;
        }

        /// <summary>
        /// fonction qui sélectionne tous les loueurs
        /// </summary>
        /// <returns>retourne une liste de loueurs</returns>
        public List<Loueur> chargeLoueur()
        {
            List<Loueur> lstLoueurs = new List<Loueur>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "select * FROM Loueur order by nomLoueur";

            MySqlDataReader l = cmd.ExecuteReader();
            
            while (l.Read())
            {
                Loueur loueur = new Loueur();
                loueur.IdLoueur = Convert.ToInt32(l[0]);
                loueur.NomLoueur = Convert.ToString(l[1]);
                lstLoueurs.Add(loueur);
            }

            connection.Close();

            return lstLoueurs;
        }
        
        /// <summary>
        /// fonction qui recherche le produit qui est hors du délais
        /// </summary>
        /// <returns>retourne une location</returns>
        public Location ProduitHorsDelais(Location location)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Location INNER JOIN Loueur ON idLoueur = fkLoueur INNER JOIN Produit ON idProduit = fkProduit WHERE endDate IS NULL AND DATE_ADD(startDate, INTERVAL @duree DAY) < NOW() AND idProduit=@idproduit";

            cmd.Parameters.AddWithValue("@duree", location.Duree);
            cmd.Parameters.AddWithValue("@idProduit", location.Produit.IdProduit);

            MySqlDataReader l = cmd.ExecuteReader();

            Location locationRec = new Location();

            Produit produit = new Produit();

            Loueur loueur = new Loueur();

            while (l.Read())
            {
                produit.IdProduit = Convert.ToInt32(l["idProduit"]);
                produit.NomProduit = Convert.ToString(l["nomProduit"]);
                produit.Description = Convert.ToString(l["description"]);
                loueur.IdLoueur = Convert.ToInt32(l["idLoueur"]);
                loueur.NomLoueur = Convert.ToString(l["nomLoueur"]);
                locationRec.IdLocation = Convert.ToInt32(l["idLocation"]);
                locationRec.StartDate = Convert.ToDateTime(l["startDate"]);
                locationRec.Produit = produit;
                locationRec.Loueur = loueur;
            }

            connection.Close();

            return locationRec;
        }

        /// <summary>
        /// fonction qui sélectionne tous les produits dans la base de donnée
        /// </summary>
        /// <returns>retourne une liste de produit</returns>
        public List<Produit> ToutLesProduit()
        {
            List<Produit> lstProduits = new List<Produit>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Produit";

            MySqlDataReader p = cmd.ExecuteReader();

            while (p.Read())
            {
                Produit produit = new Produit();
                produit.IdProduit = Convert.ToInt32(p["idProduit"]);
                produit.NomProduit = Convert.ToString(p["nomProduit"]);
                produit.Description = Convert.ToString(p["description"]);
                lstProduits.Add(produit);
            }

            connection.Close();

            return lstProduits;
        }

        /// <summary>
        /// fonction qui afficher l'historique d'un produit
        /// </summary>
        /// <param name="idProduit"></param>
        /// <returns>retourne une liste de location</returns>
        public List<Location> Historique(int idProduit)
        {
            List<Location> lstLocations = new List<Location>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "select * FROM Location INNER JOIN Loueur on idLoueur=fkLoueur INNER JOIN Produit on idProduit=fkproduit where idProduit = @idProduit order by idLocation desc";

            cmd.Parameters.AddWithValue("@idProduit", idProduit);

            MySqlDataReader l = cmd.ExecuteReader();

            while (l.Read())
            {
                Location location = new Location();
                Produit produit = new Produit();
                Loueur loueur = new Loueur();

                produit.IdProduit = Convert.ToInt32(l["idProduit"]);
                produit.NomProduit = Convert.ToString(l["nomProduit"]);
                produit.Description = Convert.ToString(l["description"]);
                loueur.IdLoueur = Convert.ToInt32(l["idLoueur"]);
                loueur.NomLoueur = Convert.ToString(l["nomLoueur"]);
                location.IdLocation = Convert.ToInt32(l["idLocation"]);
                location.StartDate = Convert.ToDateTime(l["startDate"]);
                location.Produit = produit;
                location.Loueur = loueur;
                lstLocations.Add(location);
            }

            connection.Close();

            return lstLocations;
        }

        /// <summary>
        /// fonction qui fait la recherche par mot-clés
        /// </summary>
        /// <param name="chercher"></param>
        /// <returns>retourne une liste de produit</returns>
        public List<Produit> RechercherMotCle(string chercher)
        {
            List<Produit> lstProduits = new List<Produit>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "select * FROM Produit where nomProduit like @chercher or description like @chercher or idProduit like @chercher order by idProduit";

            cmd.Parameters.AddWithValue("@chercher", "%" + chercher + "%");

            MySqlDataReader p = cmd.ExecuteReader();

            while (p.Read())
            {
                Produit produit = new Produit();
                produit.IdProduit = Convert.ToInt32(p["idProduit"]);
                produit.NomProduit = Convert.ToString(p["nomProduit"]);
                produit.Description = Convert.ToString(p["description"]);
                lstProduits.Add(produit);
            }

            connection.Close();

            return lstProduits;
        }
    }
}
