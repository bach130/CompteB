using Compte_Bancaire.BusinessObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte_Bancaire.DAL
{
    class CompteDAOsingl
    {
        private ConnectionSinglton maConnexion;
        private string provider = "localhost";
        private string dataBase = "compte";
        private string user = "admin";
        private string mdp = "admin";
        private DataTable dt;
        private MySqlCommand cmd, cmd1;
        private MySqlDataReader reader;
        //private MySqlDataAdapter adapter;

        public CompteDAOsingl()
        {
            try
            {
                maConnexion = ConnectionSinglton.getInstance(provider, dataBase, user, mdp);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable affihageCompte()
        {
            dt = new DataTable();
            try
            {

                maConnexion.OpenConnection();
                cmd = maConnexion.reqExec("SELECT cb.NUMC, cl.NUMCL, cl.nom, cl.prenom, cl.adresse, cb.solde, cb.decouv FROM compteb cb JOIN client cl ON cl.NUMCL = cb.NUMCL");
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
                maConnexion.CloseConnection();
            }

        }


        public void updateCompte(Compteb c)
        {
            try
            {
                maConnexion.OpenConnection();
                cmd1 = maConnexion.reqExec("UPDATE compteb SET solde=" + c.Solde + ", decouv=" + c.Decouv + " WHERE NUMC=" + c.NUMC1 + "");
                cmd1.ExecuteNonQuery();
                maConnexion.CloseConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void updateComptedecouv(Compteb c)
        {
            try
            {
                maConnexion.OpenConnection();
                cmd1 = maConnexion.reqExec("UPDATE compteb SET decouv=" + c.Decouv + " WHERE NUMC=" + c.NUMC1 + "");
                cmd1.ExecuteNonQuery();
                maConnexion.CloseConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


