using System.Collections.Generic;
using System.Threading.Tasks;
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

        [HttpGet("{companyCode}")]
        public async Task<IActionResult> Get(string companyCode)
        {
            var company = await _companyService.GetByCompanyCodeAsync(companyCode);
            if (company == null)
            {
                return NotFound();
            }

            return Json(company);
        }        
    }
}