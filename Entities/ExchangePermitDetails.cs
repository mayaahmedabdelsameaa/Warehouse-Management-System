using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class ExchangePermitDetails
    {
        public int ExchangePermitDetailsId { get; set; }
        public decimal Quantity { get; set; }

        public int ExchangePermitId { get; set; }
        public virtual ExchangePermit ExchangePermit { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
