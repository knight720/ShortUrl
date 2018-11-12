namespace ShortUrl.Services
{
    public interface IUrlService
    {
        string getShort(string url);

        string getUrl(string code);
    }
}