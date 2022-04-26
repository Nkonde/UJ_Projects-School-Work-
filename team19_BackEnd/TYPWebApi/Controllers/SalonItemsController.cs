using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class SalonItemsController : ApiController
    {

        DataClassesDataContext db = new DataClassesDataContext();

        /*[HttpGet]
        public List<SalonItem> GetLatestItem()
        {
            var items = (from i in db.SalonItems
                         select i).OrderByDescending(i => i.ItemId).Take(3);

            List<SalonItem> listItems = new List<SalonItem>();

            foreach (SalonItem item in items)
            {
                listItems.Add(item);
            }

            return listItems;
        }*/

        [HttpGet]
        public List<SalonItem> GetItemByCartegory(int categoryId)
        {
            var items = (from i in db.SalonItems
                         where i.CategoryId.Equals(categoryId)
                         select i);

            List<SalonItem> listItems = new List<SalonItem>();

            foreach (SalonItem item in items)
            {
                listItems.Add(item);
            }

            return listItems;
        }

       [HttpGet]
        public List<SalonItem> GetCategories()
        {
            var items = (from b in db.SalonItems
                              select b);

            List<SalonItem> listItems = new List<SalonItem>();

            foreach (SalonItem item in items)
            {
                listItems.Add(item);
            }

            return listItems;
        }

        [HttpGet]
        public int addCategery(string image, string name, string description, string rating, string ratingdetails, string homeselected, decimal price, int categoryId)
        {
            var checkCategory = (from u in db.SalonItems
                                 where u.Name.Equals(name)
                                 select u).FirstOrDefault();

            if (checkCategory == null)
            {
                SalonItem item = new SalonItem
                {
                    ImageUrl = image,
                    Name = name,
                    Description = description,
                    Rating = rating, 
                    RatingDetails = ratingdetails,
                    HomeSelected = homeselected,
                    Price = price, 
                    CategoryId = categoryId
                };
                db.SalonItems.InsertOnSubmit(item);

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
