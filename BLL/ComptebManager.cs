using Compte_Bancaire.BusinessObject;
using Compte_Bancaire.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire.BLL
{
    class ComptebManager
    {
        private CompteDAOsingl C_DAO;
        public ComptebManager()
        {
            C_DAO = new CompteDAOsingl();
        }
        public DataTable affihageCompte()
        {
            return C_DAO.affihageCompte();
        }

        public void updateCompte(Compteb c)
        {
            C_DAO.updateCompte(c);

        }
        public void updateComptedecouv(Compteb c)
        {
            C_DAO.updateComptedecouv(c);
        }
    }
}
