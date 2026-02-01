using System.Data.Entity;

namespace TourismManagementSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("TourismContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<TourDate> TourDates { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure one-to-many relationships
            modelBuilder.Entity<Agency>()
                .HasRequired(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Tourist>()
                .HasRequired(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Booking>()
                .HasOptional(b => b.Feedback)
                .WithRequired(f => f.Booking)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Booking>()
                .HasOptional(b => b.Payment)
                .WithRequired(p => p.Booking)
                .WillCascadeOnDelete(true);
        }
    }
}
