using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportComplex.Models;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace SportComplex.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<LockerRoom> LockerRooms { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Athlete>()
            .HasOne(e => e.Sport)
            .WithOne(e => e.Athlete)
        .HasForeignKey<Athlete>(e => e.SportId)
            .IsRequired();

             builder.Entity<LockerRoom>().ToTable("LockerRooms");
            builder.Entity<LockerRoom>().
                HasMany(e => e.Lockers)
                .WithOne(e => e.LockerRoom)
                .HasForeignKey(e => e.LockerRoomId)
                .IsRequired();
            base.OnModelCreating(builder);
        }

    }
}
