using NajotEdu.ru.Interface;
using NajotEdu.ru.Registar;

namespace NajotEdu.ru.Servis
{
    public class AuthServer : IAuthServer
    {
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
