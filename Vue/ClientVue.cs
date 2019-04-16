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
    public partial class ClientVue : Form
    {
        private ClientMangersing clientM;
        private ComptebManager comptebM;
        private Form ComptebVue = null;
        
        public ClientVue(Form Cvue)
        {
            ComptebVue = Cvue;
            InitializeComponent();
            clientM = new ClientMangersing();
            comptebM = new ComptebManager();

        }
       private void init(Client client)
        {
            int NUMCL = Convert.ToInt16(tbID.Text);
            string NOM = tbNOM.Text;
            string PRENOM = tbPRENOM.Text;
            string ADRESSE = tbADRESSE.Text;
             client = new Client(NUMCL, NOM, PRENOM, ADRESSE);
        }
        ClientManagersing cm = new ClientManagersing();
       
        private void btnAFFICHER_Click(object sender, EventArgs e)
        {
            dGVWClient.Rows.Clear();
            //listBox1.Items.Add(tbtest.Text);
            // dGVWClient.Rows.Add(cm.saisi(tbNom, tbPrenom, tbAdresse));
            cm.afficherDataGridView("client", dGVWClient);
            //listBox1.Items.Add(cm.saisi(tbNom, tbPrenom, tbAdresse));

        }

        private void btnMODIFIER_Click(object sender, EventArgs e)
        {
            int NUMCL = Convert.ToInt16(tbID.Text);
            string NOM = tbNOM.Text;
            string PRENOM = tbPRENOM.Text;
            string ADRESSE = tbADRESSE.Text;
            Client client = new Client(NUMCL, NOM, PRENOM, ADRESSE);
            // cm.modefierClient(tbNOM,tbPRENOM, tbADRESSE, "client", dGVWClient);
            cm.modefierClient(client, "client", dGVWClient);

            //////////////////////////////
            tbID.Text = dGVWClient.CurrentRow.Cells[0].Value.ToString();
            tbID.Enabled = false;
            tbNOM.Text = dGVWClient.CurrentRow.Cells[1].Value.ToString();
            tbNOM.Enabled = false;
            tbPRENOM.Text = dGVWClient.CurrentRow.Cells[2].Value.ToString();
            tbPRENOM.Enabled = false;
            tbADRESSE.Text = dGVWClient.CurrentRow.Cells[3].Value.ToString();
            tbPRENOM.Enabled = false;
            ///////////////////////////////////////////////////////
            DataGridView dg = (DataGridView)ComptebVue.Controls["dGVWCompte"];
            try
            {
                if (clientM.updateClient(client))
                {
                    dg.DataSource = comptebM.affihageCompte();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSUPPRIMER_Click(object sender, EventArgs e)
        {
            int NUMCL = Convert.ToInt16(tbID.Text);
            string NOM = tbNOM.Text;
            string PRENOM = tbPRENOM.Text;
            string ADRESSE = tbADRESSE.Text;
            Client client = new Client(NUMCL, NOM, PRENOM, ADRESSE);
            //dGVWClient.Rows.Clear();
            //cm.supprimer("client", dGVWClient, tbNOM);
            cm.supprimer("client", dGVWClient,client);
        }

        private void btnAJOUTER_Click(object sender, EventArgs e)
        {
            int NUMCL = Convert.ToInt16(tbID.Text);
            string NOM = tbNOM.Text;
            string PRENOM = tbPRENOM.Text;
            string ADRESSE = tbADRESSE.Text;
            Client client = new Client(NUMCL, NOM, PRENOM, ADRESSE);
            //dGVWClient.Rows.Clear();
            //cm.ajouter(dGVWClient, tbNOM, tbPRENOM, tbADRESSE);
            cm.ajouter("client",dGVWClient, client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NUMCL = 0;//Convert.ToInt16(tbID.Text);
            string NOM = tbNOM.Text;
            string PRENOM = tbPRENOM.Text;
            string ADRESSE = tbADRESSE.Text;
            Client client = new Client(NUMCL, NOM, PRENOM, ADRESSE);
            
            if (tbNOM.Text == "")
            {
                MessageBox.Show("entrez le nom s'il vous plait");
            }
            else
            {

                cm.rechercher(client, "client");
            }
            
        }
    }
}
