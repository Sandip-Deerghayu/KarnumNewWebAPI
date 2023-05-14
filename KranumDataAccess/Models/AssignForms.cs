using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AssignForms
    {
        public int AssignId { get; set; }
        public string FormName { get; set; }
        public string Services { get; set; }
        public string DeliveryOfServices { get; set; }
        public string Site { get; set; }
        public string Price { get; set; }
        public string Payment { get; set; }
        public string Material { get; set; }
        public string Warranty { get; set; }
        public string Limitation { get; set; }
        public string TermAndTermination { get; set; }
        public string RelationshipOfParties { get; set; }
        public string Confidentiality { get; set; }
        public string Notices { get; set; }
        public string Miscellaneous { get; set; }
        public string Amendments { get; set; }
        public string AdditionalClauses { get; set; }
        public int ClientLocationId { get; set; }
        public string AssignedBy { get; set; }
        public DateTime AssignedOn { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public DateTime? AgreementDate { get; set; }
        public string SignedByB { get; set; }
        public string BehalfOfB { get; set; }
        public string SignedByP { get; set; }
        public string BehalfOfP { get; set; }
        public string Signature { get; set; }
    }
}
