using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.ViewResource.UserNotes
{
    public class UpdateUserNotesViewResource
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserUUID { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginUUID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(256)]
        public string Notes { get; set; }
    }
}
