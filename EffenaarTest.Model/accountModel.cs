using System;
using System.Collections.Generic;

namespace EffenaarTest.Model
{
    public class accountModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public int Coins { get; set; }
        
        public List<achievementModel> Achievements { get; set; }
        
        public accountModel(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }
    }
}