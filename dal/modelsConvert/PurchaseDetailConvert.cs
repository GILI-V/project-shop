using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.modelsConvert
{
    internal class PurchaseDetailConvert
    {
        public PurchaseDetailConvert()
        {
           
        }
        public static Dto.PurchaseDetailDto ToCustomerLogInDto(dal.models1.PurchaseDetail c)
        {
            var cnew = new Dto.PurchaseDetailDto();
            cnew.PurchaseDetailCode = c.PurchaseDetailCode;
            cnew.PurchaseCode = c.PurchaseCode;
            cnew.ProductCode= c.ProductCode;
            cnew.Quantity= c.Quantity;
            return cnew;
        }
        public static List<Dto.PurchaseDetailDto> ToCustomerLogInDtoList(List<dal.models1.PurchaseDetail> lac)
        {
            List<Dto.PurchaseDetailDto> l = new List<Dto.PurchaseDetailDto>();
            foreach (var purchaseDetail in lac)
            { l.Add(ToCustomerLogInDto(purchaseDetail)); }
            return l;
        }
        public static dal.models1.PurchaseDetail ToCustomerLogIn(Dto.PurchaseDetailDto c)
        {
            var PurchaseDetailNew = new dal.models1.PurchaseDetail();
            PurchaseDetailNew.PurchaseDetailCode = c.PurchaseDetailCode;
            PurchaseDetailNew.ProductCode = c.ProductCode;
            PurchaseDetailNew.PurchaseCode = c.PurchaseCode;
            PurchaseDetailNew.Quantity = c.Quantity;

            return PurchaseDetailNew
                
                ;

        }
    }

}
