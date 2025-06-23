using RandomLeague.Models;

namespace RandomLeague.Repositories
{
	public interface ILeagueRepository
	{
		List<Team> Teams { get; }
		List<Fixture> Fixtures { get; }
		List<LeagueStanding> GetRandomStandings();

		void SimulateMatchScores();
		void ResetLeague();
	}
}
