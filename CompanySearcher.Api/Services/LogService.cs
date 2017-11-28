using System;
using System.Threading.Tasks;
using CompanySearcher.Api.Models;
using CompanySearcher.Api.Repositories.Interfaces;
using CompanySearcher.Api.Services.Interfaces;

namespace CompanySearcher.Api.Services
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _repository;

        public LogService(ILogRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(string query, string userAgent)
        {
            var log = new Log(query, userAgent);
            await _repository.Add(log);
        }
    }
}