using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CompanySearcher.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompaniesSearcher.Api.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ILogService _logService;
        public CompaniesController(ICompanyService companyService, ILogService logService)
        {
            _companyService = companyService;
            _logService = logService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]string companyCode)
        {
            if (string.IsNullOrWhiteSpace(companyCode))
            {
                return NotFound();
            }
            var company = await _companyService.GetByCompanyCodeAsync(companyCode);
            await _logService.Add(companyCode, Request.Headers["User-Agent"], Request.Path.ToString());

            if (company == null)
            {
                return NotFound();
            }
            return Json(company);
        }
    }
}