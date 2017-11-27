using System.Collections.Generic;
using System.Threading.Tasks;
using CompanySearcher.Api.Data;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CompanySearcher.Api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Company> GetByCompanyCodeAsync(string companyCode)
        {
            return _context.Companies
                    .Include(e=>e.Address)
                    .SingleOrDefaultAsync(x=>x.KRS == companyCode || x.NIP == companyCode || x.REGON == companyCode);
        }
    }
}