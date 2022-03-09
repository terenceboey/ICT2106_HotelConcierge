using _2106_Project.Data;
using _2106_Project.Domain.Interfaces;
using _2106_Project.Domain.Models;
using System.Collections.Generic;

namespace _2106_Project.Domain.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly ApplicationDbContext _context;

        public GuestRepository(ApplicationDbContext context) : base()
        {
            _context = context;
        }

        public void AddGuest(Guest guest)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteGuest(int account_id)
        {
            throw new System.NotImplementedException();
        }
        public List<Guest> GetAllGuest()
        {
            throw new System.NotImplementedException();
        }

        public Guest GetGuestByAccountId(int account_id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateGuest(Guest guest)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
