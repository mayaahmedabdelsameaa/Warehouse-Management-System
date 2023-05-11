using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Store
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public virtual Manager ResponsiblePerson { get; set; }
		public virtual ICollection<Product> Products { get; set; }
		public virtual ICollection<Customer> Customers { get; set; }
		public virtual ICollection<Supplier> Suppliers { get; set; }
		public virtual ICollection<ImportPermit> ImportPermits { get; set; }

	}
}
