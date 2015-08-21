using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InvoiceDb :BaseDb
    {
        public IEnumerable<Invoice> GetAll()
        {
            return db.Invoices.ToList();
        }

        public Invoice GetById(int id)
        {
            return db.Invoices.Find(id);
        }

        public void Insert(Invoice invoice)
        {
            db.Invoices.Add(invoice);
            Save();
        }

        public void Delete(int id)
        {
            Invoice invoice = db.Invoices.Find(id);
            db.Invoices.Remove(invoice);
            Save();
        }

        public void Update(Invoice invoice)
        {
            db.Entry(invoice).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
