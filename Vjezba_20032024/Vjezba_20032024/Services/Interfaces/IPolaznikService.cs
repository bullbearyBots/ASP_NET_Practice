using Vjezba_20032024.Models.Binding;
using Vjezba_20032024.Models.ViewModel;

namespace Vjezba_20032024.Services.Interfaces
{
    public interface IPolaznikService
    {
        PolaznikViewModel DohvatiPolaznika(int id);
        List<PolaznikViewModel> DohvatiPolaznike();
        bool ObrisiPolaznika(int id);
        PolaznikViewModel SpremiPolaznika(PolaznikBinding model);
        PolaznikViewModel UrediPolaznika(PolaznikUpdateBinding model);
    }
}