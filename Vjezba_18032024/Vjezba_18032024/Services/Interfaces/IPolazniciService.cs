using Vjezba_18032024.Models.ViewModels;

namespace Vjezba_18032024.Services.Interfaces
{
    public interface IPolazniciService
    {
        List<PolaznikViewModel> DohvatiSvePolaznike();
    }
}