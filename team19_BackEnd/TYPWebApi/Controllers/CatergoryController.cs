using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class CatergoryController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();
        
        [HttpGet]
        public List<Category> GetCategories()
        {
            var categories = (from b in db.Categories
                            select b);

            List<Category> listCategory = new List<Category>();

            foreach (Category category in categories)
            {
                listCategory.Add(category);
            }

            return listCategory;
        }

        [HttpGet]
        public int addCategery(string name, string poster, string image)
        {
            var checkCategory = (from u in db.Categories
                                where u.CategoryName.Equals(name)
                                select u).FirstOrDefault();

            if (checkCategory == null)
            {
                Category category = new Category
                {
                    CategoryName = name, 
                    CategoryPoster = poster,
                    ImageUrl = image
                };
                db.Categories.InsertOnSubmit(category);

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
