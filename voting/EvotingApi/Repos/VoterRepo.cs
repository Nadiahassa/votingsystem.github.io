using EvotingApi.Data;
using EvotingApi.Entities;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace EvotingApi.Repos
{
    public class VoterRepo
    {
        private readonly EvotingContext context;

        public VoterRepo(EvotingContext _context)
        {
            context = _context;
        }

        public Voter GetById(int id)
           => context.Voters.Where(v => v.Id == id).FirstOrDefault();
        public Voter GetByNatId(string nId)
             => context.Voters.Where(v => v.NationalId == nId).FirstOrDefault();

        public Voter GetByToken(string token)
        {
             var voter= context.Voters.Where(v => v.Token == token).FirstOrDefault();
            return voter;
        }
        public bool Update(Voter user)
        {
            if(user != null)
            {
               context.Update(user);
                return context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
