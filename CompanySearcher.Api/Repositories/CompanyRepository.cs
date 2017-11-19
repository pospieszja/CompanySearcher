using System.Collections.Generic;
using CompanySearcher.Api.Data;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CompanySearcher.Api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Company> GetAll()
        {
            return _context.Companies.Include(e=>e.Address);
        }
    }
}