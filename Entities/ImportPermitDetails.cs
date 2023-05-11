using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class ImportPermitDetails
    {
        public int ImportPermitDetailsId { get; set; }
        public decimal Quantity { get; set; }

        public int ImportPermitId { get; set; }
        public virtual ImportPermit ImportPermit { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
