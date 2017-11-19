using System;

namespace CompanySearcher.Api.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}