using Assignment_2_API.Models;
using AutoMapper;
using Assignment_2_API.Interfaces;


namespace Assignment_2_API.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepo _customerRepo;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepo customerRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
        }

        public List<CustomerDto> GetAllCustomers()
        {
            var customers = _customerRepo.GetAllCustomers();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public CustomerDto GetCustomerById(int id)
        {
            var customer = _customerRepo.GetCustomerById(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public void AddCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerRepo.AddCustomer(customer);
        }

        public void UpdateCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerRepo.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepo.DeleteCustomer(id);
        }
    }
}

