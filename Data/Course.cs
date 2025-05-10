using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.Data
{
    public class Course
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        [Required]
        public string TeacherId { get; set; }
        public bool IsFeatured { get; set; }
        public virtual ApplicationUser? Teacher { get; set; }


        public virtual ICollection<Enrollment>? Enrollments { get; set; }

    }
}
