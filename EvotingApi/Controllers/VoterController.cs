using EvotingApi.Dtos;
using EvotingApi.Repos;
using EvotingApi.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EvotingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class VoterController : ControllerBase
    {
        private readonly VoterRepo voterRepo;
        private readonly CandidateRepo candidateRepo;
        private readonly IntervalRepo intervalRepo;
        private readonly IHttpContextAccessor httpContextAccessor;
        public VoterController
            (
            VoterRepo _voterRepo,
            CandidateRepo _candidateRepo,
            IntervalRepo intervalRepo,
        IHttpContextAccessor _httpContextAccessor,
            IMailingService mailingService
            )
        {
            voterRepo = _voterRepo;
            candidateRepo = _candidateRepo;
            this.intervalRepo = intervalRepo;
            httpContextAccessor = _httpContextAccessor;
            _mailingService = mailingService;
        }

        public IMailingService _mailingService { get; }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDto loginDto)
        {
            var user = voterRepo.GetByNatId(loginDto.NationalId);

            if (user == null || user.Email != loginDto.Email)
                return Ok("Voter not Valid");

            else if (user.IsVoting == true)
                return Ok("Voter has already voted");

            else if (user.IsDead == true )
                return Ok("Voter Dead");

            else if (user.Age < 18)
                return Ok("Voter is below the voting age");
            {
                // create code with 6 dig
                var rnd = new Random();
                var code = rnd.Next(100000, 999999).ToString();

                //create and send Email 
                var body = $" Voting System verification code is:\r\n" + code + " \r\n\r\n Don't share this code with anyone; our employees will never ask for the code.";
                try
                {
                    await _mailingService.SendEmailAsync(user.Email, "Verify your Email", body);

                }
                catch (Exception)
                {
                    return Ok("Code not sent.");

                }
                //save code in database
                user.Code = code;
                user.Token = Guid.NewGuid().ToString();
                voterRepo.Update(user);
                //se
                httpContextAccessor.HttpContext.Response.Headers.Add("token", user.Token);

                return Ok("Please Check your Email :)");
            }
        }

        [HttpPost("check-code")]
        public ActionResult<VoterDto> CheckCode(CodeDto codedto)
        {
            if (codedto == null)
                return Ok("Code is Required");

            string token = httpContextAccessor.HttpContext.Request.Headers["token"].ToString();
            if (String.IsNullOrEmpty(token))
                return Unauthorized("token is null");

            var voter = voterRepo.GetByToken(token);
            if (voter == null)
                return Unauthorized("Voter not Valid");

            if (voter.Code != codedto.Code)
                return Ok("Not Valid Code.");

            VoterDto voterout = new VoterDto()
            {
                Email = voter.Email,
                Name = voter.Name,
                NationalId = voter.NationalId
            };

            return Ok(voterout);

        }

        [HttpGet("SubmitElection/{CandinateID}")]
        public IActionResult SubmitElection(int CandinateID)
        {
            if (!intervalRepo.IsVotingAvailable())
                return BadRequest("Voting isn't available");
            string token = httpContextAccessor.HttpContext.Request.Headers["token"].ToString();
            if (string.IsNullOrEmpty(token))
                return Unauthorized("token is null");

            var voter = voterRepo.GetByToken(token);
            if (voter == null)
                return Unauthorized("Voter not Valid");

            if (voter.IsVoting == true)
                return BadRequest("Voter is Already Voting");

            var candidate = candidateRepo.GetByID(CandinateID);
            if (candidate == null)
                return NotFound();

            candidate.NumberofVoters += 1;

            voter.Date = DateTime.UtcNow.AddHours(3);
            voter.CandidateId = CandinateID;
            voter.Candidate = candidate;
            voter.IsVoting = true;

            if (!voterRepo.Update(voter))
                return BadRequest("Error Happend While Updating Voter");
            if (!candidateRepo.Update(candidate))
                return BadRequest("Error Happend While Updating Candidate");
            return Ok(new {message="success"});
        }
    }
}