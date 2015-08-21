using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientBs
    {
        private ClientDb objDb;

        public ClientBs()
        {
            objDb = new ClientDb();
        }

        public IEnumerable<Client> GetAll()
        {
            return objDb.GetAll();
        }

        public Client GetById(int id)
        {
            return objDb.GetById(id);
        }

        public void Insert(Client client)
        {
            objDb.Insert(client);
        }

        public void Delete(int id)
        {
            objDb.Delete(id);
        }

        public void Update(Client client)
        {
            objDb.Update(client);
        }
    }
}
