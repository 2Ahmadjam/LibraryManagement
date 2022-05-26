using KitapYonetim.Common.EF;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.API.Common.EF;

namespace KitapYonetim.Common.Context
{
    public class KYDbContext : DbContext
    {
       
        public KYDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
