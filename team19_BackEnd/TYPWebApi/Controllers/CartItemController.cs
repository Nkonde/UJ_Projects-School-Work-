using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class CartItemController : ApiController
    {
<<<<<<< HEAD
        DataClassesDataContext db = new DataClassesDataContext();


<<<<<<< HEAD



=======
>>>>>>> 2CC
        [HttpGet]
        public bool remove(int well,int tell,int userID)
        {
            var ItemExists = (from book in db.CARTs
                              where book.U_ID.Equals(userID)
                              select book).FirstOrDefault();

            if (ItemExists == null)
            {
                return false;
            }

            db.CARTs.DeleteOnSubmit(ItemExists);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }



<<<<<<< HEAD
        [HttpGet]
        public bool removeFromCart(int ItemCartID)
        {
            var ItemExists = (from book in db.CARTs
                              where book.Item_ID.Equals(ItemCartID)
                              select book).FirstOrDefault();

            if (ItemExists == null)
            {
                return false;
            }

            db.CARTs.DeleteOnSubmit(ItemExists);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }



        [HttpGet]
        public List<double?> PurchaseItems(int valu,int quality, int itemIdentity, int userCartId)
        {

            var stockLeft = (from u in db.Stocks
                             where u.Id.Equals(itemIdentity)
                             select u).Select(s => s.maxAmountStock - quality);

            var item = (from u in db.Stocks
                        where u.Id.Equals(itemIdentity)
                        select u).FirstOrDefault();

            List<double?> amount = new List<double?>();
            foreach (double? left in stockLeft)
            {
                amount.Add(left);
            }
            //int left = item.AvaibleStock-quality;

            try
            {
				db.SubmitChanges();
			}
			catch (Exception ex)
			{
				ex.GetBaseException();
				return null;
			}

			return amount;	

        }



        [HttpGet]
        public int updateQuality(int quality, int itemIdentity, int userCartId)
        {
=======
<<<<<<< HEAD
=======
>>>>>>> 2CC
        [HttpGet]
        public bool removeFromCart(int ItemCartID)
        {
            var ItemExists = (from book in db.CARTs
                              where book.Item_ID.Equals(ItemCartID)
                              select book).FirstOrDefault();

            if (ItemExists == null)
            {
                return false;
            }

            db.CARTs.DeleteOnSubmit(ItemExists);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }



=======
<<<<<<< HEAD
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
        [HttpGet]
        public List<double?> PurchaseItems(int valu,int quality, int itemIdentity, int userCartId)
        {
<<<<<<< HEAD

            var stockLeft = (from u in db.Stocks
                             where u.Id.Equals(itemIdentity)
                             select u).Select(s => s.maxAmountStock - quality);

            var item = (from u in db.Stocks
                        where u.Id.Equals(itemIdentity)
                        select u).FirstOrDefault();

            List<double?> amount = new List<double?>();
            foreach (double? left in stockLeft)
            {
                amount.Add(left);
            }
            //int left = item.AvaibleStock-quality;

            try
            {
				db.SubmitChanges();
			}
			catch (Exception ex)
			{
				ex.GetBaseException();
				return null;
			}

			return amount;	

=======
          //  var cn 
            return 0; 
=======
        DataClassesDataContext db = new DataClassesDataContext();


        [HttpGet]
        public bool removeFromCart(int ItemCartID)
        {
            var ItemExists = (from book in db.CARTs
                              where book.Item_ID.Equals(ItemCartID)
                              select book).FirstOrDefault();

            if (ItemExists == null)
            {
                return false;
            }

            db.CARTs.DeleteOnSubmit(ItemExists);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
>>>>>>> 376d0bbe6a0ede1b84ca03da818317e6b21a1baa
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
        }



<<<<<<< HEAD
        [HttpGet]
        public int updateQuality(int quality, int itemIdentity, int userCartId)
        {

            var getAppoint = (from u in db.CARTs
                              where u.Item_ID.Equals(itemIdentity) && u.U_ID.Equals(userCartId)
                              select u).FirstOrDefault();

            //If user does not exist
            if (getAppoint == null)
                return -1;


            getAppoint.ItemQuality = quality;

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -2;
            }

        }
        [HttpGet]
        public List<CART> GetCateItems(int cartUserID)
        {
=======
  //      [HttpGet]
  //      public List<double?> PurchaseItems(int valu,int quality, int itemIdentity, int userCartId)
  //      {

  //          var stockLeft = (from u in db.Stocks
  //                           where u.Id.Equals(itemIdentity)
  //                           select u).Select(s => s.maxAmountStock - quality);


		////	return ;	

  //      }



        [HttpGet]
        public int updateQuality(int quality, int itemIdentity, int userCartId)
        {
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5

            var getAppoint = (from u in db.CARTs
                              where u.Item_ID.Equals(itemIdentity) && u.U_ID.Equals(userCartId)
                              select u).FirstOrDefault();

            //If user does not exist
            if (getAppoint == null)
                return -1;


            getAppoint.ItemQuality = quality;

            try
            {
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -2;
            }

        }
        [HttpGet]
        public List<CART> GetCateItems(int cartUserID)
        {
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
            var items = (from b in db.CARTs
                         where b.U_ID.Equals(cartUserID)
                         select b);

            List<CART> listItems = new List<CART>();

            foreach (CART item in items)
            {
                listItems.Add(item);
            }

            return listItems;
<<<<<<< HEAD
        }

        [HttpGet]
        public int countCartItems(int value1, int value2, int UserID)
        {
            var countBooking = (from c in db.CARTs
                                where c.U_ID.Equals(UserID)
                                select c).Select(c => c.U_ID).Count();

            return countBooking;
        }

        [HttpGet]
        public Stock getCartItem(int itemID)
        {
            var CartItem = (from b in db.Stocks
                             where b.Id.Equals(itemID)
                             select b).FirstOrDefault();

            return CartItem;
=======
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
        }

        [HttpGet]
        public int countCartItems(int value1, int value2, int UserID)
        {
            var countBooking = (from c in db.CARTs
                                where c.U_ID.Equals(UserID)
                                select c).Select(c => c.U_ID).Count();

            return countBooking;
        }

        [HttpGet]
<<<<<<< HEAD
        private bool CartExist(int value, int u_Card_id)
        {
            var checkusercart = (from c in db.CARTs
                                 where c.U_ID.Equals(u_Card_id)
                                 select c).FirstOrDefault();

            return checkusercart == null;
        }

        [HttpGet]
        public int AddToCart(int userID, int ItemID)
        {
=======
        public Stock getCartItem(int itemID)
        {
            var CartItem = (from b in db.Stocks
                             where b.Id.Equals(itemID)
                             select b).FirstOrDefault();

            return CartItem;
        }


        [HttpGet]
        private bool CartExist(int value, int u_Card_id)
        {
            var checkusercart = (from c in db.CARTs
                                 where c.U_ID.Equals(u_Card_id)
                                 select c).FirstOrDefault();

            return checkusercart == null;
        }

        [HttpGet]
        public int AddToCart(int userID, int ItemID)
        {
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5

            var check = (from u in db.CARTs
                         where u.U_ID.Equals(userID) && u.Item_ID.Equals(ItemID)
                         select u).FirstOrDefault();


            if (check == null)
            {

                var Additem = new CART
                {
                    C_Amount = 0,
                    C_Date = DateTime.Today,
                    U_ID = userID,
                    Item_ID = ItemID,//
                    ItemQuality = 1,
                    C_Status = "Active"
                };
                db.CARTs.InsertOnSubmit(Additem);

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
                return -3;
            }


        }
    }


}
