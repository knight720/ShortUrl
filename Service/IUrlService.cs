using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.Service
{
    public interface IUrlService
    {
        string getShort(string url);

        string getUrl(string code);
    }
}
