using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vjezba_20032024.Models.Binding;
using Vjezba_20032024.Models.ViewModel;
using Vjezba_20032024.Services.Interfaces;

namespace Vjezba_20032024.Controllers
{
    public class PolaznikController : Controller
    {
        private readonly IPolaznikService polaznikService;
        private readonly IMapper mapper;
        public PolaznikController(IPolaznikService polaznikService,
            IMapper mapper)
        {
            this.polaznikService = polaznikService;
            this.mapper = mapper;
        }

        public IActionResult Polaznici()
        {
            var polaznici = polaznikService.DohvatiPolaznike();
            return View(polaznici);
        }

        public IActionResult DohvatiPolaznika(int id)
        {
            var polaznik = polaznikService.DohvatiPolaznika(id);
            return View(polaznik);
        }

        public IActionResult SpremiPolaznika()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SpremiPolaznika(PolaznikBinding model)
        {
            polaznikService.SpremiPolaznika(model);
            return RedirectToAction("Polaznici");
        }

        public IActionResult ObrisiPolaznika(int id)
        {
            polaznikService.ObrisiPolaznika(id);
            return RedirectToAction("Polaznici");
        }

        public IActionResult UrediPolaznika(int id)
        {
            var polaznik = polaznikService.DohvatiPolaznika(id);
            var model = mapper.Map<PolaznikUpdateBinding>(polaznik);

            return View(model);
        }

        [HttpPost]
        public IActionResult UrediPolaznika(PolaznikUpdateBinding model)
        {
            polaznikService.UrediPolaznika(model);
            return RedirectToAction("Polaznici");
        }
    }
}
