using EvotingApi.Dtos;
using EvotingApi.Repos;
using Microsoft.AspNetCore.Mvc;

namespace EvotingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntervalController : ControllerBase
    {
        private readonly IntervalRepo intervalRepo;

        public IntervalController(IntervalRepo intervalRepo)
        {
            this.intervalRepo = intervalRepo;
        }
        [HttpPost("UpdateVotingInterval")]
        public IActionResult UpdateVotingInterval(IntervalDto interval)
        {
            if (interval.StartDate > interval.EndDate)
            {
                var end = interval.StartDate;
                interval.StartDate = interval.EndDate;
                interval.EndDate = end;
            }
            if (!intervalRepo.UpdateInterval(interval))
                return BadRequest("Error Happend While Processing Your Request");
            return Ok();
        }
    }
}
