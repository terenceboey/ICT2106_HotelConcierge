using _2106_Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace _2106_Project.Domain.Interfaces
{
    public interface IGuestRepository : IDisposable
    {
        List<Guest> GetAllGuest();
        Guest GetGuestByAccountId(int account_id);
        void AddGuest(Guest guest);
        void UpdateGuest(Guest guest);
        void DeleteGuest(int account_id);
    }
}
