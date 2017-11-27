using AutoMapper;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Models.DTO;

namespace CompanySearcher.Api.Data
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Company, CompanyVieModel>()
                        .ForMember(dest=>dest.City, opt=> opt.MapFrom(src=>src.Address.City))
                        .ForMember(dest=>dest.PostalCode, opt=> opt.MapFrom(src=>src.Address.PostalCode))
                        .ForMember(dest=>dest.Street, opt=> opt.MapFrom(src=>src.Address.Street))
                        .ForMember(dest=>dest.StreetNumber, opt=> opt.MapFrom(src=>src.Address.StreetNumber));
                });

                return config.CreateMapper();
            }        
    }
}