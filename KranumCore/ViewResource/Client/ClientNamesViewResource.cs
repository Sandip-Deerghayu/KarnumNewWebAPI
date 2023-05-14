using KranumCore.ViewResource.Resource;
using KranumCore.ViewResource.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Client
{
    public class ClientNamesViewResource
    {
        public string Uuid { get; set; }
        public string Name { get; set; }

        public List<UserNamesViewResource> User { get; set; }
        public List<ResourceNamesViewResource> ResourceAssociatedClient { get; set; }
    }
}
