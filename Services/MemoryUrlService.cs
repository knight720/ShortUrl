using System.Collections.Generic;

namespace ShortUrl.Services
{
    public class MemoryUrlService : IUrlService
    {
        private static Dictionary<string, string> _codeDictionary = new Dictionary<string, string>();

        private IEncodeService _encodeService;

        public MemoryUrlService(IEncodeService encode)
        {
            this._encodeService = encode;
        }

        public string GetShort(string url)
        {
            var code = this._encodeService.Encode(url);

            if (MemoryUrlService._codeDictionary.ContainsKey(code) == false)
            {
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