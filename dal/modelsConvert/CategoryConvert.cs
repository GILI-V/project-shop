//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using dal.models1;
//using dto;
//namespace Dal.modelsConvert
//{
//    public class CategoryConvert
//    {
//        public static dto.categoryDto CategoryConvertDal(dal.models1.Category c)
//        {
//            dto.categoryDto pNew = new dto.categoryDto();
//            pNew.CategoryCode = c.CategoryCode;
//            pNew.CategoryName = c.CategoryName;
        

//            return pNew;

//        }
//        public static List<dto.categoryDto> CategoryConvertDalList(List<dal.models1.Category> p1)
//        {
//            List<dto.categoryDto> l = new List<dto.categoryDto>();
//            foreach (var category in p1)
//            {
//                l.Add(CategoryConvertDal(category));
//            }
//            return l;
//        }


//    //public static dal.models1.Category ToCategory(dto.categoryDto pr)
//    //{
//    //    dal.models1.Category r = new dal.models1.Category();
//    //    r.CategoryName = pr.CategoryName;
//    //    r.CategoryCode = pr.CategoryCode;

//    //    return r;
//    //}
//}
//}

