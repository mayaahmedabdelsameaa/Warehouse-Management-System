using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class ImportPermit
	{
		public int Id { get; set; }

		public int StoreId { get; set; }

		public string PermitNumber { get; set; }

		public DateTime PermitDate { get; set; }

		public string Varieties { get; set; }

		public string Quantity { get; set; }

		public int SupplierId { get; set; }

		public Supplier Supplier { get; set; }

		public DateTime ProductionDate { get; set; }

		public DateTime ExpirationDate { get; set; }

		public Store Store { get; set; }

        public virtual ICollection<ImportPermitDetails> ImportPermitDetails { get; set; }
    }
}
