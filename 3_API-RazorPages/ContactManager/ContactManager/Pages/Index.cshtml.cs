using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManager.Domain;
using Microsoft.AspNetCore.Mvc;
using ContactManager.AppLogic.Contracts;


namespace ContactManager.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Contact> Contacts { get; set; }
        private readonly IContactRepository _contactRepository;

        public IndexModel(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void OnGet()
        {
            Contacts = _contactRepository.GetAllContacts();
        }
    }
}