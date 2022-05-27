using EffenaarTest.Model;
using EffenaarTest.Interfaces;

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
            return "succesfully logged in";
        }

        
            
    }
}