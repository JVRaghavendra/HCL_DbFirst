using System;
using System.Collections.Generic;

namespace HCL_DbFirst.BusinessEntities
{
    public partial class InvestSignup
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string MiddleName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? MailId { get; set; }
        public string? HintQuest { get; set; }
        public string? HintAnswer { get; set; }
        public string? Age { get; set; }
        public string? Occupation { get; set; }
        public string? Dob { get; set; }
        public string? Uid { get; set; }
        public string? Password { get; set; }
        public string? Pin { get; set; }
        public string? Offphone { get; set; }
        public string? Resphone { get; set; }
        public string? Add1 { get; set; }
        public string? Add2 { get; set; }
        public string? Add3 { get; set; }
    }
}
