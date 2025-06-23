using AutoMapper;
using RandomLeague.DTOs;
using RandomLeague.Models;

namespace RandomLeague.Mappings
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Fixture, FixtureReadDto>()
				.ForMember(dest => dest.HomeTeam, opt => opt.MapFrom(src => src.HomeTeam.Name))
				.ForMember(dest => dest.AwayTeam, opt => opt.MapFrom(src => src.AwayTeam.Name));
		}
	}
}
