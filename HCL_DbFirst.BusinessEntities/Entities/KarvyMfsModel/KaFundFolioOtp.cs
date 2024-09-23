using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class KaFundFolioOtp
    {
        public int Id { get; set; }
        public string Fund { get; set; } = null!;
        public string Folio { get; set; } = null!;
        public string Otp { get; set; } = null!;
        public string? Hostname { get; set; }
        public string? IpAddress { get; set; }
        public string? Osversion { get; set; }
        public string? Sevicepack1 { get; set; }
        public string? Currentdate { get; set; }
        public string? User { get; set; }
    }
}
