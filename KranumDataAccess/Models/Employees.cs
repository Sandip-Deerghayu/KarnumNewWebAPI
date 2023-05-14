using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Employees
    {
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Sex { get; set; }
        public string Dob { get; set; }
        public string DateOfJoining { get; set; }
        public string Designation { get; set; }
        public int ClientLocationId { get; set; }
        public string Address { get; set; }
        public string StateName { get; set; }
        public string CityId { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string EmergencyContactNo { get; set; }
        public string EmergencyContactPerson { get; set; }
        public decimal? Salary { get; set; }
        public string ImageUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Status { get; set; }
        public string Password { get; set; }
        public string Identifier { get; set; }
        public string DeviceRegistrationId { get; set; }
        public string AddressLine { get; set; }
        public string Zip { get; set; }
        public string Credentials { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? VeraPalStatus { get; set; }
        public string TimeZone { get; set; }
        public string IndependentContractor { get; set; }
        public string PasswordSalt { get; set; }
        public string Uuid { get; set; }
        public string AccessType { get; set; }
        public string Country { get; set; }
        public string InactiveReason { get; set; }
        public string DeviceType { get; set; }
        public string IsEmailReceived { get; set; }
        public int? AgencyLocationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
