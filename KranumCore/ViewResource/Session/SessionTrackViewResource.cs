using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Session
{
    public class SessionTrackViewResource
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
