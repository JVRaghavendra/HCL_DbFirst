using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
