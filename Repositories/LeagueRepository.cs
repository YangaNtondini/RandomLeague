using RandomLeague.Models;

namespace RandomLeague.Repositories
{
	public class LeagueRepository : ILeagueRepository
	{
		public List<Team> Teams { get; private set; }
		public List<Fixture> Fixtures { get; private set; }
		private Random _random = new Random();
		private int _fixtureCounter = 1;

		public LeagueRepository()
		{
			Teams = LoadTeams();
			Fixtures = GenerateFixtures();
		}

		private List<Team> LoadTeams()
		{
			return new List<Team>
		{
			   new Team { Id = 1, Name = "Arsenal" },
			   new Team { Id = 2, Name = "Aston Villa" },
			   new Team { Id = 3, Name = "Bournemouth" },
			   new Team { Id = 4, Name = "Brentford" },
			   new Team { Id = 5, Name = "Brighton" },
			   new Team { Id = 6, Name = "Burnley" },
			   new Team { Id = 7, Name = "Chelsea" },
			   new Team { Id = 8, Name = "Crystal Palace" },
			   new Team { Id = 9, Name = "Everton" },
			   new Team { Id = 10, Name = "Fulham" },
			   new Team { Id = 11, Name = "Liverpool" },
			   new Team { Id = 12, Name = "Luton Town" },
			   new Team { Id = 13, Name = "Man City" },
			   new Team { Id = 14, Name = "Man United" },
			   new Team { Id = 15, Name = "Newcastle" },
			   new Team { Id = 16, Name = "Nottingham Forest" },
			   new Team { Id = 17, Name = "Sheffield United" },
			   new Team { Id = 18, Name = "Tottenham" },
			   new Team { Id = 19, Name = "West Ham" },
			   new Team { Id = 20, Name = "Wolves" }
		};
		}

		private List<Fixture> GenerateFixtures()
		{
			var fixtures = new List<Fixture>();
			var shuffledTeams = Teams.OrderBy(t => _random.Next()).ToList();

			for (int i = 0; i < shuffledTeams.Count; i += 2)
			{
				if (i + 1 >= shuffledTeams.Count) break;

				fixtures.Add(new Fixture
				{
					Id = _fixtureCounter++,
					HomeTeam = shuffledTeams[i],
					AwayTeam = shuffledTeams[i + 1],
					HomeScore = null,
					AwayScore = null
				});
			}

			return fixtures;
		}

		public List<LeagueStanding> GetRandomStandings()
		{
			var standings = new List<LeagueStanding>();
			var random = new Random();

			foreach (var team in Teams)
			{
				var played = random.Next(10, 38);
				var wins = random.Next(0, played);
				var draws = random.Next(0, played - wins);
				var losses = played - wins - draws;
				var goalsFor = random.Next(wins * 1, wins * 4 + 1);
				var goalsAgainst = random.Next(losses * 1, losses * 4 + 1);

				standings.Add(new LeagueStanding
				{
					TeamName = team.Name,
					Played = played,
					Wins = wins,
					Draws = draws,
					Losses = losses,
					GoalsFor = goalsFor,
					GoalsAgainst = goalsAgainst
				});
			}

			return standings.OrderByDescending(s => s.Points)
							.ThenByDescending(s => s.GoalDifference)
							.ThenByDescending(s => s.GoalsFor)
							.ToList();
		}
		public void SimulateMatchScores()
		{
			foreach (var fixture in Fixtures.Where(f => f.HomeScore == null && f.AwayScore == null))
			{
				fixture.HomeScore = _random.Next(0, 5);
				fixture.AwayScore = _random.Next(0, 5);
			}
		}

		public void ResetLeague()
		{
			Fixtures = GenerateFixtures();
		}


	}

}
