using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Context:DbContext
	{
		public Context() : base("Data Source=.;Initial Catalog=EntityProject;Integrated Security=True;")
		{}
		public DbSet<Manager> Employees { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Store> Store { get; set; }
		public DbSet<ExchangePermit> ExchangePermits { get; set; }
		public DbSet<ExchangePermitDetails> ExchangePermitDetails { get; set; }
		public DbSet<ImportPermit> ImportPermits { get; set; }
		public DbSet<ImportPermitDetails> ImportPermitDetails { get; set; }
		public DbSet<TransferProduct> TransferProducts { get; set; }
		
	}
}
