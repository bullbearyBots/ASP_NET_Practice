using Vjezba_18032024.Models.ViewModels;
using Vjezba_18032024.Services.Interfaces;

namespace Vjezba_18032024.Services.Implementations
{

    public class PolazniciService : IPolazniciService
    {
        private static List<PolaznikViewModel> Polaznici = new List<PolaznikViewModel>()
        {
            new PolaznikViewModel { Id = 1, Ime = "Pero", Prezime = "Perić" },
            new PolaznikViewModel { Id = 2, Ime = "Ivo", Prezime = "Ivić" },
            new PolaznikViewModel { Id = 3, Ime = "Ana", Prezime = "Anić" },
            new PolaznikViewModel { Id = 4, Ime = "Iva", Prezime = "Ivanić" },
            new PolaznikViewModel { Id = 5, Ime = "Marko", Prezime = "Marković" },
        };

        public List<PolaznikViewModel> DohvatiSvePolaznike()
        {
            return Polaznici;
        }
    }
}
