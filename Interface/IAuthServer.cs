using NajotEdu.ru.Registar;

namespace NajotEdu.ru.Interface
{
    public interface IAuthServer
    {
        Task<string> Login(LoginRegistr request);
        Task<string> Password(PasswordRegistr request);
    }
}
