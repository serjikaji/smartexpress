namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SmartExpressModel : DbContext
    {
       
        public SmartExpressModel()
            : base("name=SmartExpressModel")
        {
        }

       
        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

    }

}