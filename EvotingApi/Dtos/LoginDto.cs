using System.ComponentModel.DataAnnotations;

namespace EvotingApi.Dtos
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(length:14)]
        public string NationalId { get; set; }
    }
}
