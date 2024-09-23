using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{ 
    public partial class KaFund
    {
        public KaFund()
        {
            KaFolios = new HashSet<KaFolio>();
        }

        public int Id { get; set; }
        public string? FundName { get; set; }
        public string? FundValue { get; set; }

        public virtual ICollection<KaFolio> KaFolios { get; set; }
    }
}
