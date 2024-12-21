
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Dal.modelsConvert

{
    public class CustomerConvert
    { 
        public CustomerConvert() { }
        public static dto.customerDto ToCustomerDto(dal.models1.Customer c)
        {
            var cnew = new dto.customerDto();
            cnew.BirthDate = c.BirthDate;
            cnew.CustomerName = c.CustomerName;
            cnew.CustomerCode = c.CustomerCode;
            cnew.Phone = c.Phone;
            cnew.Email = c.Email;
            return cnew;
        }
        public static List<dto.customerDto> ToCustomerDtoList(List<dal.models1.Customer> lac)
        {
            List<dto.customerDto> l = new List<dto.customerDto>();
            foreach (var customer in lac)
            { l.Add(ToCustomerDto(customer)); }
            return l;
        }
        public static dal.models1.Customer ToCustomer(dto.customerDto c)
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
