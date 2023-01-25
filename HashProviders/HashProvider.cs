using System.Security.Cryptography;
using System.Text;

namespace NajotEdu.ru.HashProviders
{
    public class HashProvider
    {
        public static string HashPasword(string password)
        {
            const string pepper = "NajotEdu";
            const int keySize = 64;
            const int iterations = 350000;

            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                new byte[0],
                iterations,
                hashAlgorithm,
                keySize);

            return Convert.ToHexString(hash);
        }
    }
}
