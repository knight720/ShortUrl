using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShortUrl.Models;
using ShortUrl.Services;

namespace ShortUrl.Controllers
{
    public class HomeController : Controller
    {
        private IUrlService _urlService;

        public HomeController(IUrlService urlService)
        {
            this._urlService = urlService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("")]
        public IActionResult Url()
        {
            return View();
        }

        [Route("/{code}")]
        public IActionResult RedirectUrl(string code)
        {
            var url = this._urlService.GetUrl(code);
            return Redirect(url);
        }
    }
}
