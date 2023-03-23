using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.Interfaces
{
    public interface IContactService : IAddContact, IUpdateContact, IGetContacts, IDeleteContact, IGetContact
    {
    }
}
