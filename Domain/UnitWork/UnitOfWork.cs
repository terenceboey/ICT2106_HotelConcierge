using _2106_Project.Data;
using _2106_Project.Domain.Interfaces;
using _2106_Project.Domain.Models;
using _2106_Project.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace _2106_Project.Domain.UnitWork
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Account> accountRepository;
        private IGenericRepository<Guest> guestRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Account> AccountRepository
        {
/*            get { return this.accountRepository ??= new GenericRepository<Account>(_context); }
*/            get
            {
                if (this.accountRepository == null)
                {
                    this.accountRepository = new GenericRepository<Account>(_context);
                }
                return accountRepository;
            }
        }

        public IGenericRepository<Guest> GuestRepository
        {
            get
            {
                if (this.guestRepository == null)
                {
                    this.guestRepository = new GenericRepository<Guest>(_context);
                }
                return guestRepository;
            }
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
