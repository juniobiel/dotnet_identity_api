using System.ComponentModel.DataAnnotations;

namespace InvesTrace.Identity.Api.Dto.Account;

public class LoginDto
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}
