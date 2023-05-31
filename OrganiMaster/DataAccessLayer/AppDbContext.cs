using Microsoft.EntityFrameworkCore;
using OrganiMaster.DataAccessLayer.Entities;
using OrganiMaster.ViewModels;

namespace OrganiMaster.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
