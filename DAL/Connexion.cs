using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire.DAL
{
    class Connexion
    {
        public MySqlConnection conn = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataReader dr;
        public DataTable dt = new DataTable();

        public void connecter()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = "Initial Catalog=compte;Data Source=localhost;Username=admin;Password=admin";
                conn.Open();
            }

        }
        public void deconnecter()
        {
            if (conn.State == ConnectionState.Open)
            {

                conn.Close();
            }
        }
    }
}
