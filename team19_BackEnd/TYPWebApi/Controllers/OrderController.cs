using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class OrderController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();

        [HttpGet]
        public List<Order> GetOrders(string email)
        {
            var userOrders = (from o in db.Orders
                              where o.Email.Equals(email)
                              select o);

            List<Order> lisOrders = new List<Order>();

            foreach (Order order in userOrders)
            {
                lisOrders.Add(order);
            }
            return lisOrders;
        }


        [HttpGet]
        public int addOrder(string orderId, string email, decimal totalCosts, string receiptId)
        {
            Order od = new Order
            {
                OrderId = orderId,       
                Email = email,
                TotalCost = totalCosts,
                ReceiptId = receiptId
            };

            if (od == null) return -1;


            db.Orders.InsertOnSubmit(od);

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
    }
}
