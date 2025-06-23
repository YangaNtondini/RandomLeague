using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomLeague.Services;

namespace RandomLeague.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class LeagueController : ControllerBase
	{
		private readonly ILeagueService _leagueService;

		public LeagueController(ILeagueService leagueService)
		{
			_leagueService = leagueService;
		}

		[HttpGet("fixtures")]
		public IActionResult GetFixtures()
		{
			var fixtures = _leagueService.GetAllFixtures();
			return Ok(fixtures);
		}

		[HttpPost("reset")]
		public IActionResult ResetLeague()
		{
			_leagueService.ResetLeague();
			return Ok(new { message = "League has been reset." });
		}
		[HttpGet("standings")]
		public IActionResult GetRandomStandings()
		{
			var standings = _leagueService.GetRandomLeagueStandings();
			return Ok(standings);
		}
	}

}
