using System.Threading.Tasks;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Repositories.Interfaces
{
    public interface ILogRepository
    {
        Task AddAsync(Log log);
    }
}