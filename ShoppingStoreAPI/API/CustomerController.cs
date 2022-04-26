using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingStoreAPI.DATA;

namespace ShoppingStoreAPI.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IShopService _iss;
        public CustomerController(IShopService iss)
        {
            _iss = iss;
        }

        // Get List of All Customers
        [HttpGet("Get List Of Cust")]
        public async Task<List<Customer>> GetCustList()
        {
            return await _iss.GetAllCustomers();
        }

        // Get a Customer by Id
        [HttpGet("GCID")] // this is for Query String in URL
        //[HttpGet("{id}")]
        public async Task<Customer> GetCustById(int id)
        {
            return await _iss.GetCustomerById(id);  
        }

        [HttpPost("AddCustomer")]
        public async Task<ActionResult<Customer>> PostCustomer(Customer cust)
        {
            var newCust = await _iss.AddCustomer(cust); // add into DB
            // return Action result 
            return CreatedAtAction(nameof(GetCustById), new { id = newCust.CustId}, newCust);
        }

        [HttpPut("put/{id}")] // edit your customer info
        public async Task<ActionResult> PutCustomer(int id, Customer editCust)
        {
            if (id != editCust.CustId)
            {
                return BadRequest();
            }
            else
            {
                await _iss.UpdateCustomer(editCust);
            }
            return NoContent();
        }

        [HttpDelete("delete_customer")]
        public async Task<ActionResult> DeleteCust(int id)
        {
            var cust = await _iss.GetCustomerById(id);
            if (cust != null)
            {
                await _iss.DeleteCustomer(id);
            }
            else
                NotFound();
            return NoContent();
        }

    }
}
