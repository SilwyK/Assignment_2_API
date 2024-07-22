using Assignment_2_API.Models;

namespace Assignment_2_API.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerDto> GetAllCustomers();
        CustomerDto GetCustomerById(int id);
        void AddCustomer(CustomerDto customerDto);
        void UpdateCustomer(CustomerDto customerDto);
        void DeleteCustomer(int id);
    }
}
