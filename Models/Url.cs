using System;
using System.Collections.Generic;

namespace ShortUrl.Models
{
    public partial class Url
    {
        public int UrlId { get; set; }
        public string UrlCode { get; set; }
        public string UrlUrl { get; set; }
    }
}
