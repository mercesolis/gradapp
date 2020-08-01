using System;
using System.Collections.Generic;
using GRADAPP.Core.Models;

namespace GRADAPP.Core.Services
{
    public class FamilyService : IFamilyService
    {
        private readonly IFamilyRepository _familyRepository;
        public FamilyService(IFamilyRepository familyRepository)
        {
            _familyRepository = familyRepository;
        }

        public Family Add(Family family)
        {
            throw new NotImplementedException();
        }

        public Family Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Family> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Family Update(Family family)
        {
            throw new NotImplementedException();
        }
    }
}
