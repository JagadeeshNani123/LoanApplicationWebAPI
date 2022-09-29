using Microsoft.AspNetCore.Mvc;
using CustomerServiceReference;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanApplicationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerServiceController : ControllerBase
    {
        CustomerServiceClient customerClient = new CustomerServiceClient();
        // GET: api/<CustomerServiceController>
        [HttpGet]
        public CustomerModel[]? GetAllCustomerList()
        {
            CustomerModel[]? customerList = null;
            try
            {
                customerList = customerClient.GetAllCustomersAsync().Result;
            }
            catch
            {

            }
            return customerList;
        }

        // GET api/<CustomerServiceController>/5
        [HttpGet("{id}")]
        public CustomerModel? GetCustomerById(Guid id)
        {
            var customer = customerClient.GetCustomerByIdAsync(id).Result;
            return customer;
        }

        // POST api/<CustomerServiceController>
        [HttpPost]
        public string AddCustomer(CustomerModel customer)
        {
            var message = "failed to add customer";
            try
            {
                customerClient.AddCustomerAsync(customer);
                message = "added customer";
            }
            catch
            {

            }
            return message;
        }

        // PUT api/<CustomerServiceController>/5
        [HttpPut("{id}")]
        public string Put(CustomerModel customer, Guid Id)
        {
            var message = "failed to update customer";
            try
            {
                customerClient.UpdateCustomerAsync(customer, Id);
                message = "updated customer";
            }
            catch
            {

            }
            return message;
        }

        // DELETE api/<CustomerServiceController>/5
        [HttpDelete("{id}")]
        public string Delete(Guid id)
        {
            var message = "failed to delete customer";
            try
            {
                customerClient.DeleteCustomerAsync(id);
                message = "deleted customer";
            }
            catch
            {

            }
            return message;
        }
    }
}
