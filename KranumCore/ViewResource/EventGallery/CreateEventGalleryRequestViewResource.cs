﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventGallery
{
    public class CreateEventGalleryRequestViewResource
    {
        [Required]
        public string EventUUID { get; set; }
        [Required]
        [StringLength(500)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(500)]
        public string MeetingUrl { get; set; }
        public List<string> ResourceUUID { get; set; }

    }
}
