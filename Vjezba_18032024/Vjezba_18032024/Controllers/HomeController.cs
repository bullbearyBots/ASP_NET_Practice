using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vjezba_18032024.Models;
using Vjezba_18032024.Models.ViewModels;
using Vjezba_18032024.Services.Interfaces;

namespace Vjezba_18032024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPolazniciService _polazniciService;

        public HomeController(ILogger<HomeController> logger,
            IPolazniciService polazniciService)
        {
            _logger = logger;
            _polazniciService = polazniciService;
        }

        public IActionResult Index()
        {
            var polaznici = _polazniciService.DohvatiSvePolaznike();
            return View(polaznici);
        }
        public IActionResult IndexNovi()
        {
            var polaznici = _polazniciService.DohvatiSvePolaznike();
            return View(polaznici);
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
    }
}
