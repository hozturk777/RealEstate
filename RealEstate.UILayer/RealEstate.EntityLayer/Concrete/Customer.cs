using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string CustomerSurPhone { get; set; }
        public string CustomerMail { get; set; }
    }
}
