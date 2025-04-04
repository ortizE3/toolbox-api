using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Address;
using models.Users;

namespace interfaces.Manager
{
    public interface IUserManager
    {
        Task<User?> GetUser(string id);
        Task<User> CreateUser(CreateUserRequest createUserRequest);
        Task<User> PatchUser(User user);
    }
}
