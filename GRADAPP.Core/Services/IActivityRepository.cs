using System;
using System.Collections.Generic;
using GRADAPP.Core.Models;

namespace GRADAPP.Core.Services
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
        void Remove(Activity todo);
        // List
        IEnumerable<Activity> GetAll();
        IEnumerable<Activity> GetAllForUser(int familyId);
    }
}
