using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IProductDal
    {
        //Get
        Task<List<dto.productDto>> SelectAllAsync();

        //Delete
        Task DeleteAsync(int id);

        //Add
        Task Add(dto.productDto product);
        //add by category name
        Task<List<dto.productDto>> SelectNameCategory(string? name);

        //Update
        //Task Update(int id, dto.productDto product);

    }
}
