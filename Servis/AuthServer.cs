using NajotEdu.ru.Interface;
using NajotEdu.ru.Najot.data.DbContexts;
using NajotEdu.ru.Registar;

namespace NajotEdu.ru.Servis
{
    public class AuthServer : IAuthServer
    {
        private readonly AppDbContext _dbContext;

        public AuthServer(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<string> Login(LoginRegistr request)
        {
            throw new NotImplementedException();
        }

        public Task<string> Password(PasswordRegistr request)
        {
            throw new NotImplementedException();
        }
    }
}
