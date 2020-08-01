using System;
using System.Collections.Generic;
using GRADAPP.Core.Models;

namespace GRADAPP.Core.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;
        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public Activity Add(Activity Activity)
        {
            throw new NotImplementedException();
        }

        public Activity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAllForUser(int familyId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Activity Update(Activity Activity)
        {
            throw new NotImplementedException();
        }
    }
}
