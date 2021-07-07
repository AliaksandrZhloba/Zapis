using System;

using Zapis.Services.JwtSecurity;


namespace Zapis.Services.Account
{
    public class AccountService
    {
        public User GetUser(string login, string password)
        {
            return new User()
            {
                UserName = "aa8db7cb-0974-46d0-8b76-08b94f6f1895"
            };
        }
    }
}