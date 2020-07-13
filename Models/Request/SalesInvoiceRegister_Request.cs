using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    public class SalesInvoiceRegister_Request
    {
        public SalesInvoce_Request SalesInvoice { get; set; }
        public List<SalesInvoceDetail_Request> SalesInvoceDetails { get; set; }
    }
}
