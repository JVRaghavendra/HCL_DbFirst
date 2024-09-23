using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class AltFileUploadDatum
    {
        public int Id { get; set; }
        public string? Fund { get; set; }
        public string? Folio { get; set; }
        public string? CurrentDate { get; set; }
        public byte[]? FileData { get; set; }
        public string? DocumentType { get; set; }
        public string? Frequency { get; set; }
    }
}
