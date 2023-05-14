using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.BroadcastMessage
{
    public class CreateBroadcastMessageRequestViewResource
    {
        [Required]
        public string EventUUID { get; set; }

        [Required]
        [StringLength(1000)]
        public string MessageText { get; set; }
    }
}
