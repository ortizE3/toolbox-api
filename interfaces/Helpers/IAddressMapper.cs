using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Address;

namespace interfaces.Helpers
{
    public interface IAddressMapper
    {
        Address MapToAddress(CreateAddressRequest request);
    }
}
