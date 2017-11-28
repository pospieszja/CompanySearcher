using System.Threading.Tasks;
using CompanySearcher.Api.Data;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Repositories.Interfaces;

namespace CompanySearcher.Api.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly ApplicationDbContext _context;
        public LogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Log log)
        {
            _context.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}