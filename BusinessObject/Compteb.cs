using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire.BusinessObject
{
    class Compteb
    {
        private int NUMC;
        private int NUMCL;
        private double solde;
        private Client proprio;
        private double decouv = 0;
        // private Client unClient;

        public Compteb(int NUMC,int NUMCL, double solde, double decouv, Client c)
        {
            this.NUMC = NUMC;
            this.NUMCL = NUMCL;
            this.solde = solde;
            this.decouv = decouv;
            proprio = c;
            this.proprio.ajouterCompte(this);
        }

        public Compteb(int NUMC, Client c)
        {
            this.NUMC = NUMC;
            solde = 0;
            proprio = c;
            this.proprio.ajouterCompte(this);

        }

        public Compteb()
        {
        }


        public int NUMC1
        {
            get
            {
                return NUMC;
            }

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

        /*  public double SOLDE1
          {
              get
              {
                  return solde;
              }

              set
              {
                  solde = value;
              }
          }*/

        /// <summary>
        /// ///////////////////
        /// </summary>
        internal Client Proprio
        {
            get
            {
                return proprio;
            }
        }
        /// <summary>
        /// //////////////////////////////////////
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool setDecouv(double value)

        {

            bool res = false;

            if (this.solde > -value)
            {
                decouv = value;

                res = true;
            }


            return (res);

        }
        /// <summary>
        /// //////////////////////
        /// </summary>
        public string Description
        {
            get { return NUMC + " " + proprio + " " + " solde: " + solde + " Euros" + " - decouvert: " + Decouv + " Euros"; }
        }

        public double Decouv
        {
            get
            {
                return decouv;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }

            set
            {
                solde = value;
            }
        }

        /// <summary>
        /// /////////////////////
        /// </summary>
        /// <param name="mont"></param>
        public bool crediter(double mont)
        {
            this.solde = this.solde + mont;
            return true;
        }
        /// <summary>
        /// ////////////////
        /// </summary>
        /// <param name="mont"></param>
        /// <returns></returns>
        public bool débiter(double mont)
        {
            if (solde - mont < -decouv)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                return true;
            }
            //////////////////////////////////
        }
    }
}
