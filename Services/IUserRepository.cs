using System;
using System.Collections.Generic;
using GRADAPP.Core.Models;

namespace GRADAPP.Services
{
    public interface IUserRepository
    {
        // Create
        User Add(User todo);
        // Read
        User Get(int id);
        // Update
        User Update(User todo);
        // Delete
        void Remove(User todo);
        // List
        IEnumerable<User> GetAll();
    }
}
