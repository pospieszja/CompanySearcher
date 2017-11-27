using System;

namespace CompanySearcher.Api.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; private set; }
        public string KRS { get; private set; }
        public string NIP { get; private set; }
        public string REGON { get; private set; }
        public Address Address { get; private set; }

        protected Company()
        {

        }
        
        public Company(string name, string krs, string nip, string regon, Address address)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetKRS(krs);
            SetNIP(nip);
            SetREGON(regon);
            Address = address;
        }

        private void SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name can't be empty.");
            }

            Name = name;
        }

        private void SetKRS(string krs)
        {
            if (String.IsNullOrWhiteSpace(krs))
            {
                throw new Exception("KRS can't be empty.");
            }

            KRS = krs;
        }

        private void SetNIP(string nip)
        {
            if (String.IsNullOrWhiteSpace(nip))
            {
                throw new Exception("NIP can't be empty.");
            }

            NIP = nip;
        }

        private void SetREGON(string regon)
        {
            if (String.IsNullOrWhiteSpace(regon))
            {
                throw new Exception("REGON can't be empty.");
            }

            REGON = regon;
        }
    }
}