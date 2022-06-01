using System;
using System.Threading.Tasks;
using EffenaarTest.Data;
using EffenaarTest.Logic;
using EffenaarTest.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EffenaarTest.Controllers
{
    [EnableCors("AllowCORS")]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly AccountLogic _accountLogic;
        
        [HttpPost("/account/register")]
        public void Register(accountModel account)
        {
            _accountLogic.Register(account);
        }

        [HttpPost("/account/login")]
        public void Login(accountModel accountModel)
        {
            _accountLogic.Login(accountModel);
        }
    }
}