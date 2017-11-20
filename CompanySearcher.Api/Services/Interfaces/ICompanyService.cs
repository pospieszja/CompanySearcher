using System.Collections.Generic;
using System.Threading.Tasks;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<Company> GetByCompanyCodeAsync(string companyCode);
    }
}