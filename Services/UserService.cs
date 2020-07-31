using System;
namespace GRADAPP.Services
{
    public class UserService : IUserService

    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
    }
}
