namespace OnlineCourses.Data
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public ICollection<Course>? CoursesTaught { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<Result>? Results { get; set; }
    }
}
