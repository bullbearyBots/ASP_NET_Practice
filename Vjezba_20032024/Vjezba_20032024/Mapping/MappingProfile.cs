using AutoMapper;
using Vjezba_20032024.Models.Binding;
using Vjezba_20032024.Models.Dbo;
using Vjezba_20032024.Models.ViewModel;

namespace Vjezba_20032024.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PolaznikBinding, Polaznik>();
            CreateMap<PolaznikUpdateBinding, Polaznik>();
            CreateMap<Polaznik, PolaznikViewModel>();
        }
    }
}
