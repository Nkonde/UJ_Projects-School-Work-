using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class stockController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();



        [HttpGet]
        public int addStyle(string name,string description,double price,string supplier,int avaiblestock, int soldstock, int onspecial,string image,int Status,int capacity,double stockPrice)
        {
            Stock stock = new Stock
            {
                Name = name,
                Description=description,
                Price= (decimal)price,
                Supplier=supplier,
                AvaibleStock= avaiblestock,
                Sold= soldstock,
                onSpecial=onspecial,
                Img=image,
                status = Status,
                maxAmountStock=capacity,
                stockprice = (decimal)stockPrice,
          

            };

            if (stock == null) return -1;

            db.Stocks.InsertOnSubmit(stock);

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
        public List<Stock> getSock()
        {

            var allitems = (from U in db.Stocks select U);
            List<Stock> reports = new List<Stock>();

            foreach (Stock item in allitems)
            {
                reports.Add(item);
            }
            return reports;
        }

        [HttpGet]
        public Stock getStock(int id)
        {
            var user = (from u in db.Stocks
                        where u.Id.Equals(id)
                        select u).FirstOrDefault();

            return user;
        }


        [HttpGet]
        public int updateStock(String SId, String quantity)
        {
            Stock updateorders = (from u in db.Stocks
                              where u.Id.Equals(SId)
                              select u).FirstOrDefault();

            if (updateorders == null) return -1;



            updateorders.Id = string.IsNullOrEmpty(SId) ? updateorders.Id : int.Parse(SId);
            updateorders.AvaibleStock = string.IsNullOrEmpty(quantity) ? updateorders.AvaibleStock : int.Parse(quantity);

           
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
        public int deleteStock(String SId, String status, string name )
        {
            Stock updateorders = (from u in db.Stocks
                                  where u.Id.Equals(SId)
                                  select u).FirstOrDefault();

            if (updateorders == null) return -1;



            updateorders.Id = string.IsNullOrEmpty(SId) ? updateorders.Id : int.Parse(SId);
            updateorders.status = string.IsNullOrEmpty(status) ? updateorders.status : int.Parse(status);
            updateorders.Name = string.IsNullOrEmpty(name) ? updateorders.Name : name;

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
        public int editUser(String name,  String descrip, String price,String Sprice, String images, String supplier,String Storage,String Special, int userID)
        {
            Stock user = (from u in db.Stocks
                              where u.Id.Equals(userID)
                              select u).FirstOrDefault();

            if (user == null) return -1;

            user.Name = string.IsNullOrEmpty(name) ? user.Name : name;
            user.Description = string.IsNullOrEmpty(descrip) ? user.Description : descrip;
            user.Price = string.IsNullOrEmpty(price) ? user.Price : Decimal.Parse(price);
            user.stockprice = string.IsNullOrEmpty(Sprice) ? user.stockprice : Decimal.Parse(Sprice);
            user.Img = string.IsNullOrEmpty(images) ? user.Img : images;
            user.Supplier = string.IsNullOrEmpty(supplier) ? user.Supplier : supplier;
            user.maxAmountStock = string.IsNullOrEmpty(Storage) ? user.status : int.Parse(Storage);
            user.onSpecial = string.IsNullOrEmpty(Special) ? user.onSpecial : int.Parse(Special);
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
    }
}
