using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Models.DTO;
using CompanySearcher.Api.Repositories.Interfaces;
using CompanySearcher.Api.Services.Interfaces;

namespace CompanySearcher.Api.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;
        private readonly IMapper _mapper;
        public CompanyService(ICompanyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CompanyViewModel> GetByCompanyCodeAsync(string companyCode)
        {
            companyCode = Regex.Replace(companyCode, @"[^0-9]", "");
            var company = await _repository.GetByCompanyCodeAsync(companyCode);
            return _mapper.Map<Company, CompanyViewModel>(company);
        }
    }
}