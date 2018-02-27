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
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Connection_mySQL()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "Stock_manager";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

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

            cmd.CommandText = "Select * from produit where idProduit =(@idProduit)";

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
        public Produit RetourtProduit(int idProduit)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "Select idProduit, nomProduit, description from produit where idProduit =(@idProduit)";

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

            cmd.CommandText = "INSERT INTO Produit (idProduit, nomProduit, description) VALUES (@idProduit, @nomProduit, @description)";

            cmd.Parameters.AddWithValue("@idProduit", produit.IdProduit);

            cmd.Parameters.AddWithValue("@nomProduit", produit.NomProduit);

            cmd.Parameters.AddWithValue("@description", produit.Description);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// fonction qui modifier le produit dans la base de donnée
        /// </summary>
        /// <param name="produit"></param>
        public void Modificationproduit (Produit produit)
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
        /// <returns></returns>
        public List<Location> LocationEnCours()
        {
            List<Location> lstlocations = new List<Location>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM location INNER JOIN loueur ON idLoueur = fkLoueur INNER JOIN Produit ON idProduit = fkProduit WHERE endDate IS NULL ORDER BY startDate";

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

            cmd.CommandText = " SELECT* FROM location INNER JOIN loueur ON idLoueur = fkLoueur INNER JOIN Produit ON idProduit = fkProduit WHERE endDate IS NULL and idProduit = @idProduit ORDER BY startDate";

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
        /// fonction qui ajout une nouvelle location dans la base de donnée
        /// </summary>
        /// <param name="produit"></param>
        /// <param name="location"></param>
        /// <param name="loueur"></param>
        public void NouvelleLocation(Produit produit, Location location, Loueur loueur)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Location (startDate,fkLoueur,fkProduit) VALUES (@startDate, @fkLoueur, @fkProduit";

            cmd.Parameters.AddWithValue("@startDate", location.StartDate);

            cmd.Parameters.AddWithValue("@fkLoueur", loueur.IdLoueur);

            cmd.Parameters.AddWithValue("@fkProduit", produit.IdProduit);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Produit> chargeProduitEnStock()
        {
            List<Produit> lstProduit = new List<Produit>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM produit WHERE idProduit NOT IN (SELECT fkproduit FROM location WHERE enddate IS NULL) ORDER BY idproduit";

            MySqlDataReader p = cmd.ExecuteReader();

            while (p.Read())
            {
                Produit produit = new Produit();
                produit.IdProduit = Convert.ToInt32(p[0]);
                produit.NomProduit = Convert.ToString(p[1]);
                produit.Description = Convert.ToString(p[2]);
                lstProduit.Add(produit);
            }

            connection.Close();

            return lstProduit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Loueur> chargeLoueur()
        {
            List<Loueur> lstLoueur = new List<Loueur>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "select * from loueur order by nomLoueur";

            MySqlDataReader l = cmd.ExecuteReader();
            
            while (l.Read())
            {
                Loueur loueur = new Loueur();
                loueur.IdLoueur = Convert.ToInt32(l[0]);
                loueur.NomLoueur = Convert.ToString(l[1]);
                lstLoueur.Add(loueur);
            }

            connection.Close();

            return lstLoueur;
        }
    }
}
