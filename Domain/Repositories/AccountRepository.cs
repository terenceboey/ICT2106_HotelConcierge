using _2106_Project.Data;
using _2106_Project.Domain.Interfaces;
using _2106_Project.Domain.Models;
using BCryptNet = BCrypt.Net.BCrypt;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2106_Project.Domain.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        public AccountRepository(ApplicationDbContext context) : base()
        {
            _context = context;
        }
        public void AddAccount(Account account)
        {
            if (account != null)
            {
                account.Password = BCryptNet.HashPassword(account.Password);
                _context.Accounts.Add(account);
                _context.SaveChanges();
            }
        }

        public Account CheckEmail(string email)
        {
            return _context.Accounts.SingleOrDefault(user => user.Email == email);
        }

        public void DeleteAccount(int account_id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Account GetAccountById(int account_id)
        {
            return _context.Accounts.Find(account_id);
        }

        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        public void UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }

    /*        public override async Task<IEnumerable<Account>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch ( Exception ex)
            {
                _logger.LogError(ex,"{Repo} All method error", typeof(AccountRepository));
            }
        }

        public override async Task<bool> Upsert(Account entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.account_id == entity.account_id).FirstOrDefaultAsync();

                if (existingUser == null)
                    return await Add(entity);

                existingUser.Email = entity.Email;
                existingUser.Password = entity.Password;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert method error", typeof(AccountRepository));
                return false;
            }
        }*/
}
