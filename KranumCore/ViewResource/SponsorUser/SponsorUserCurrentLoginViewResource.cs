using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.SponsorUser
{
    public class SponsorUserCurrentLoginViewResource
    {
        public int Id { get; set; }
        
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        public string EmailId { get; set; }

        
        public bool IsLogin { get; set; }
        }
}
