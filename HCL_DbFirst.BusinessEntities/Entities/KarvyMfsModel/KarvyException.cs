using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class KarvyException
    {
        public int Id { get; set; }
        public string? ErrorCode { get; set; }
        public string? ErrorMsg { get; set; }
        public string? ErrorLine { get; set; }
        public string? ErrorProc { get; set; }
        public string? ErrorState { get; set; }
        public string? Errorseverity { get; set; }
        public string? Dbname { get; set; }
        public string? ServerName { get; set; }
        public DateTime? ErrorDate { get; set; }
    }
}
