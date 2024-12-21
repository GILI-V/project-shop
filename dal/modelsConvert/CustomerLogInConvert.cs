using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.modelsConvert
{
    public class CustomerLogInConvert
    {
        public CustomerLogInConvert()
        {
            {

            }
        }
            public static dto.customerDto ToCustomerLogInDto(dal.models1.Customer c)
            {
                var cnew = new dto.customerDto();
                cnew.CustomerName = c.CustomerName;
                cnew.Email = c.Email;
                return cnew;
            }
            public static List<dto.customerDto> ToCustomerLogInDtoList(List<dal.models1.Customer> lac)
            {
                List<dto.customerDto> l = new List<dto.customerDto>();
                foreach (var customer in lac)
                { l.Add(ToCustomerLogInDto(customer)); }
                return l;
            }
            public static dal.models1.Customer ToCustomerLogIn(dto.customerDto c)
            {
                var customerNew = new dal.models1.Customer();
                customerNew.CustomerName = c.CustomerName;
                customerNew.CustomerCode = c.CustomerCode;
                customerNew.Phone = c.Phone;
                customerNew.Email = c.Email;
                return customerNew;

            }
        }
    }
