using InvesTrace.Identity.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvesTrace.Identity.Api.Data;

public class ApplicationIdentityDbContext : IdentityDbContext<AppUser>
{
    public ApplicationIdentityDbContext( DbContextOptions dbContextOptions ) : base(dbContextOptions) { }

    protected override void OnModelCreating( ModelBuilder builder )
    {
        base.OnModelCreating(builder);

        List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER"
            }
        };

        builder.Entity<AppUser>(e =>
        {
            e.Property(a => a.Name)
                .HasMaxLength(250)
                .IsRequired();
        });

        builder
            .Entity<IdentityRole>()
            .HasData(roles);
    }
}
