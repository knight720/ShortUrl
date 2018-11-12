using System.Collections.Generic;

namespace ShortUrl.Services
{
    public class MemoryUrlService : IUrlService
    {
        private static Dictionary<string, string> _urlDictionary = new Dictionary<string, string>();
        private static Dictionary<string, string> _codeDictionary = new Dictionary<string, string>();

        public string getShort(string url)
        {
            string code = string.Empty;

            if (MemoryUrlService._urlDictionary.ContainsKey(url))
            {
                code = MemoryUrlService._urlDictionary[url];
            }
            else
            {
                code = url.GetHashCode().ToString();
                MemoryUrlService._urlDictionary.Add(url, code);
                MemoryUrlService._codeDictionary.Add(code, url);
            }

            return code;
        }

        public string getUrl(string code)
        {
            string url = string.Empty;

            if (MemoryUrlService._codeDictionary.ContainsKey(code))
            {
                url = MemoryUrlService._codeDictionary[code];
            }

            return url;
        }
    }
}