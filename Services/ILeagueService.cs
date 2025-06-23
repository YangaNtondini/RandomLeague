using RandomLeague.DTOs;
using RandomLeague.Models;

namespace RandomLeague.Services
{
	public interface ILeagueService
	{
		IEnumerable<FixtureReadDto> GetAllFixtures();
		List<LeagueStanding> GetRandomLeagueStandings();

		void ResetLeague();
	}
}
