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
        /// <returns></returns>
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

        
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }
    }
}
