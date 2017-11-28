using System;
using System.Threading.Tasks;

namespace CompanySearcher.Api.Services.Interfaces
{
    public interface ILogService
    {
        Task Add(string method, string path, string queryString, string userAgent, string acceptLanguage, string host, string origin);
    }
}