﻿namespace RandomLeague.Models
{
	public class Fixture
	{
		public int Id { get; set; }
		public Team HomeTeam { get; set; }
		public Team AwayTeam { get; set; }
		public int? HomeScore { get; set; }
		public int? AwayScore { get; set; }
	}
}
