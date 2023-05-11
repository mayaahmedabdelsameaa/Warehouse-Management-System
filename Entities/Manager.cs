using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Project.Entities
{
	public class Manager
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public virtual ICollection<Store> Stores { get; set; }
	}
}
