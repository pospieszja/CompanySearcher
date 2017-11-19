using System.Collections.Generic;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
    }
}