using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Resource
{
    public class ResourceNamesViewResource
    {
        public string Uuid { get; set; }
        public string Title { get; set; }
        public bool? IsMedia { get; set; }
        public bool? IsAudio { get; set; }
        public bool? IsDownloadable { get; set; }
    }
}
