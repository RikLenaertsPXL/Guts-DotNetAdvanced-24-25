using ContactManager.AppLogic.Contracts;
using ContactManager.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Infrastructure
{
    internal class CompanyDbRepository : ICompanyRepository
    {
        private readonly ContactManagerDbContext _context;

        public CompanyDbRepository(ContactManagerDbContext contactManagerDbContext)
        {
            _context = contactManagerDbContext;
        }

        public void AddCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public IList<Company> GetAllCompanies()
        {
            return _context.Companies.ToList();
        }
    }
}
