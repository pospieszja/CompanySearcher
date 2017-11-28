using System;

namespace CompanySearcher.Api.Models
{
    public class Log
    {
        public Guid Id { get; private set; }
        public DateTime Date { get; set; }
        public string Query { get; set; }
        public string UserAgent { get; set; }
        public Log(string query, string userAgent)
        {
            Id = Guid.NewGuid();
            Date = DateTime.UtcNow;
            Query = query;
            UserAgent = userAgent;
        }
    }
}