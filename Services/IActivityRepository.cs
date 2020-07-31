using System;
using System.Collections.Generic;
using GRADAPP.Core.Models;

namespace GRADAPP.Services
{
    public interface IActivityRepository
    {
        // Create
        Activity Add(Activity todo);
        // Read
        Activity Get(int id);
        // Update
        Activity Update(Activity todo);
        // Delete
        void Remove(User todo);
        // List
        IEnumerable<Activity> GetAll();
    }
}
