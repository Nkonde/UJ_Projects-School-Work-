using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class AppBookingController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();

        [HttpGet]
        public List<assignStylist> GetAssignStylists(string i)
        {
            var booking = (from b in db.assignStylists
                           select b);

            List<assignStylist> listBooking = new List<assignStylist>();

            foreach (assignStylist customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }


        [HttpGet]
        public List<Booking> getBookings(int bookingId)
        {
            var booking = (from b in db.Bookings
                           where b.Id.Equals(bookingId)
                           select b);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }

        [HttpGet]
        public List<AppStyle> Styles()
        {
            var styles = (from s in db.AppStyles
                          select s);

            List<AppStyle> itemStyles = new List<AppStyle>();

            foreach (AppStyle style in styles)
            {
                itemStyles.Add(style);
            }
            return itemStyles;
        }



        [HttpGet]
        public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId, int s)
        {
            var checkAppointment = (from b in db.Bookings
                                    where b.Date.Equals(date) && b.Time.Equals(time)
                                    select b).FirstOrDefault();

            if (checkAppointment == null)
            {
                Booking appointment = new Booking
                {
                    Service = service,
                    Date = date,
                    Time = time,
                    Status = status,//
                    Id = userId,
                    StylistID = s
                };
                db.Bookings.InsertOnSubmit(appointment);

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
