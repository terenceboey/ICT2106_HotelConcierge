using _2106_Project.Domain.Models;
using _2106_Project.Models;
using System;
using System.Collections.Generic;

namespace _2106_Project.Domain.Services
{
    public interface IAccountService : IDisposable
    {
        bool Login(Account account);
        List<Account> GetAllAccounts();
        Account GetAccountById(int account_id);
        void AddAccount(SignUpModel account);
        void UpdateAccount(Account account);
        void DeleteAccount(int account_id);
    }
}
