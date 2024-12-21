using dal;
using dal.models1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.modelsConvert;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Dal
{
    public class CustomerDal : ICustomerDal
    {
        //מקבל שם ומייל

        //getCustomer
        public async Task<List<dto.customerDto>> SelectAll(string? name, string? email)
        {
            using (var db = new Angular1Context())
            {
                var query = db.Customers.AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(c => c.CustomerName.ToLower() == name.ToLower());
                }

                if (!string.IsNullOrEmpty(email))
                {
                    query = query.Where(c => c.Email.ToLower() == email.ToLower());
                }

                return await query.Select(c => new dto.customerDto
                {
                    CustomerCode = c.CustomerCode,
                    CustomerName = c.CustomerName,
                    Email = c.Email,
                })
                .ToListAsync();
            }
        }
        //var l = await db.Customers.ToListAsync();

        //return modelsConvert.CustomerConvert.ToCustomerDtoList(l);





        public async Task Add(dto.customerDto customer)
        {

            using (Angular1Context db = new Angular1Context())
            {
                var ac = db.Customers.Add(modelsConvert.CustomerConvert.ToCustomer(customer));
                await db.SaveChangesAsync();
            }

        }
        //Delete
        public async Task DeleteAsync(int id)
        {
            using (Angular1Context db = new Angular1Context())
            {
                var ac = await db.Customers.FirstOrDefaultAsync(a => a.CustomerCode == id);
                if (ac != null)
                {
                    db.Customers.Remove(ac);
                    await db.SaveChangesAsync();
                }
            }
        }
        //בתהליך עדיין לא עובד
        public async Task Update(dto.customerDto customer)
        {
            using (Angular1Context db = new Angular1Context())
            {
                var custom = await db.Customers.FirstOrDefaultAsync(a => a.CustomerCode == customer.CustomerCode);

                if (custom != null)
                {

                    custom = modelsConvert.CustomerConvert.ToCustomer(customer);
                    custom.Email = customer.Email;
                    custom.CustomerName = customer.CustomerName;
                    custom.Phone = customer.Phone;
                    custom.BirthDate = customer.BirthDate;
                    await db.SaveChangesAsync();
                    //return customer;
                    //var flag = true;
                    //return flag;
                }//שלחתי לכם תג
                 //return null;
                 //throw new Exception("האדם לא נמצא");


            }
        }
    }
}

//AddCustomer

//בדיקה שלא קיים אדם עם המייל והשם 


//Register
//public async Task<User> AddUserAsync(User u)
//{

//    if (_dbSale.Users.Any(x => x.UserEmail == u.UserEmail && x.UserPassword == u.UserPassword))
//    {
//        throw new Exception("כבר נמצא כזה אדם");
//    }
//    else
//    {
//        await _dbSale.Users.AddAsync(u);
//        await this._dbSale.SaveChangesAsync();

//        Order o = new Order();
//        o.OrderDate = new DateTime();
//        var currentUser = _dbSale.Users.FirstOrDefault(o => o.UserEmail.ToLower() ==
//        u.UserEmail.ToLower() && o.UserPassword == u.UserPassword);
//        o.UserId = currentUser.UserId;
//        await _dbSale.Orders.AddAsync(o);
//        await _dbSale.SaveChangesAsync();

//        Console.WriteLine($"User {u.UserFirstName + ' ' + u.UserLastName} Created");
//        return u;
//    }
//}
