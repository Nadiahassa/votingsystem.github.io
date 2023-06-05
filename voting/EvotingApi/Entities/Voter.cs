using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvotingApi.Entities
{
    public class Voter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string NationalId { get; set; }
        public DateTime? Date { get; set; }
        
        public string Code { get; set; }
        public int Age { get; set; }
        public string Token { get; set; }
        public bool IsVoting { get; set; } = false;
        public bool IsDead { get; set; }

        [ForeignKey("Candidate")]
        public int? CandidateId { get; set; }
        public Candidate Candidate { get; set; }

    }
}
