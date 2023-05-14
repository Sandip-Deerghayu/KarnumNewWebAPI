using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KranumDataAccess.Model
{
    public partial class ExceptionLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("UUID")]
        [StringLength(255)]
        public string Uuid { get; set; }
        [StringLength(100)]
        public string ControllerName { get; set; }
        [StringLength(100)]
        public string ActionName { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
