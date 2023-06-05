using System.ComponentModel.DataAnnotations;

namespace EvotingApi.Dtos
{
    public class CodeDto
    {
        [Required] 
        public string Code { get; set; }
        
    }
}
