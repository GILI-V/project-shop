using dal.models1;
using dto;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.modelsConvert
{
    internal class productConvert
    {
        public productConvert()
        {

        }
        public static dto.productDto ProductConvertDal(dal.models1.Product p)
        {
            var pNew = new dto.productDto();
            pNew.ProductName = p.ProductName;
            pNew.ProductDescription = p.ProductDescription;
            pNew.ProductCode = p.ProductCode;
            pNew.CategoryCode = p.CategoryCode;
            pNew.CompanyCode = p.CompanyCode;
            pNew.Price = p.Price;
            pNew.LastUpdated = DateTime.Now;


            return pNew;

        }
        public static List<dto.productDto> ProductConvertDalLust(List<dal.models1.Product> p1)
        {
            List<dto.productDto> l = new List<dto.productDto>();
            foreach (var product in p1)
            {
                l.Add(ProductConvertDal(product));
            }
            return l;
        }


        public static dal.models1.Product ToProduct(dto.productDto pr)
        {
            dal.models1.Product r = new dal.models1.Product();
            r.ProductName = pr.ProductName;
            r.ProductDescription = pr.ProductDescription;
            r.ProductCode = pr.ProductCode;
            r.CategoryCode = pr.CategoryCode;
            r.CompanyCode = pr.CompanyCode;
            r.Price = pr.Price;
            r.LastUpdated = DateTime.Now;
            return r;
        }

        public static List<productDto> ToproductDto(List<dal.models1.Product> products)
        {


            return products.Select(pr => new productDto
            {
                ProductCode = pr.ProductCode,
                ProductName = pr.ProductName,
                CategoryCode = pr.CategoryCode,
                CompanyCode = pr.CompanyCode,
                ProductDescription = pr.ProductDescription,
                Price = pr.Price,
                LastUpdated = pr.LastUpdated//,
                //CategoryName = pr.Category?.CategoryName // אם הקטגוריה יכולה להיות null
            }).ToList();
        }



    }
}
