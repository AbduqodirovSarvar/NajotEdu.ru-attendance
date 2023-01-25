using NajotEdu.ru.Najot.Domain.AbstractEntities;

namespace NajotEdu.ru.Najot.Domain.Entities
{
    public class UserCourse : Auditable
    {
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set;}
    }
}
