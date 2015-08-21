using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InvoiceBs
    {
        private InvoiceDb objDb;

        public InvoiceBs()
        {
            objDb = new InvoiceDb();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return objDb.GetAll();
        }

        public Invoice GetById(int id)
        {
            return objDb.GetById(id);
        }

        public void Insert(Invoice invoice)
        {
            objDb.Insert(invoice);
        }

        public void Delete(int id)
        {
            objDb.Delete(id);
        }

        public void Update(Invoice invoice)
        {
            objDb.Update(invoice);
        }

    }
}
