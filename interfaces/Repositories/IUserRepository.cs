using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Users;

namespace interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUser(string id);

        Task<User> CreateUser(User user);
        Task<User> PatchUser(User user);
    }
}
