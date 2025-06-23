using AutoMapper;
using RandomLeague.DTOs;
using RandomLeague.Models;
using RandomLeague.Repositories;

namespace RandomLeague.Services
{
	public class LeagueService : ILeagueService
	{
		private readonly ILeagueRepository _leagueRepo;
		private readonly IMapper _mapper;

		public LeagueService(ILeagueRepository leagueRepo, IMapper mapper)
		{
			_leagueRepo = leagueRepo;
			_mapper = mapper;
		}

		public List<LeagueStanding> GetRandomLeagueStandings()
		{
			return _leagueRepo.GetRandomStandings();
		}


		public IEnumerable<FixtureReadDto> GetAllFixtures()
		{
			return _mapper.Map<IEnumerable<FixtureReadDto>>(_leagueRepo.Fixtures);
		}

		public void ResetLeague()
		{
			_leagueRepo.ResetLeague();
		}
	}

}
