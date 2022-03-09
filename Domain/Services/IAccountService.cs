using _2106_Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _2106_Project.Domain.Services
{
    public interface IAccountService : IDisposable
    {
        bool Login(Account account);
        List<Account> GetAllAccounts();
        Account GetAccountById(int account_id);
        void AddAccount(Account account, [Optional] Guest guest, [Optional] Staff staff);
        void UpdateAccount(Account account);
        void DeleteAccount(int account_id);
    }
}
