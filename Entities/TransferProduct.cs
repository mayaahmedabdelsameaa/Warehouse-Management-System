using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class TransferProduct
    {
        public int TransferProductId { get; set; }
        public decimal Quantity { get; set; }

        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        //public int FromStoreId { get; set; }
        public virtual Store FromStore { get; set; }

        //public int ToStoreId { get; set; }
        public virtual Store ToStore { get; set; }

        //public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        //public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
