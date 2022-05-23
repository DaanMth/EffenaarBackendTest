﻿using System;
using System.Linq;
using System.Threading.Tasks;
using EffenaarTest.Interfaces;
using EffenaarTest.Model;
using Microsoft.EntityFrameworkCore;

namespace EffenaarTest.Data
{
    public class AccountData
    {
        private readonly EffenaarContext _context;

        public AccountData(EffenaarContext context)
        {
            _context = context;
        }
        
        public void Register(accountModel account)
        {
            _context.Accounts.Add(account);
            
        }

        public accountModel GetAccountByEmail(string email)
        {
            return _context.Accounts.FirstOrDefault(x => x.Email == email);
        }
        
        public accountModel GetAccountByUsername(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Email == username);
        }
    }
}