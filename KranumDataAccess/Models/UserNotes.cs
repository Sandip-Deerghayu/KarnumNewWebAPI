﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumDataAccess.Models
{
    public partial class UserNotes
    {
        public int Id { get; set; }

        public string UUID { get; set; }
        
        /* User UUID*/  
        public string UserUUID { get; set; }

        /* LoginUUID meaning employee UUID*/
        public string LoginUUID { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
