using dal.models1;
using Dal.modelsConvert;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProductDal : IProductDal
    {

        //getProduct
        public async Task<List<dto.productDto>> SelectAllAsync()
        {
            using (Angular1Context db = new Angular1Context())
            {
                // שליפת כל המוצרים עם ה-CategoryCode
                var l = await db.Products
                                 .Select(p => new
                                 {
                                     p.ProductName,
                                     p.Price,
                                     CategoryCode = p.CategoryCodeNavigation.CategoryCode // גישה לשדה דרך הניווט
                                 })
                                 .ToListAsync();

                // המרת המידע שנשלף לאובייקטים מסוג dto.productDto
                var result = l.Select(p => new dto.productDto
                {
                    ProductName = p.ProductName,
                    Price = p.Price,
                    CategoryCode = p.CategoryCode // כאן אנחנו מעבירים את ה-CategoryCode מה-CategoryCodeNavigation
                }).ToList();

                return result; // מחזירים את הרשימה המומרת
            }


            throw new Exception("empty");
        }


        //Delete
        public async Task DeleteAsync(int id)
        {
            using (Angular1Context db = new Angular1Context())
            {
                var ac = await db.Products.FirstOrDefaultAsync(a => a.ProductCode == id);//שליפה מהמסד
                if (ac != null)
                {
                    db.Products.Remove(ac);
                    await db.SaveChangesAsync();
                }
            }
        }
        public async Task Add(dto.productDto product)
        {

            using (Angular1Context db = new Angular1Context())
            {
                var ac = db.Products.Add(modelsConvert.productConvert.ToProduct(product));
                await db.SaveChangesAsync();
            }
        }
        //ליצור פונרצייה של גאט והאד שקיימת לשנות אותה שתהיה לה בדיקה 


        //get product By category name
        public async Task<List<dto.customerDto>> SelectNameCategory(string? name)
        {
            using (var db = new Angular1Context())
            {
                var query = db.Customers.AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(c => c.CustomerName.ToLower() == name.ToLower());
                }


                return await query.Select(c => new dto.customerDto
                {
                    CustomerCode = c.CustomerCode,
                    CustomerName = c.CustomerName,
                })
                .ToListAsync();
            }
        }


    }
}


//public async Task UpdateAsync(int id, dto.productDto product)
//{
//    using (Angular1Context db = new Angular1Context())
//    {
//        var p = await db.Products.FirstOrDefaultAsync(a => a.ProductCode == id);

//        if (p != null)
//        {

//            p = modelsConvert.productConvert.ToProduct(product);
//            p.CompanyCode = product.CompanyCode;
//            p.ProductName = product.ProductName;
//            p.CategoryCode = product.CategoryCode;
//            p.ProductDescription = product.ProductDescription;
//            p.Price = product.Price;
//            p.LastUpdated = product.LastUpdated;


//            await db.SaveChangesAsync();
//        }

//    }
//}