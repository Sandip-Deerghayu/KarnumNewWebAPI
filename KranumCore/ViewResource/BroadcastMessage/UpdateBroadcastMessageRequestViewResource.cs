using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.BroadcastMessage
{
    public class UpdateBroadcastMessageRequestViewResource
    {
        [Required]
        public string UUID { get; set; }

        [Required]
        [StringLength(1000)]
        public string MessageText { get; set; }
    }
}
