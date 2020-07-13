using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Response
{
    public class Customer_Response
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime CreateAt { get; set; }
        public bool State { get; set; }
        public string FullName => $"{Name} {LastName}";
        public virtual ICollection<SalesInvoce_Response> SalesInvoces { get; set; }
    }
}
