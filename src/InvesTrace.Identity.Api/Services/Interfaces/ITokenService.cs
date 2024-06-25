using InvesTrace.Identity.Api.Models;

namespace InvesTrace.Identity.Api.Services.Interfaces;

public interface ITokenService
{
    string CreateToken( AppUser user );
}
