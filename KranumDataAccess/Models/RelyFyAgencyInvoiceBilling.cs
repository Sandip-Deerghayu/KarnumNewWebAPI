using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class RelyFyAgencyInvoiceBilling
    {
        public int Id { get; set; }
        public int? ClientLocationId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string InvoiceNumber { get; set; }
        public int? InvoiceUniqueId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? ActiveClient { get; set; }
        public int? InActiveClient { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? TotalClient { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public decimal? BaseRate { get; set; }
        public int? BaseClient { get; set; }
        public int? ExtraClient { get; set; }
        public decimal? ExtraClientRate { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? FinalTotalAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? ActualDayAmount { get; set; }
        public decimal? ProratedCredit { get; set; }
        public int? TotalActualDay { get; set; }
    }
}
