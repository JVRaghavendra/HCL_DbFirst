using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class KaFolio
    {
        public int Id { get; set; }
        public string? FolioName { get; set; }
        public string? FolioValue { get; set; }
        public int FundBasedFolio { get; set; }

        public virtual KaFund FundBasedFolioNavigation { get; set; } = null!;
    }
}
