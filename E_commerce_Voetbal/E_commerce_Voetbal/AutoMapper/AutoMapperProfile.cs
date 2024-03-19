using AutoMapper;
using E_commerce_Voetbal.ViewModels;
using E_Commerce_Voetbal.Domains_.Entities;

namespace E_commerce_Voetbal.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Match, MatchVM>().ForMember(dest => dest.HomeTeam,
                opts => opts.MapFrom(
                    src => src.HomeTeam.Name))
                .ForMember(dest => dest.AwayTeam,
                opts => opts.MapFrom(
                    src => src.VisitorTeam.Name))
                .ForMember(dest => dest.HomeTeamLogo,
                opts => opts.MapFrom(
                    src => src.HomeTeam.Logo))
                .ForMember(dest => dest.AwayTeamLogo,
                opts => opts.MapFrom(
                    src => src.VisitorTeam.Logo))
                .ForMember(dest => dest.Stadium,
                opts => opts.MapFrom(
                    src => src.HomeTeam.Stadium.Name));
        }
    }
}
