using CrudOperations.Interfaces;
using CrudOperations.Models;
using CrudOperations.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.Service
{
    public class ContactService : IContactService
    {
        private readonly ContactDBcontext _contactDBcontext;

        public ContactService(ContactDBcontext contactDBcontext)
        {
            this._contactDBcontext = contactDBcontext;
        }

        public async Task AddContact(Contact contact)
        {
            contact.Id = Guid.NewGuid();
            await _contactDBcontext.Contacts.AddAsync(contact);
            await _contactDBcontext.SaveChangesAsync();
        }

        public async Task DeleteContact(Guid id)
        {
            var contactToBeDeleted = _contactDBcontext.Contacts.Find(id);
            if (contactToBeDeleted != null)
            {
                _contactDBcontext.Contacts.Remove(contactToBeDeleted);
                await _contactDBcontext.SaveChangesAsync();
            }
        }

        public async Task<Contact?> GetContact(Guid id)
        {
            var contact = await _contactDBcontext.Contacts.FindAsync(id);
            return await Task.FromResult(contact);
        }

        public async Task<List<Contact>> GetContactDetails()
        {
            var contactDetails = await _contactDBcontext.Contacts.ToListAsync();
            return await Task.FromResult(contactDetails); 
        }         

        public async Task UpdateContact(Guid id, Contact contact)
        {
            var specificContact = _contactDBcontext.Contacts.Find(id);
            if (specificContact != null)
            {
                specificContact.Name = contact.Name;
                specificContact.Email = contact.Email;
                specificContact.Phone = contact.Phone;
                specificContact.Address = contact.Address;

                await _contactDBcontext.SaveChangesAsync();
            }
        }
    }
}
