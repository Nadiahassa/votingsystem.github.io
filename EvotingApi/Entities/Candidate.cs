using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace EvotingApi.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Region { get; set; }
        public string Party { get; set; }
        public string Information { get; set; }
        public string PhotoPath { get; set; }
        public long NumberofVoters { get; set; }
    }
}
