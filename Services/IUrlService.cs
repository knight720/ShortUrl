namespace ShortUrl.Services
{
    public interface IUrlService
    {
        string GetShort(string url);

        string GetUrl(string code);
    }
}