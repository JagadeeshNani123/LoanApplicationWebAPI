using LoanEMIServiceReference;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanApplicationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanEMIController : ControllerBase
    {
        LoanEMIServiceClient lesc= new LoanEMIServiceClient();
        // GET: api/<LoanEMIController>
        [HttpGet]
        public LoanEMIModel[]? GetAllCustomerList()
        {
            LoanEMIModel[]? loanEMIList = null;
            try
            {
                loanEMIList = lesc.GetAllLoansEMIsAsync().Result;
            }
            catch
            {

            }
            return loanEMIList;
        }
        // GET api/<LoanEMIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoanEMIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoanEMIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoanEMIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
