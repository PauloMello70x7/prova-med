using AutoMapper;


namespace ProvaMed.Api.Configuration
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterViewModelDomainMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
            });
        }

    }
}
