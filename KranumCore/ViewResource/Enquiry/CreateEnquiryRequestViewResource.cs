using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Enquiry
{
    public class CreateEnquiryRequestViewResource
    {
        [Required]
        [StringLength(500)]
        public string Profession { get; set; }
        [Required]
        [StringLength(500)]
        public string FullName { get; set; }
        [StringLength(500)]
        public string YoutubeVideoUrl { get; set; }
        [Required]
        [StringLength(500)]
        public string EmailId { get; set; }
        public string Message { get; set; }
    }
}
