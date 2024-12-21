using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IProductBll
    {
        //get
        public Task<List<dto.productDto>> SelectAll();

        //delete
        public Task DeleteAsync(int id);

        //add
        public Task Add(dto.productDto product);

        //add category
        public Task<List<dto.productDto>> SelectNameCategory(string name);

        //update
        //public Task UpdateAsync(int id, dto.productDto p);
    }
}
