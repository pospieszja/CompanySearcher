using System;
using System.Collections.Generic;
using System.Linq;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Data
{
    public class DbInitializer : IDbInitializer
    {
        ApplicationDbContext _context;
        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (!_context.Companies.Any())
            {
                var address = new Address("Postępu", "14", "Warszawa", "02-676");
                var company = new Company("SAMSUNG ELECTRONICS POLSKA SP Z O O", "128080", "5261044039", "11612810", address);
                _context.Companies.Add(company);

                address = new Address("Wołoska 22", "22", "Warszawa", "02-675");
                company = new Company("LG ELECTRONICS POLSKA SP Z O O", "121072", "521-22-14-808", "12449587", address);
                _context.Companies.Add(company);

                address = new Address("Ogrodowa", "58", "Warszawa", "00-876");
                company = new Company("SONY EUROPE LIMITED (SP Z O O) ODDZIAŁ W POLSCE", "377489", "108-00-10-359", "142798947", address);
                _context.Companies.Add(company);                

                _context.SaveChanges();
            }
        }
    }
}