using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShortUrl.Services;

namespace ShortUrl.Controllers
{
    public class TestController : Controller
    {
        private IEncodeService _encodeService;

        public TestController(IEncodeService encodeService)
        {
            this._encodeService = encodeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Encode(string url = "abc")
        {
            var code = this._encodeService.Encode(url);
            return code;
        }
    }
}