using KranumCore.ViewResource.Event;
using KranumCore.ViewResource.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Track
{
    public class TrackViewResource
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<SessionViewResource> Session { get; set; }
    }
}
