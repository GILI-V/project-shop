using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ICustomerBll
    {
        //get
        public Task<List<dto.customerDto>> SelectAll(string name, string email);

        //add
        public Task Add(dto.customerDto customer);

        //Delete
        public Task DeleteAsync(int id);
        
        //update
        public Task UpdateAsync(dto.customerDto customer);
    }
}
