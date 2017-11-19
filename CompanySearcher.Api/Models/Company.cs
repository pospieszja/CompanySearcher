using System;

namespace CompanySearcher.Api.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string KRS { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public Address Address { get; set; }
    }
}