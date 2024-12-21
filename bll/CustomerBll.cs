using dal;
using dal.models1;
using Dal;
using dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CustomerBll: ICustomerBll
    {
      


        private readonly dal.ICustomerDal customerDal;
        public CustomerBll(ICustomerDal dal)
        {
            customerDal = dal;
        }
        //get
        public async Task<List<dto.customerDto>> SelectAll(string name, string email)
        {
            return await customerDal.SelectAll( name,  email);
        }
        //insert
        public async Task Add(dto.customerDto customer)
        {
            await customerDal.Add(customer);
        }
        //delete
        public async Task DeleteAsync(int id)
        {

            await customerDal.DeleteAsync(id);

        }
        //update

        public async Task UpdateAsync(customerDto customer)
        {
            await customerDal.Update(customer);

        }
        //Insert Product
        //public async Task Add(dto.customerDto p)
        //{
        //    Dal.CustomerDal a = new Dal.CustomerDal();
        //    await a.Add(p);
        //}
    }
}
