using EvotingApi.Data;
using EvotingApi.Dtos;
using EvotingApi.Entities;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EvotingApi.Repos
{
    public class CandidateRepo
    {
        private readonly EvotingContext context;

        public CandidateRepo(EvotingContext _context)
        {
            context = _context;
        }
        public Candidate GetByID(int id) => context.Candidates.FirstOrDefault(x => x.Id == id);
        public bool Update(Candidate candidate)
        {
            if (candidate != null)
            {
                context.Candidates.Update(candidate);
                return context.SaveChanges() > 0;
            }
            return false;
        }
        public List<Candidate> GetCandidates()
        {
            context.Candidates.FromSqlRaw("SELECT * FROM Candidate");
            return context.Candidates.ToList();
        }
        public Candidate GetCandidate(int id)
        {
            return context.Candidates.FirstOrDefault(x=>x.Id == id);
        }
        public List<VotingSummaryDTO> GetVotingSummary()
        {
            return context.Candidates.Select(x => new VotingSummaryDTO
            {
                CandidateName = x.Name,
                VotesNumber = x.NumberofVoters
                
            }).ToList();
        }
    }
}
