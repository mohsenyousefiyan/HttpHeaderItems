using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public class HttpHeaderItem
    {
        [FromHeader]
        public string Connection { get; set; }

        [FromHeader]
        public string Accept { get; set; }

        [FromHeader]
        public string Host { get; set; }

        [FromHeader]
        public string Cookie { get; set; }

        [FromHeader(Name = "Accept-Encoding")]
        public string AcceptEncoding { get; set; }

        [FromHeader(Name = "Accept-Language")]
        public string AcceptLanguage { get; set; }

        [FromHeader(Name = "User-Agent")]
        public string UserAgent { get; set; }

        [FromHeader(Name = "Upgrade-Insecure-Requests")]
        public string UpgradeInsecureRequests { get; set; }
    }
}
