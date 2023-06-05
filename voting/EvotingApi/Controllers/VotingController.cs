using EvotingApi.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvotingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotingController : ControllerBase
    {
        private readonly CandidateRepo candidateRepo;
        private readonly IntervalRepo intervalRepo;

        public VotingController(CandidateRepo candidateRepo,
            IntervalRepo intervalRepo)
        {
            this.candidateRepo = candidateRepo;
            this.intervalRepo = intervalRepo;
        }
        [HttpGet("GetCandidates")]
        public IActionResult GetCandidates()
        {
            if (intervalRepo.IsVotingAvailable())
            {
                return Ok(candidateRepo.GetCandidates());
            }
            return Ok();
        }

        [HttpGet("GetVotingSummary")]
        public IActionResult GetVotingSummary()
        {
            if (!intervalRepo.IsVotingAvailable())
              return  Ok(candidateRepo.GetVotingSummary());
            return Ok();
        }

    }
}
