using ContactManager.AppLogic.Contracts;
using ContactManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace ContactManager.Pages.Contacts
{
    public class AddContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public List<SelectListItem> CompanySelectListItems { get; set; }

        private readonly ICompanyRepository _companyRepository;
        private readonly IContactRepository _contactRepository;

        public AddContactModel(ICompanyRepository companyRepository, IContactRepository contactRepository)
        {
            _companyRepository = companyRepository;
            _contactRepository = contactRepository;
            CompanySelectListItems = new List<SelectListItem>();
            Contact = new Contact();
            SelectListItem firstItem = new SelectListItem();
            firstItem.Value = "";
            firstItem.Text = "Select a company";
            CompanySelectListItems.Add(firstItem);
            foreach (Company c in companyRepository.GetAllCompanies())
            {
                SelectListItem s = new SelectListItem();
                s.Text = c.Name;
                s.Value = c.Id.ToString();
                CompanySelectListItems.Add(s);
            }
        }

        public void OnGet()
        { 
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _contactRepository.AddContact(Contact);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
