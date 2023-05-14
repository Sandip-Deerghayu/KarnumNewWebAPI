using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class BusinessContactMappingFbPost
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string FbPostText { get; set; }
        public long? TimeStamp { get; set; }
        public string PostUrl { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public long? LinkLabel { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? PostDate { get; set; }
    }
}
