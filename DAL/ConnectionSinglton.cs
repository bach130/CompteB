using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire.DAL
{
    class ConnectionSinglton
    {
        private static ConnectionSinglton connection = null;

        private MySqlConnection oleCn;

        private static readonly object mylock = new object();

        private string connString;


        private ConnectionSinglton(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    oleCn = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }



        }



        /**
         * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
         */
        public static ConnectionSinglton getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {


                    if (null == connection)
                    { // Premier appel
                        connection = new ConnectionSinglton(unProvider, uneDataBase, unUid, unMdp);

                    }

                }
                catch (Exception emp)
                {
                    throw (emp);


                }
                return connection;

            }
        }





        /**
         * Ouverture de la connexion
         */
        public void OpenConnection()
        {
            try
            {
                oleCn.Open();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        /**
         * Fermeture de la connexion
         */
        public void CloseConnection()
        {
            oleCn.Close();
        }

        /**
         * Exécutiuon d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.oleCn);
            return (mysqlCom);
        }
    }
}
