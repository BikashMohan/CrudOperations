using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.Interfaces
{
    public interface IDeleteContact
    {
        Task DeleteContact(Guid id);
    }
}
