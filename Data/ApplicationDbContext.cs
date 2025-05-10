using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourses.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Result>()
    .HasOne(r => r.Test)
    .WithMany(t => t.Results)
    .HasForeignKey(r => r.TestId)
    .OnDelete(DeleteBehavior.Restrict);
            // Enrollment: use surrogate key and enforce uniqueness separately
            builder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasIndex(e => new { e.UserId, e.CourseId }).IsUnique();

                entity.HasOne(e => e.User)
                    .WithMany(u => u.Enrollments)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Course)
                    .WithMany(c => c.Enrollments)
                    .HasForeignKey(e => e.CourseId)
                    .OnDelete(DeleteBehavior.Restrict); // prevent multiple cascade paths
            });



        }
    }
}
