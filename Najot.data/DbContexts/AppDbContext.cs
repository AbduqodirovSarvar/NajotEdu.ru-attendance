using Microsoft.EntityFrameworkCore;
using NajotEdu.ru.Najot.Domain.Entities;

namespace NajotEdu.ru.Najot.data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
        public DbSet<LessonTime> Lessons { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
