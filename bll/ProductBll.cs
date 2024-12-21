using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ProductBll : IProductBll
    {


        private readonly Dal.IProductDal productDal;
        public ProductBll(IProductDal Dal)
        {
            productDal = Dal;
        }
        //get Product
        public async Task <List<dto.productDto>> SelectAll()
        {
            return await productDal.SelectAllAsync();
        }

        //delete Product
        public async Task DeleteAsync(int id)
        {
            await productDal.DeleteAsync(id);
        }
        //Insert Product
        public async Task Add(dto.productDto p)
        {
            Dal.ProductDal a = new Dal.ProductDal();
            await a.Add(p);
        }
  
        //get by category name
        public async Task<List<dto.productDto>> SelectNameCategory(string name)
        {
            return await productDal.SelectNameCategory(name);
        }
        //Update
        //public async Task UpdateAsync(int id, productDto p)
        //{
        //    Dal.ProductDal a = new Dal.ProductDal();
        //    await a.UpdateAsync(id, p);
        //}

    }
}
