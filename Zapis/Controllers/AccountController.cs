using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Zapis.Services.Account;
using Zapis.Services.JwtSecurity;


namespace Zapis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly AccountService _accountService;
        private readonly JwtSecurityService _jwtSecurityService;

        public AccountController(ILogger<AccountController> logger, AccountService accountService, JwtSecurityService jwtSecurityService)
        {
            _logger = logger;
            _accountService = accountService;
            _jwtSecurityService = jwtSecurityService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<LoginResult> Login(LoginRequest loginRequest)
        {
            var user = _accountService.GetUser(loginRequest.Login, loginRequest.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var result = _jwtSecurityService.GenerateJSONWebToken(user.UserName, "user");
            var loginResult = new LoginResult()
            {
                UserName = user.UserName,
                Role = user.Role,
                AccessToken = result.AccessToken,
                RefreshToken = result.RefreshToken
            };

            return Ok(loginResult);
        }

        [HttpPost]
        [Route("login_guest")]
        public LoginResult LoginGuest()
        {
            var userName = Guid.NewGuid().ToString();
            var result = _jwtSecurityService.GenerateJSONWebToken(userName, "guest");
            var loginResult = new LoginResult()
            {
                UserName = userName,
                Role = "guest",
                AccessToken = result.AccessToken,
                RefreshToken = result.RefreshToken
            };

            return loginResult;
        }
    }


    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
