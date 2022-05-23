using System;
using System.Threading.Tasks;
using EffenaarTest.Data;
using EffenaarTest.Logic;
using EffenaarTest.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FoodooBackend.Api.Controllers
{
    [EnableCors("AllowCORS")]
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly AccountLogic _accountLogic;
        
        public AccountController(EffenaarContext context)
        {
            _accountLogic = new AccountLogic(new AccountData(context));
        }

        [HttpPost("/account/register")]
        public void Register(ApiAccount account)
        {
            _accountLogic.Register(account);
        }

        [HttpPost("/account/login")]
        public string Login(ApiAccount account)
        {
            return _accountLogic.Login(account);
        }

        [HttpGet("/account/info/{token}")]
        public IActionResult GetAccountInfo(string token)
        {
            return StatusCode(200, AuthenticationLogic.getAccountInfo(token));
            
        }

    }
}