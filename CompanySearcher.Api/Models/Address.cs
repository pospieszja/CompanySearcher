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

        protected Address()
        {

        }
        
        public Address(string street, string streetNumber, string city, string postalCode)
        {
            Id = Guid.NewGuid();
            SetStreet(street);
            SetStreetNumber(streetNumber);
            SetPostalCode(postalCode);
            SetCity(city);
        }

        private void SetStreet(string street)
        {
            if (String.IsNullOrWhiteSpace(street))
            {
                throw new Exception("Street can't be empty.");
            }

            Street = street;
        }

        private void SetStreetNumber(string streetNumber)
        {
            if (String.IsNullOrWhiteSpace(streetNumber))
            {
                throw new Exception("StreetNumber can't be empty.");
            }

            StreetNumber = streetNumber;
        }

        private void SetPostalCode(string postalCode)
        {
            if (String.IsNullOrWhiteSpace(postalCode))
            {
                throw new Exception("PostalCode can't be empty.");
            }

            PostalCode = postalCode;
        }     

        private void SetCity(string city)
        {
            if (String.IsNullOrWhiteSpace(city))
            {
                throw new Exception("City can't be empty.");
            }

            City = city;
        }             
    }
}