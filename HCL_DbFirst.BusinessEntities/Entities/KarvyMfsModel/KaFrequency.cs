using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class KaFrequency
    {
        public int AltDocumentno { get; set; }
        public int AltFrequencyno { get; set; }
        public string AltFrequency { get; set; } = null!;
    }
}
