using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.Data
{
    public class Result
    {
        public int Id { get; set; }

        [Range(0, 100)]
        public int Score { get; set; }

        public int TestId { get; set; }
        public virtual Test? Test { get; set; }

        public string StudentId { get; set; }
        public virtual ApplicationUser? Student { get; set; }
    }

}
