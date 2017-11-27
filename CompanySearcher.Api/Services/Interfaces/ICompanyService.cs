using System.Collections.Generic;
using System.Threading.Tasks;
using CompanySearcher.Api.Models.DTO;

namespace CompanySearcher.Api.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<CompanyViewModel> GetByCompanyCodeAsync(string companyCode);
    }
}