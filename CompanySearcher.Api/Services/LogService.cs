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

        public async Task Add(string method, string path, string queryString, string userAgent, string acceptLanguage, string host, string origin)
        {
            var log = new Log(method, path, queryString, userAgent, acceptLanguage, host, origin);
            await _repository.AddAsync(log);
        }
    }
}