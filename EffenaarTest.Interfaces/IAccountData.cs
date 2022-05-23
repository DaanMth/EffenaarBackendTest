using System.Threading.Tasks;
using EffenaarTest.Model;

namespace EffenaarTest.Interfaces
{
    public interface IAccountData
    {
        void Register(accountModel account);
        accountModel GetAccountByEmail(string email);
        accountModel GetAccountByUsername(string username);
    }
}