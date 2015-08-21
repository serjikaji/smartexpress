using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Client
    {
        [Key]
        public string ContractNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string IDNumber { get; set; } //saidentifikacio nomeri
        public string Role { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }

        public Client()
        {
            Invoice = new List<Invoice>();
        }


    }
}
