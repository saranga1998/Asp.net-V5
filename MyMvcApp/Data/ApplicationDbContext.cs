using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<BookModel> Books { get; set; }

        public DbSet<CustomerModel> Customers {get; set;}

        public DbSet<CustomerBookModel> CustomerBooks {get; set;}
    }
}