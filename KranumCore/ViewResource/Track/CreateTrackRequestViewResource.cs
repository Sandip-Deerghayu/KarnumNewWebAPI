using KranumCore.ViewResource.Event;
using KranumCore.ViewResource.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Track
{
    public class CreateTrackRequestViewResource
    {
        [Required]
        public string EventUUID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
