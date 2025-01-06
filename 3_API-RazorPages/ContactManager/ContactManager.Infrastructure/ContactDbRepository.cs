using ContactManager.AppLogic.Contracts;
using ContactManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Infrastructure
{
    internal class ContactDbRepository:IContactRepository
    {
        private readonly ContactManagerDbContext _context;

        public ContactDbRepository(ContactManagerDbContext contactManagerDbContext)
        {
            _context = contactManagerDbContext;
        }

        public IList<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }
        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }
    }
}
