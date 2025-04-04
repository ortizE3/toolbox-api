using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Address;

namespace interfaces.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> CreateAddress(Address newAddress);
        Task DeleteAddress(string addressId);
    }
}
