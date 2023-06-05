using System.ComponentModel.DataAnnotations;

namespace EvotingApi.Dtos
{
    public class VoterDto
    {
        
        public string Email { get; set; }
        
        public string NationalId { get; set; }
        public string Name { get; set;}

    }
}
