using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.modelsConvert
{
    public class PurchaseConvert
    {
        public PurchaseConvert() { }
        public static Dto.PurchaseDto ToPurchaseDto(dal.models1.Purchase c)
        {
            var cnew = new Dto.PurchaseDto();
            cnew.PurchaseCode = c.PurchaseCode;
            cnew.CustomerCode = c.CustomerCode;
            cnew.PurchaseDate = c.PurchaseDate;
            cnew.TotalAmount = c.TotalAmount;
            cnew.Notes = c.Notes;
            return cnew;
        }
        public static List<Dto.PurchaseDto> ToPurchaseDtoList(List<dal.models1.Purchase> lac)
        {
            List<Dto.PurchaseDto> l = new List<Dto.PurchaseDto>();
            foreach (var purchase in lac)
            { l.Add(ToPurchaseDto(purchase)); }
            return l;
        }
        public static dal.models1.Purchase ToPurchase(Dto.PurchaseDto c)
        {
            var PurchaseNew = new dal.models1.Purchase();
            PurchaseNew.PurchaseCode = c.PurchaseCode;
            PurchaseNew.PurchaseDate = c.PurchaseDate;
            PurchaseNew.TotalAmount = c.TotalAmount;
            PurchaseNew.CustomerCode = c.CustomerCode;
            PurchaseNew.Notes=c.Notes;
            return PurchaseNew;

        }
    }
}
