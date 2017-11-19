using System.Collections.Generic;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Services.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();
    }
}