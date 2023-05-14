using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class UpdateEventResponseViewResource
    {
        public int Id { get; set; }
        public string UUID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime? ActualStartDateTime { get; set; }
    }
}
