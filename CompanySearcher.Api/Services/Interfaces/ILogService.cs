using System;
using System.Threading.Tasks;

namespace CompanySearcher.Api.Services.Interfaces
{
    public interface ILogService
    {
        Task Add(string query, string userAgent);
    }
}