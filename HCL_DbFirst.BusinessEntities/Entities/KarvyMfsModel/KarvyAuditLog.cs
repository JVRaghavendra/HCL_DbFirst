using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class KarvyAuditLog
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
