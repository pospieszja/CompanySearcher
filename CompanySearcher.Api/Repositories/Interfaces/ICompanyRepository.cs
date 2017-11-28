using System.Threading.Tasks;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> GetByCompanyCodeAsync(string companyCode);
    }
}