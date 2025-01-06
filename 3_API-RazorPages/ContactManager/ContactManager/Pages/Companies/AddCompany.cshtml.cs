using ContactManager.AppLogic.Contracts;
using ContactManager.Domain;
using ContactManager.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManager.Pages.Companies
{
    public class AddCompanyModel : PageModel
    {
        [BindProperty]
        public Company Company { get; set; }

        private readonly ICompanyRepository _companyRepository;

        public AddCompanyModel(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
            Company = new Company();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _companyRepository.AddCompany(Company);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
