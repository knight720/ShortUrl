using System.Linq;
using ShortUrl.Models;

namespace ShortUrl.Services
{
    public class DatabaseUrlService : IUrlService
    {
        private IEncodeService _encodeService;

        public DatabaseUrlService(IEncodeService encodeService)
        {
            this._encodeService = encodeService;
        }

        public string GetShort(string url)
        {
            var code = this._encodeService.Encode(url);

            var existUrl = this.GetUrl(code);

            if (string.IsNullOrEmpty(existUrl))
            {
                using (var context = new UrlDBContext())
                {
                    var newUrl = new Url()
                    {
                        UrlCode = code,
                        UrlUrl = url
                    };
                    context.Url.Add(newUrl);
                    context.SaveChanges();
                }
            }

            return code;
        }

        public string GetUrl(string code)
        {
            using (var context = new UrlDBContext())
            {
                var url = context.Url
                    .Where(i => i.UrlCode == code)
                    .SingleOrDefault();

                if (url != null)
                {
                    return url.UrlUrl;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}