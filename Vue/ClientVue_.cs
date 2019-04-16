using Compte_Bancaire.BLL;
using Compte_Bancaire.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte_Bancaire.Vue
{
    public partial class ClientVue_ : Form
    {
        private ClientMangersing clientM;
        private ComptebManager comptebM;
        private Form ComptebVue = null;
        public ClientVue_(Form Cvue)
        {
            ComptebVue = Cvue;
            InitializeComponent();
            clientM = new ClientMangersing();
            comptebM = new ComptebManager();
        }
    
        
        
          

        

        private void btnVueClientModéfier_Click(object sender, EventArgs e)
        {
            int NUMCL = Convert.ToInt16(tbClientVue_ID.Text);
            string NOM = tbClientVue_Nom.Text;
            string PRENOM = tbClientVue_PRENOM.Text;
            string ADRESSE = tbClientVue_ADRESSE.Text;
            Client unClient = new Client(NUMCL, NOM, PRENOM, ADRESSE);

            DataGridView dg = (DataGridView)ComptebVue.Controls["dGVWCompte"];
            
            try
            {
                if (clientM.updateClient(unClient))
                {
                    dg.DataSource = comptebM.affihageCompte();
                   /* tbClientVue_ADRESSE.Enabled = false;
                    btnVueClientModéfier.Enabled = false;*/
                    MessageBox.Show(" mise à jour réussi!");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
