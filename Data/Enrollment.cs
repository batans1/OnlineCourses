﻿using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCourses.Data
{
    public class Enrollment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }


        public int CourseId { get; set; }
        public virtual Course? Course { get; set; }

        public DateTime EnrolledAt { get; set; }
    }

}
