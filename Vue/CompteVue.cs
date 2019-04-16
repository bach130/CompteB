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
    public partial class CompteVue : Form
    {
        private ComptebManager cm;
        public CompteVue()
        {
            InitializeComponent();
            cm = new ComptebManager();
        }
        
        
        private void setVisible()
        {
            tbValeurs.Visible = true;
            lblOpération.Visible = true;
            btnOperation.Visible = true;
        }
        private void créditerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setVisible();
            lblOpération.Text = "Montant à créditer";
            btnOperation.Text = "Créditer";

        }

        private void débiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setVisible();
            lblOpération.Text = "Montant à débiter";
            btnOperation.Text = "Débiter";
        }

        private void découvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setVisible();
            lblOpération.Text = "Montant de découvert";
            btnOperation.Text = "Découvert";
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*setVisible();
            ClientVue_   Client = new ClientVue_(this);
            

            Client.tbClientVue_ID.Text = dGVWCompte.CurrentRow.Cells[1].Value.ToString();
            Client.tbClientVue_ID.Enabled = false;
            Client.tbClientVue_Nom.Text = dGVWCompte.CurrentRow.Cells[2].Value.ToString();
            Client.tbClientVue_Nom.Enabled = false;
            Client.tbClientVue_PRENOM.Text = dGVWCompte.CurrentRow.Cells[3].Value.ToString();
            Client.tbClientVue_PRENOM.Enabled = false;
            Client.tbClientVue_ADRESSE.Text = dGVWCompte.CurrentRow.Cells[4].Value.ToString();
            Client.ShowDialog();*/
            ///////////////////////////
           ClientVue Clientbis = new ClientVue(this);
            Clientbis.ShowDialog();

        }
        private void gridViewLoad()
        {

            dGVWCompte.DataSource = cm.affihageCompte();
            //dgv1.CurrentRow.Selected = true;


        }
        private void CompteVue_Load(object sender, EventArgs e)
        {
            gridViewLoad();
            tbValeurs.Visible = false;
            lblOpération.Visible = false;
            btnOperation.Visible = false;
        }
        private void dGVWCompte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            int numcl = Convert.ToInt32(dGVWCompte.CurrentRow.Cells[1].Value);
            int numc = Convert.ToInt32(dGVWCompte.CurrentRow.Cells[0].Value);
            double solde = Convert.ToDouble(dGVWCompte.CurrentRow.Cells[5].Value);
            double decouv = Convert.ToDouble(dGVWCompte.CurrentRow.Cells[6].Value);
            
            string nom = dGVWCompte.CurrentRow.Cells[2].Value.ToString();
            string prenom = dGVWCompte.CurrentRow.Cells[3].Value.ToString();
            string adr = dGVWCompte.CurrentRow.Cells[4].Value.ToString();
            Client unClient = new Client(numcl, nom, prenom, adr);
            Compteb cb = new Compteb(numc,numcl, solde, decouv, unClient);


            try
            {
                if (btnOperation.Text == "Créditer")
                {
                    double MontantCrid = Convert.ToDouble(tbValeurs.Text);
                    if (cb.crediter(MontantCrid))
                    //MessageBox.Show(Convert.ToString(cpt.Solde)+" "+Convert.ToString(cpt.Numero) );
                    {
                        cm.updateCompte(cb);
                        gridViewLoad();
                        MessageBox.Show("Votre compte est bien crédité!");
                    }
                    else
                    {
                        MessageBox.Show("Erreur!");
                    }
                }

                if (btnOperation.Text == "Débiter")
                {
                    double MontantDeb = Convert.ToDouble(tbValeurs.Text);

                    if (cb.débiter(MontantDeb) == false)
                    {
                        MessageBox.Show("Prélèvement non autorisé! Votre découvert: " + cb.Decouv + " Votre solde: " + cb.Solde);
                    }
                    else
                    {
                        cm.updateCompte(cb);
                        gridViewLoad();
                        MessageBox.Show("Votre compte est bien débité!");
                    }
                }

                if (btnOperation.Text == "Découvert")
                {
                    double Montantdec = Convert.ToDouble(tbValeurs.Text);
                    if (!cb.setDecouv(Montantdec))
                    {
                        MessageBox.Show("Votre sold ne vous autorise pas pas un découvert plus haut, votre sole est de " + -cb.Solde + " Euros");
                    }
                    else
                    {
                        cb.setDecouv(Convert.ToDouble(tbValeurs.Text));
                        cm.updateCompte(cb);
                        //cm.updateComptedecouv(cb);
                        gridViewLoad();
                    }
                }
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (NullReferenceException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
