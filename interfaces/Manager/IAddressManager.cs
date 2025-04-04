using models.Address;

namespace interfaces.Manager
{
    public interface IAddressManager
    {
        Task<Address> CreateAddress(CreateAddressRequest request);
        Task DeleteAddress(string addressId);
    }
}
