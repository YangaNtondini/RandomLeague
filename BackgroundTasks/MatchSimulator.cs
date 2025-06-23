using RandomLeague.Repositories;

namespace RandomLeague.BackgroundTasks
{
	public class MatchSimulator : BackgroundService
	{
		private readonly ILeagueRepository _leagueRepo;

		public MatchSimulator(ILeagueRepository leagueRepo)
		{
			_leagueRepo = leagueRepo;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				_leagueRepo.SimulateMatchScores();
				await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
			}
		}
	}

}
