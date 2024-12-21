using Bll;
using dal;
using Dal;
using dto;
using Microsoft.AspNetCore.Mvc;

namespace project_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBll CustomerBll;

        public CustomerController(ICustomerBll bll)
        {
            CustomerBll = bll;
        }
        //get all Customer
        [HttpGet]
        public async Task<List<dto.customerDto>> Get(string name, string email)
        {
            List<customerDto> lisCustomerDto = await CustomerBll.SelectAll(name, email);
            if (lisCustomerDto != null)
            {
                return lisCustomerDto;
            }
            throw new Exception("אין נתונים להחזרה");
        }
        //add Customer

        [HttpPost]
        public async Task Post(dto.customerDto p)
        {
            Dal.CustomerDal ac = new Dal.CustomerDal();
            await ac.Add(p);
        }

        //delete Customer
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await CustomerBll.DeleteAsync(id);
            return NoContent();
        }
        //update Customer
        [HttpPut]
        public async Task Put( dto.customerDto customer)
        {
            Dal.CustomerDal ac = new Dal.CustomerDal();
            await ac.Update(customer);
        }
    }
}
