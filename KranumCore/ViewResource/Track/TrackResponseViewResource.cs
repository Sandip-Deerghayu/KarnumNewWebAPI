using KranumCore.ViewResource.Event;
using KranumCore.ViewResource.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Track
{
    public class TrackResponseViewResource
    {
        public string EventUUID { get; set; }
        public string Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual ICollection<SessionResponseViewResource> Session { get; set; }
    }
}
