using System.Collections.Generic;
using CompanySearcher.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompanySearcher.Api.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController: Controller
    {
        ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        // GET api/values
        public IActionResult Get()
        {
            var companies = _companyService.GetAll();
            return Ok(companies);
        } 
    }
}