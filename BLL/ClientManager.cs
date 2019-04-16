using Compte_Bancaire.BusinessObject;
using Compte_Bancaire.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte_Bancaire.BLL
{
    class ClientManagersing
    {

       
        ClientDAO CDAO = new ClientDAO();
        Connexion conn = new Connexion();
       
        public void afficherDataGridView(string table, DataGridView dg)
        {
            CDAO.afficherDataGridView(table, dg);
        }

        public string saisi(TextBox tb, TextBox tb1, TextBox tb2)
        {
            Client cl = new Client();
            MessageBox.Show("les références de ce client sont");
            cl.NOM1 = tb.Text;
             cl.PRENOM1 = tb1.Text;
               cl.Adresse = tb2.Text;
            
            return cl.NOM1 + " _" + cl.PRENOM1 + " _" + cl.Adresse;
            
        }
        // public void ajouter(DataGridView dg, TextBox tb, TextBox tb1, TextBox tb2)
        public void ajouter(string table,DataGridView dg, Client c)
        {
            //CDAO.ajouter(dg, tb, tb1, tb2);
            CDAO.ajouter(table,dg, c);
            MessageBox.Show("bien ajouter");
        }
        //public void supprimer(string table, DataGridView dg, TextBox tb)
        public void supprimer(string table, DataGridView dg,Client c)
        {
            //CDAO.supprimer(table, dg, tb);
            CDAO.supprimer(table, dg, c);
            MessageBox.Show("suppression réussi");
        }
       // public void modefierClient(TextBox tb, TextBox tb1, TextBox tb2, string table, DataGridView dg)
            public void modefierClient(Client cl, string table, DataGridView dg)
        {
           // CDAO.modefierClient(tb, tb1, tb2, table, dg);
            CDAO.modefierClient(cl, table, dg);
            MessageBox.Show("modéfication réussi");


        }
       /* public void rechercher(Client c,string table)
        {

            CDAO.rechercher(c,table);
        }*/

        public void rechercher(Client c, string table)
        {


            if (CDAO.Exist(c, table) == false)
            {
                MessageBox.Show("employe introuvable");
            }
            else
            {

                CDAO.rechercher(c, table);

            }
        }
    }
}
