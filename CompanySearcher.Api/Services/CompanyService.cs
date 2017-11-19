using System.Collections.Generic;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Repositories.Interfaces;
using CompanySearcher.Api.Services.Interfaces;

namespace CompanySearcher.Api.Services
{
    public class CompanyService : ICompanyService
    {
        ICompanyRepository _repository;
        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Company> GetAll()
        {
            return _repository.GetAll();
        }
    }
}