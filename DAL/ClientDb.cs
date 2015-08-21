using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClientDb : BaseDb
    {
        public IEnumerable<Client> GetAll()
        {
            return db.Clients.ToList();
        }

        public Client GetById(int id)
        {
            return db.Clients.Find(id);
        }

        public void Insert(Client client)
        {
            db.Clients.Add(client);
            Save();
        }

        public void Delete(int id)
        {
            Client client = db.Clients.Find(id);
            db.Clients.Remove(client);
            Save();
        }

        public void Update(Client client)
        {
            db.Entry(client).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
