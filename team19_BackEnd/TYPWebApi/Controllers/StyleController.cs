using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class StyleController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();

        [HttpGet]
        public int addStyle(String name, double price, String descrip, String tyope, String images, int stat)
        {
            ItemStyle hair = new ItemStyle
            {
                hairstyleName = name,
                price_ = (decimal)price,
                hairstyledescription_ = descrip,
                hairsyleType = tyope,
                status = stat,
                img = images,

            };

            if (hair == null) return -1;

            db.ItemStyles.InsertOnSubmit(hair);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
            return 1;
        }
        [HttpGet]
        public ItemStyle getSyle(int id)
        {
            var user = (from u in db.ItemStyles
                        where u.Id.Equals(id)
                        select u).FirstOrDefault();

            return user;
        }

        [HttpGet]
        public int editUser(String name, string price, String descrip, String tyope, String images, String stat, int userID)
        {
            ItemStyle user = (from u in db.ItemStyles
                              where u.Id.Equals(userID)
                              select u).FirstOrDefault();

            if (user == null) return -1;

            user.hairstyleName = string.IsNullOrEmpty(name) ? user.hairstyleName : name;
            user.price_ = string.IsNullOrEmpty(price) ? user.price_ : Decimal.Parse(price);
            user.hairstyledescription_ = string.IsNullOrEmpty(descrip) ? user.hairstyledescription_ : descrip;
            user.hairsyleType = string.IsNullOrEmpty(tyope) ? user.hairsyleType : tyope;
            user.img = string.IsNullOrEmpty(images) ? user.img : images;
            user.status = string.IsNullOrEmpty(stat) ? user.status : int.Parse(stat);




            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }

            return 1;
        }

        [HttpGet]
        public User getStylistInfo(int UserStylistID)
        {
            var user = (from u in db.Users
                        where u.Id.Equals(UserStylistID)
                        select u).FirstOrDefault();


            return user;
        }

        [HttpGet]
        public User getStylistByName(string UserStylistName)
        {
            var user = (from u in db.Users
                        where u.Name.Equals(UserStylistName)
                        select u).FirstOrDefault();

            return user;
        }


        [HttpGet]
        public List<assignStylist> getStylistList(int styleListID)
        {

            var getStylist = (from U in db.assignStylists
                              where U.Stylee.Equals(styleListID)
                              select U);
            List<assignStylist> reports = new List<assignStylist>();

            foreach (assignStylist item in getStylist)
            {
                reports.Add(item);
            }
            return reports;
        }


        [HttpGet]
        public List<ItemStyle> getActiveitems()
        {

            var allitems = (from U in db.ItemStyles select U);
            List<ItemStyle> reports = new List<ItemStyle>();

            foreach (ItemStyle item in allitems)
            {
                reports.Add(item);
            }
            return reports;
        }

        public int updateStock(String name, string price, String descrip, String tyope, String images, String stat, int userID)
        {
            ItemStyle user = (from u in db.ItemStyles
                              where u.Id.Equals(userID)
                              select u).FirstOrDefault();

            if (user == null) return -1;

            user.hairstyleName = string.IsNullOrEmpty(name) ? user.hairstyleName : name;
            user.price_ = string.IsNullOrEmpty(price) ? user.price_ : Decimal.Parse(price);
            user.hairstyledescription_ = string.IsNullOrEmpty(descrip) ? user.hairstyledescription_ : descrip;
            user.hairsyleType = string.IsNullOrEmpty(tyope) ? user.hairsyleType : tyope;
            user.img = string.IsNullOrEmpty(images) ? user.img : images;
            user.status = string.IsNullOrEmpty(stat) ? user.status : int.Parse(stat);


<<<<<<< HEAD
=======


            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }

            return 1;
        }

<<<<<<< HEAD
=======
        [HttpGet]
        public List<ItemStyle> topFive(int s,int x)
        {

            var Styless = db.Bookings
                                   .GroupBy(q => q.Id)
                                   .OrderByDescending(gp => gp.Count())
                                   .Take(5)
                                   .Select(g => g.Key).ToList();
           // var allitems = (from U in db.ItemStyles select U);
            List<ItemStyle> reports = new List<ItemStyle>();

            System.Collections.IList list = Styless;
            for (int i = 0; i < list.Count; i++)
            {
                ItemStyle item = (ItemStyle)list[i];
                reports.Add(item);
            }
            return reports;
        }

       
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a

<<<<<<< HEAD
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
=======

            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }

            return 1;
        }
>>>>>>> 2CC
    }
}
