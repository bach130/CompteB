using Compte_Bancaire.BusinessObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire.DAL
{
    class ClientDAOsingl
    {
        private ConnectionSinglton maConnexion1;
        private string provider = "localhost";

        private string dataBase = "banque";

        private string uid = "admin";

        private string mdp = "admin";
        private DataTable dt = null;
        private MySqlCommand cmd, cmd1;
        private MySqlDataReader reader;


        public ClientDAOsingl()
        {
            try
            {
                maConnexion1 = ConnectionSinglton.getInstance(provider, dataBase, uid, mdp);
                //maConnexion1.OpenConnection();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable afficherClient()
        {
            dt = new DataTable();
            try
            {

                maConnexion1.OpenConnection();
                String reqSelectClients = "SELECT * FROM client";
                cmd = maConnexion1.reqExec(reqSelectClients);
                reader = cmd.ExecuteReader();

                for (int i = 0; i <= reader.FieldCount - 1; i++)
                {
                    dt.Columns.Add(reader.GetName(i));
                }
                while (reader.Read())

                {
                    DataRow dr = dt.NewRow();

                    for (int i = 0; i <= reader.FieldCount - 1; i++)
                    {
                        dr[i] = reader.GetValue(i);

                    }

                    dt.Rows.Add(dr);

                }
                reader.Close();
                return dt;
            }
            catch (Exception exp)
            {

                throw (exp);
            }
            finally
            {
                maConnexion1.CloseConnection();
            }

        }


        public bool updateClient(Client cl)
        {
            try
            {
                maConnexion1.OpenConnection();
               // string reqUpdateCompte = "UPDATE client SET adresse='" + cl.Adresse + "' WHERE NUMCL=" + cl.NUMCL1 + "";
                cmd1 = maConnexion1.reqExec("UPDATE client SET adresse='" + cl.Adresse + "' WHERE NUMCL=" + cl.NUMCL1 + "");
                cmd1.ExecuteNonQuery();
                maConnexion1.CloseConnection();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
