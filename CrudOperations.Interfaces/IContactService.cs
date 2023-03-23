using CrudOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.Interfaces
{
    public interface IContactService
    {
        Task AddContact(Contact contact);
        Task DeleteContact(Guid id);
        Task<Contact?> GetContact(Guid id);
        Task<List<Contact>> GetContactDetails();
        Task UpdateContact(Guid id, Contact contact);
    }
}
