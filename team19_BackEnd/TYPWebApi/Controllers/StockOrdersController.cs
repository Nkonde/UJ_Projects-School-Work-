using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class StockOrdersController : ApiController
    {

        DataClassesDataContext db = new DataClassesDataContext();

        [HttpGet]
        public StockingOrder getSyle(int id)
        {
            var orders = (from u in db.StockingOrders
                        where u.Id.Equals(id)
                        select u).FirstOrDefault();

            return orders;
        }

        [HttpGet]
        public int buyStock(string name, string supplier, double price, int qty, int status, int IDstock,int notify,int adminNoti)
        {
            StockingOrder stock = new StockingOrder
            {
                Name_ = name,
                Price_ = (decimal)price,
                Supplier = supplier,
                OderDate = DateTime.Now,
                QTY = qty,
                Status = status,
                stockID=IDstock,
                notification=notify,
                userNotif=adminNoti,

            };

            if (stock == null) return -1;
            db.StockingOrders.InsertOnSubmit(stock);
          
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
        public int updateStock(String SId, String status, string notify, string adminNoti)
        {
            StockingOrder updateorders = (from u in db.StockingOrders
                                  where u.Id.Equals(SId)
                                  select u).FirstOrDefault();

            if (updateorders == null) return -1;



            updateorders.Id = string.IsNullOrEmpty(SId) ? updateorders.Id : int.Parse(SId);
            updateorders.Status = string.IsNullOrEmpty(status) ? updateorders.Status : int.Parse(status);
            updateorders.notification = string.IsNullOrEmpty(notify) ? updateorders.notification : int.Parse(notify);
            updateorders.userNotif = string.IsNullOrEmpty(adminNoti) ? updateorders.userNotif : int.Parse(adminNoti);
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
        public List<StockingOrder> getSock()
        {

            var allitems = (from U in db.StockingOrders select U);
            List<StockingOrder> reports = new List<StockingOrder>();

            foreach(StockingOrder item in allitems)
            {
                reports.Add(item);
            }
            return reports;
        }


    }
}
