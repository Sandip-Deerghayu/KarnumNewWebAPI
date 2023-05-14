using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class CreateShareEventRequestViewResource
    {
        public string EventUUID { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string EmailId { get; set; }
        public string EventKindOpenUrl { get; set; }
    }
}
