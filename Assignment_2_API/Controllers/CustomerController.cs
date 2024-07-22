using Microsoft.AspNetCore.Mvc;
using Assignment_2_API.Models;
using Assignment_2_API.Interfaces;
using Assignment_2_API.Services;

namespace Assignment_2_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        [HttpGet("GetAllCustomers")]
        public ActionResult<List<CustomerDto>> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpGet("GetCustomerById/{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost("AddCustomer")]
        public ActionResult AddCustomer([FromBody] CustomerDto customerDto)
        {
            _customerService.AddCustomer(customerDto);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customerDto.Id }, customerDto);
        }

        [HttpPut("UpdateCustomerById/{id}")]
        public ActionResult UpdateCustomer(int id, [FromBody] CustomerDto customerDto)
        {
            if (id != customerDto.Id)
            {
                return BadRequest();
            }
            _customerService.UpdateCustomer(customerDto);
            return NoContent();
        }

        [HttpDelete("DeleteCustomerById/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}
