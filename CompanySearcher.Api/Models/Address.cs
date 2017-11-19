using System;

namespace CompanySearcher.Api.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; private set; }
        public string StreetNumber { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }
    }
}