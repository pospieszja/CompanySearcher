using System;

namespace CompanySearcher.Api.Models
{
    public class Company
    {
        public Guid Id { get; private set; }
        public string KRS { get; private set; }
        public string NIP { get; private set; }
        public string REGON { get; private set; }
        public Address Address { get; private set; }
    }
}