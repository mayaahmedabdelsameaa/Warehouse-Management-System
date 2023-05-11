using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Code { get; set; }
		public List<string> UnitsOfMeasure { get; set; }
		public virtual Store Store { get; set; }
		public virtual ImportPermit ImportPermit { get; set; }
        public virtual ICollection<ImportPermitDetails> ImportPermitDetails { get; set; }
        public virtual ICollection<ExchangePermitDetails> ExchangePermitDetails { get; set; }


    }
}
