namespace RandomLeague.DTOs
{
	public class FixtureReadDto
	{
		public int Id { get; set; }
		public string HomeTeam { get; set; }
		public string AwayTeam { get; set; }
		public int? HomeScore { get; set; }
		public int? AwayScore { get; set; }
	}
}
