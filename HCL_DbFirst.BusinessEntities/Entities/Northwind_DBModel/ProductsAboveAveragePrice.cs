using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
