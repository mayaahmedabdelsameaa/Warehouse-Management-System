using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Customer
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Telephone { get; set; }
		public string Email { get; set; }
		public string Fax { get; set; }
		public string Mobile { get; set; }
		public string website { get; set; }
        public virtual ICollection<Store> Stores { get; set; }

    }
}
