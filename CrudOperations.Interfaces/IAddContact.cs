﻿using CrudOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.Interfaces
{
    public interface IAddContact
    {
        Task AddContact(Contact contact);
    }
}
