using AutoMapper;
using ProvaMed.Api.ViewModels;
using ProvaMed.DomainModel.Entity;

namespace ProvaMed.Api.Configuration
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Contato, ContatoViewModel>().ReverseMap();
        }
    }
}
