using EffenaarTest.Model;
using EffenaarTest.Interfaces;
using FoodooBackend.Logic;

namespace EffenaarTest.Logic
{
    public class AccountLogic
    {
        private readonly IAccountData _accountData;
        public string Register (accountModel account)
        {
            accountModel registerAccount = new accountModel(account.Email, account.Username, account.Password);
            if (_accountData.GetAccountByEmail(account.Email) != null)
                return "Email taken";
            if (_accountData.GetAccountByUsername(account.Username) != null)
                return "Username taken";
            
            _accountData.Register(registerAccount);
            return "succesfully registred";
        }

        public string Login(accountModel accountM)
        {
            accountModel account = _accountData.GetAccountByEmail(accountM.Email);
            if (account.Password != null && account.ValidatePassword(accountM.Password))
            {
                return AuthenticationLogic.GenerateToken(account.Id.ToString(), account.Username, account.Email);
            }
            else
            {
                return "wrong password or username";
            }

        }
        
            
    }
}