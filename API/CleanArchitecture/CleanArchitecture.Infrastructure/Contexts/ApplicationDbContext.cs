using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities.Date;
using System;
using CleanArchitecture.Core.Entities.City;
using CleanArchitecture.Core.Entities.TravelEntities;

namespace CleanArchitecture.Infrastructure.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IDateTimeService _dateTime;
        private readonly IAuthenticatedUserService _authenticatedUser;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTimeService dateTime, IAuthenticatedUserService authenticatedUser) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTime = dateTime;
            _authenticatedUser = authenticatedUser;
        }

        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }

        public DbSet<AllWorldCities> AllWorldCities  { get; set; }
        public DbSet<TravelRoute> TravelRoutes { get; set; }

        public DbSet<Breakfast> Breakfasts { get; set; }

        public DbSet<Lunch> Lunches { get; set; }
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<FirstPlaceForRoute> FirstPlaceForRoutes { get; set; }
        public DbSet<SecondPlaceForRoute> SecondPlaceForRoutes { get; set; }
        public DbSet<ThirdPlaceForRoute> ThirdPlaceForRoutes { get; set; }
        public DbSet<EventAfterDinner> EventAfterDinners { get; set; }

        public DbSet<DisplayName> DisplayNames { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<PaymentOptions> PaymentOptions { get; set; }

        public DbSet<Photos> Photos { get; set; }

        public DbSet<PrimaryTypeDisplayName> PrimaryTypeDisplayNames { get; set; }

        public DbSet<RegularOpeningHours> RegularOpeningHours { get; set; }

        public DbSet<Close> Closes { get; set; }
        public DbSet<Open> Opens { get; set; }
        public DbSet<Period> Periods { get; set; }

        public DbSet<TravelOtel> TravelOtels { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch 
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow 
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");

            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            //All Decimals will have 18,6 Range
            foreach (var property in builder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,6)");
            }


            base.OnModelCreating(builder);
        }
    }
}
