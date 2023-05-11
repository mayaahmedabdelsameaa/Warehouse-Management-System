using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class ExchangePermit
	{
        public int ExchangePermitId { get; set; }
        public int StoreId { get; set; }
        public string PermitNumber { get; set; }
        public DateTime PermitDate { get; set; }
        public int SupplierId { get; set; }

        public virtual Store Store { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ExchangePermitDetails> ExchangePermitDetails { get; set; }

    }
}
