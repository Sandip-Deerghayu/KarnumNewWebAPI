using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentAddress = new HashSet<StudentAddress>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public virtual ICollection<StudentAddress> StudentAddress { get; set; }
    }
}
