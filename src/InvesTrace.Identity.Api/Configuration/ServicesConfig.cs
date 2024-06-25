using InvesTrace.Identity.Api.Services;
using InvesTrace.Identity.Api.Services.Interfaces;

namespace InvesTrace.Identity.Api.Configuration;

public static class ServicesConfig
{
    public static IServiceCollection AddDependencyInjections( this IServiceCollection services )
    {
        services.AddScoped<ITokenService, TokenService>();

        return services;
    }
}
