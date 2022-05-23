using EffenaarTest.Model;
using EffenaarTest.Interfaces;

namespace EffenaarTest.Logic
{
    public class AccountLogic
    {
        private readonly IAccountData _accountData;

        public AccountLogic(IAccountData accountData)
        {
            _accountData = accountData;
        }
        public string Register(accountModel apiAccount)
        {
            accountModel account = new accountModel(apiAccount.Email, apiAccount.Username, apiAccount.Password);
            if (_accountData.GetAccountByEmail(apiAccount.Email) != null)
                return "Email taken";
            if (_accountData.GetAccountByUsername(apiAccount.Username) != null)
                return "Username taken";
            
            _accountData.Register(account);
            return "success";
        }

        public string Login(accountModel apiAccount)
        {
            accountModel account = _accountData.GetAccountByEmail(apiAccount.Email);
            if (account.Password != null && account.ValidatePassword(apiAccount.Password))
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