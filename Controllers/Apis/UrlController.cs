using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShortUrl.Services;

namespace ShortUrl.Controllers.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        private IUrlService _urlService;

        public UrlController(IUrlService urlService)
        {
            this._urlService = urlService;
        }

        // GET: api/Url
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Url/5
        [HttpGet("{code}", Name = "Get")]
        public string Get(string code)
        {
            return this._urlService.GetUrl(code);
        }

        // POST: api/Url
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return this._urlService.GetShort(value);
        }

        // PUT: api/Url/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}