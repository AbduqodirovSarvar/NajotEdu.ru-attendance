using NajotEdu.ru.Najot.Domain.AbstractEntities;

namespace NajotEdu.ru.Najot.Domain.Entities
{
    public class Course : Auditable
    {
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public User Teacher { get; set; }
    }
}
