using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.Services
{
    public abstract class UrlService : IUrlService
    {
        public string GetShort(string url)
        {
            throw new NotImplementedException();
        }

        public string GetUrl(string code)
        {
            throw new NotImplementedException();
        }
    }
}
