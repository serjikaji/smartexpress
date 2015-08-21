using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class MyContextInitializer :DropCreateDatabaseAlways<SmartExpressModel>
    {
        protected override void Seed(SmartExpressModel context)
        {
            Client cl = new Client() { FirstName = "giorgi", LastName = "dolmazashvili", Address = "telavi", CompanyName = "IPO", Phone = "54654646" };
            context.Clients.Add(cl);
            context.SaveChanges();
        }
    }
}
