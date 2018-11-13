using System.Collections.Generic;

namespace ShortUrl.Services
{
    public class MemoryUrlService : IUrlService
    {
        private static Dictionary<string, string> _urlDictionary = new Dictionary<string, string>();
        private static Dictionary<string, string> _codeDictionary = new Dictionary<string, string>();

        private IEncodeService _encodeService;

        public MemoryUrlService(IEncodeService encode)
        {
            this._encodeService = encode;
        }

        public string GetShort(string url)
        {
            string code = string.Empty;

            if (MemoryUrlService._urlDictionary.ContainsKey(url))
            {
                code = MemoryUrlService._urlDictionary[url];
            }
            else
            {
                code = this._encodeService.Encode(url);
                MemoryUrlService._urlDictionary.Add(url, code);
                MemoryUrlService._codeDictionary.Add(code, url);
            }

            return code;
        }

        public string GetUrl(string code)
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