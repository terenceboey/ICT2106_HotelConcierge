using _2106_Project.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace _2106_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Account> Accounts { get; private  set; }
        public virtual DbSet<Guest> Guests { get; private set; }
        public virtual DbSet<Staff> Staffs { get; private set; }
        public virtual DbSet<Hotel> Hotels { get; private set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
