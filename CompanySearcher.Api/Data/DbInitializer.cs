using System;
using System.Collections.Generic;
using System.Linq;
using CompanySearcher.Api.Models;

namespace CompanySearcher.Api.Data
{
    public class DbInitializer: IDbInitializer
    {
        ApplicationDbContext _context;
        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if(!_context.Companies.Any())
            {
                var address = new Address(){
                    City = "Warsaw", Street="Marszałkowska", StreetNumber="143/7", PostalCode="00-500"
                };

                var companies = new List<Company>() {
                    new Company {Id = Guid.NewGuid(), Name = "Company1234", KRS = "1234KRS", REGON ="1234REGON",NIP="1234NIP", Address = address  },
                    new Company {Id = Guid.NewGuid(), Name = "Company4567", KRS = "4567KRS", REGON ="4567REGON",NIP="4567NIP", Address = address  }
                };

                _context.Companies.AddRange(companies);
                _context.SaveChanges();
                }
            }
        }
    }