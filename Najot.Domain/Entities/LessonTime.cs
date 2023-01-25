using NajotEdu.ru.Najot.Domain.AbstractEntities;

namespace NajotEdu.ru.Najot.Domain.Entities
{
    public class LessonTime : Auditable
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateOnly Day { get; set; }
    }
}
