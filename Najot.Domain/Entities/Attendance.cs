using NajotEdu.ru.Najot.Domain.AbstractEntities;

namespace NajotEdu.ru.Najot.Domain.Entities
{
    public class Attendance : Auditable
    {
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int LessonId { get; set; }
        public LessonTime Lesson { get; set; }
        public bool Attend { get; set; }
    }
}
