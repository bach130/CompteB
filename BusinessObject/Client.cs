using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire.BusinessObject
{
    class Client
    {
        private int NUMCL;
        private string nom;
        private string prenom;
        private string adresse;

        private List<Compteb> comptes = new List<Compteb>();

        public Client()
        {

        }

        public Client(int id, string nom, string prenom, string Adresse)
        {
            NUMCL = id;
            this.nom = nom;
            this.prenom = prenom;
            this.Adresse = Adresse;
        }

        public int NUMCL1
        {
            get
            {
                return NUMCL;
            }

            set
            {
                NUMCL = value;
            }
        }

        public string NOM1
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string PRENOM1
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        /*  public string ADRESSE1
          {
              get
              {
                  return ADRESSE;
              }

              set
              {
                  ADRESSE = value;
              }
          }*/
        /* public string getAdresse()
         {
             return this.adresse;
         }
         public void setAdresse(string adresse)
         {
             this.adresse = adresse;
         }*/
        public void ajouterCompte(Compteb c)
        {

            this.comptes.Add(c);
        }

    }
}
