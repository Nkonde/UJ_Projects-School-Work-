using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class OrderDetailsController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();

        [HttpGet]
        public List<OrderDetail> GetOrdersDetails(string orderId)
        {
            var userOrders = (from o in db.OrderDetails
                              where o.OrderId.Equals(orderId)
                              select o);

            List<OrderDetail> lisOrders = new List<OrderDetail>();

            foreach (OrderDetail order in userOrders)
            {
                lisOrders.Add(order);
            }
            return lisOrders;
        }


        [HttpGet]
        public int addOrderDetails(string orderDetailId, string orderId, int productId, string productName, int quantity, decimal price)
        {
            OrderDetail od = new OrderDetail
            {
                OrderDetailId = orderDetailId,
                OrderId = orderId,
                ProductId = productId,
                ProductName = productName,
                Quantity = quantity,
                Price = price
            };

            if (od == null) return -1;


            db.OrderDetails.InsertOnSubmit(od);

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
