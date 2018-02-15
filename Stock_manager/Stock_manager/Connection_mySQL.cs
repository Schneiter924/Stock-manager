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

            cmd.CommandText = "Select idProduit, nom, description from produit where idProduit =(@idProduit)";

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

        public void AjoutLoueur (string nom)
        {
            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Loueur (nomLoueur) VALUES (@nomLoueur)";

            cmd.Parameters.AddWithValue("@nomLoueur", nom);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        
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

        public List<Produit> chargeProduit()
        {
            List<Produit> lstProduit = new List<Produit>();

            connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "select * from produit order by nomLoueur";

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
