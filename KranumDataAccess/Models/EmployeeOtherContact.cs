using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EmployeeOtherContact
    {
        public string Uuid { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MobilePhone { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string RelationShip { get; set; }
        public string Family { get; set; }
        public string OtherPhone { get; set; }
        public string WorkPhone { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string EmergencyInstruction { get; set; }
        public string EmployeeUuid { get; set; }
        public string Status { get; set; }
        public string Emergency { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string AddressLine2 { get; set; }
    }
}
