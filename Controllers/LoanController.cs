using CustomerServiceReference;
using LoanServiceReference;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanApplicationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        LoanServiceClient loanClient = new LoanServiceClient();
        // GET: api/<LoanController>
        [HttpGet]
        public LoanModel[]? GetAllCustomerList()
        {
            LoanModel[]? loanList = null;
            try
            {
                loanList = loanClient.GetAllLoansAsync().Result;
            }
            catch
            {

            }
            return loanList;
        }

        // GET api/<LoanController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoanController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
