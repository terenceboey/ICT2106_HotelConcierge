using _2106_Project.Domain.Models;
using System;
using System.Threading.Tasks;

namespace _2106_Project.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable

    {
        IGenericRepository<Account> AccountRepository { get; }
        IGenericRepository<Guest> GuestRepository { get; }

        void Save();
    }
}
