using _2106_Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _2106_Project.Domain.Interfaces
{
    public interface IAccountRepository : IDisposable
    {
        List<Account> GetAllAccounts();
        Account GetAccountById(int account_id);
        Guid AddAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(int account_id);
        Account CheckEmail(string email);
    }
}
