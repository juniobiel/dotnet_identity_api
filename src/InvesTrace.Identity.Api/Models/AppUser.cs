using Microsoft.AspNetCore.Identity;

namespace InvesTrace.Identity.Api.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; }
}
