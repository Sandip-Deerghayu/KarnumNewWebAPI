using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class RelyFyAgencyInvoicePayment
    {
        public int Id { get; set; }
        public int? RelyFyAgencyInvoiceBillingId { get; set; }
        public string RefrenceNumber { get; set; }
        public string OrderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Json { get; set; }
        public string ResponseJson { get; set; }
        public string Status { get; set; }
    }
}
