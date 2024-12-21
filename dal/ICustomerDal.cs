using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public interface ICustomerDal

    {
        //Get
        Task<List<dto.customerDto>> SelectAll(string name, string email);

        //Delete
        Task DeleteAsync(int id);

        //Add
        Task Add(dto.customerDto customer);

        //update
        Task Update(dto.customerDto customer);


    }
}
