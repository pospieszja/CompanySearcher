using System.Data.SqlClient;
using CompanySearcher.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanySearcher.Api.Data
{
    public class ApplicationDbContext: DbContext
    {    
        public DbSet<Company> Companies { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}