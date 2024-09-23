using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class MastProjectInfo
    {
        public int TxnId { get; set; }
        public int ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public int? ModefiedUserid { get; set; }
        public int? LastModefiedUserid { get; set; }
        public DateTime? ModefiedDate { get; set; }
        public DateTime? LastModefiedDate { get; set; }
    }
}
