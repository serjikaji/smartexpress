using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Invoice
    {
        [Key]
        public string InvoiceNumber { get; set; }
        public string RecieveDate { get; set; }
        public string PackageType { get; set; }
        public string DeliveryType { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public double UnitPrice { get; set; }
        public string Direction { get; set; }
        public string Payer { get; set; }
        public string PayForm { get; set; }
        public string DeliveryDate { get; set; }

        public string ContractNumber { get; set; }
        public Client Client { get; set; }

        public string RecieverFirstName { get; set; }
        public string RecieverLastName { get; set; }
        public string RecieverTelNumber { get; set; }
        public string RecieverAddress { get; set; }
        public string RecieverType { get; set; }


    }
}
