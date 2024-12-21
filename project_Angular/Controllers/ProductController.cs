using Bll;
using dal.models1;
using Dal;
using dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace project_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBll productBll;

        public ProductController(IProductBll bll)
        {
            productBll = bll;
        }

        //get all product
        [HttpGet("GetAllProduct")]
        public async Task<List<dto.productDto>> Get()
        {
            List<productDto> lisProdtDto = await productBll.SelectAll();

            if (lisProdtDto != null)
            {
                return lisProdtDto;
            }
            throw new Exception("אין נתונים להחזרה");
        }
        //add product
        [HttpPost]
        public async Task Post(dto.productDto p)
        {
            Dal.ProductDal ac = new Dal.ProductDal();
            await ac.Add(p);
        }
        //update product
        //[HttpPut]
        //public async Task Put(int id, dto.productDto p)
        //{
        //    Dal.ProductDal ac = new Dal.ProductDal();
        //    await ac.UpdateAsync(id, p);
        //}

        //delete product
        [HttpDelete("productCode")]
        public async Task<IActionResult> Delete(int productCode)
        {
            await productBll.DeleteAsync(productCode);
            return NoContent(); 
        }
        //get all Customer
        [HttpGet]
        public async Task<List<dto.productDto>> Get(string name)
        {
            List<productDto> lisProdtDto = await productBll.SelectNameCategory(name);
            if (lisProdtDto != null)
            {
                return lisProdtDto;
            }
            throw new Exception("אין נתונים להחזרה");
        }

    }
}

