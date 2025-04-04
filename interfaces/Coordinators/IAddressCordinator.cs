using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Address;

namespace interfaces.Coordinators
{
    public interface IAddressCordinator
    {
        Task PatchUserAddress(string userId, CreateAddressRequest request);
        Task DeleteUserAddress(string userId);
    }
}
