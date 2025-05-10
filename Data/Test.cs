using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.Data
{
    public class Test
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }

        public virtual ICollection<Result>? Results { get; set; }
    }
}
