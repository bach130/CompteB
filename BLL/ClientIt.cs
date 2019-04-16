using Compte_Bancaire.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte_Bancaire.BLL
{
    interface ClientIt
    {
        string saisi(TextBox tb, TextBox tb1, TextBox tb2);
        void afficherclient(Client c);
        void ajouter(DataGridView dg, TextBox tb, TextBox tb1, TextBox tb2);
        void afficherDataGridView(string table, DataGridView dg);
        void supprimer(string table, DataGridView dg, TextBox tb);
    }
}
