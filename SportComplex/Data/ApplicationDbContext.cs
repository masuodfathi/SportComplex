using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportComplex.Models;

namespace SportComplex.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Locker>Lockers { get;set; }
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
            builder.Entity<Locker>().ToTable("Lockers");
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
