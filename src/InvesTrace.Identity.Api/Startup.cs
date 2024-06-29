using InvesTrace.Identity.Api.Configuration;

namespace InvesTrace.Identity.Api;

public class Startup
{
    private const string LOCAL_HOST = "Localhost";

    public IConfiguration Configuration { get; }

    public Startup( IHostEnvironment hostEnvironment )
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(hostEnvironment.ContentRootPath)
            .AddJsonFile("appsettings.json", true, true)
            .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, true)
            .AddEnvironmentVariables();

        Configuration = builder.Build();
    }

    public void ConfigureServices( IServiceCollection services )
    {
        services.AddControllers();
        services.AddSwaggerConfig();

        services.AddDbConfig(Configuration);
        services.AddIdentityConfig();
        services.AddAuthenticationConfig(Configuration);
        services.AddDependencyInjections();

        Console.WriteLine(Directory.GetCurrentDirectory().ToString());
    }

    public void Configure( IApplicationBuilder app, IHostEnvironment env )
    {
        if (env.IsDevelopment() || env.IsEnvironment(LOCAL_HOST))
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseHttpsRedirection();
        app.UseHsts();
        app.UseAuthorization();
        app.UseAuthentication();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

    }
}
