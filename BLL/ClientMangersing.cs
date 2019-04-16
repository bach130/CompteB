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
    class ClientMangersing
    {
        private ClientDAOsingl CLDAO;
        public ClientMangersing()
        {
            CLDAO = new ClientDAOsingl();
        }
        public DataTable afficherClient()
        {
            return CLDAO.afficherClient();
        }

        public bool updateClient(Client client)
        {
            if (CLDAO.updateClient(client))
                return true;
            return false;
        }
    }
}
