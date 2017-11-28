using System;

namespace CompanySearcher.Api.Models
{
    public class Log
    {
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public string Method { get; private set; }
        public string Path { get; private set; }
        public string QueryString { get; private set; }
        public string UserAgent { get; private set; }
        public string AcceptLanguage { get; private set; }
        public string Host { get; private set; }
        public string Origin { get; private set; }

        protected Log()
        {

        }
        
        public Log(string method, string path, string queryString, string userAgent, string acceptLanguage, string host, string origin)
        {
            Id = Guid.NewGuid();
            Date = DateTime.UtcNow;
            Method = method;
            Path = path;
            QueryString = queryString;
            UserAgent = userAgent;
            AcceptLanguage = acceptLanguage;
            Host = host;
            Origin = origin;
        }
    }
}