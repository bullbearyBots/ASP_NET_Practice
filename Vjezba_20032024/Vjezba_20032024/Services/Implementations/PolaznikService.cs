using AutoMapper;
using Vjezba_20032024.Models.Binding;
using Vjezba_20032024.Models.Dbo;
using Vjezba_20032024.Models.ViewModel;
using Vjezba_20032024.Services.Interfaces;

namespace Vjezba_20032024.Services.Implementations
{
    public class PolaznikService : IPolaznikService
    {
        private readonly IMapper mapper;
        private static List<Polaznik> polaznici = new List<Polaznik>()
        {
            new Polaznik
            {
                Id = 1,
                Ime = "Pero",
                Prezime = "Perić",
                Oib = "10010010011"
            },
            new Polaznik
            {
                Id = 2,
                Ime = "Jozo",
                Prezime = "Jozić",
                Oib = "11210010022"
            },
            new Polaznik
            {
                Id = 3,
                Ime = "Marko",
                Prezime = "Marković",
                Oib = "12309121408"
            },
            new Polaznik
            {
                Id = 4,
                Ime = "Ela",
                Prezime = "Elić",
                Oib = "66390120912"
            },
            new Polaznik
            {
                Id = 5,
                Ime = "Ivo",
                Prezime = "Ivić",
                Oib = "22123101020"
            },
        };

        public PolaznikService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<PolaznikViewModel> DohvatiPolaznike()
        {
            return polaznici.Select(
                y => mapper.Map<PolaznikViewModel>(y))
                .ToList();
        }

        public PolaznikViewModel DohvatiPolaznika(int id)
        {
            var polaznik = polaznici.FirstOrDefault(y => y.Id == id);

            return mapper.Map<PolaznikViewModel>(polaznik);
        }

        public bool ObrisiPolaznika(int id)
        {
            try
            {

                polaznici.Remove(
                    polaznici.FirstOrDefault(y => y.Id == id)
                    );

                return true;
            }
            catch
            {
                return false;
            }
        }

        public PolaznikViewModel SpremiPolaznika(PolaznikBinding model)
        {
            var dbo = mapper.Map<Polaznik>(model);
            dbo.Id = GenerirajId();
            polaznici.Add(dbo);
            // db.SaveChanges();

            return mapper.Map<PolaznikViewModel>(dbo);
        }

        public PolaznikViewModel UrediPolaznika(PolaznikUpdateBinding model)
        {
            Polaznik dbo = polaznici.FirstOrDefault(y => y.Id == model.Id);
            mapper.Map(model, dbo); // Prebaci iz modela sve u dbo

            return mapper.Map<PolaznikViewModel>(dbo);
        }

        private int GenerirajId()
        {
            if (!polaznici.Any())
            {
                return 1;
            }

            return polaznici.OrderByDescending(y => y.Id).First().Id + 1;
        }
    }
}
