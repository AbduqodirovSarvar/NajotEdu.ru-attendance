using NajotEdu.ru.Najot.Domain.AbstractEntities;
using NajotEdu.ru.Najot.Domain.Enums;

namespace NajotEdu.ru.Najot.Domain.Entities
{
    public class User : Auditable
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public UserRole UserRole { get; set; } = UserRole.Teacher;

    }
}
