﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Location
{
    public class CreateLocationRequestViewResource
    {
        public string UserUUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string WebsiteUrl { get; set; }
        public int ParticipationType { get; set; }
    }
}
