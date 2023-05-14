using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ImportBusinessFbPosts
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string FbEmail { get; set; }
        public string FbUrl { get; set; }
        public string FbStatusCode { get; set; }
        public string FanCount { get; set; }
        public string FbAddress { get; set; }
        public string FbPhone { get; set; }
        public string LastPostTimestamp { get; set; }
        public string FbPosts { get; set; }
        public DateTime? ImportedDate { get; set; }
        public string OldLastFbpost { get; set; }
        public string OldFblink { get; set; }
        public string Uuid { get; set; }
    }
}
