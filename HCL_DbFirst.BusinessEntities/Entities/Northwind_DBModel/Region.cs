using HCL_DbFirst.BusinessEntities;
using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; } = null!;

        public virtual ICollection<Territory> Territories { get; set; }
    }
}
