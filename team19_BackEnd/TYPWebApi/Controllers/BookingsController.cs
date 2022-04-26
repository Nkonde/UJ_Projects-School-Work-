using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class BookingsController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();


<<<<<<< HEAD

        [HttpGet]
        public int  getCanc(int Cid)
        {
            var f = (from c in db.Bookings
                    where c.BookingId.Equals(Cid)
                    select c).FirstOrDefault();

            
=======
        [HttpGet]
        public int getCanc(int Cid)
        {
            var f = (from c in db.Bookings
                     where c.BookingId.Equals(Cid)
                     select c).FirstOrDefault();


>>>>>>> 2CC

            //If user does not exist
            if (f == null)
                return -1;


            f.Status = "Cancelled";



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
        public List<Booking> getByUserID(int getByUserID)
        {
            var bookings = (from b in db.Bookings
                            where b.Id.Equals(getByUserID)
                            select b);

            List<Booking> listBookings = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                listBookings.Add(booking);
            }

            return listBookings;
        }

        [HttpGet]
        public List<Booking> getBook()
        {
            var bookings = (from b in db.Bookings
                            select b);

            List<Booking> listBookings = new List<Booking>();

            foreach (Booking booking in bookings)
            {
                listBookings.Add(booking);
            }

            return listBookings;
        }

        [HttpGet]
        public Boolean removeAppointment(int bookingID)
        {
            var bookExists = (from book in db.Bookings
<<<<<<< HEAD
                             
=======

>>>>>>> 2CC
                              select book).FirstOrDefault();

            if (bookExists == null)
            {
                return false;
            }

            db.Bookings.DeleteOnSubmit(bookExists);

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
      
=======

>>>>>>> 2CC



        [HttpGet]
        public List<Booking> HistoryAppointments(int userappointID)
        {
            var booking = (from u in db.Bookings
                           where u.Status.Equals("Completed") && u.Id.Equals(userappointID)
<<<<<<< HEAD
                           select u) ;
=======
                           select u);
>>>>>>> 2CC
            List<Booking> reports = new List<Booking>();

            foreach (Booking book in booking)
            {
                reports.Add(book);
            }
            return reports;
        }

        [HttpGet]
        public Stylist getStylist(int styleID)
        {
            var booking = (from u in db.Stylists
                           where u.Id.Equals(styleID)
                           select u).FirstOrDefault();
            return booking;
        }



        [HttpGet]
        public Stylist getStylist(string styleName)
        {
            var booking = (from u in db.Stylists
<<<<<<< HEAD
                           where u.Style_Name.Equals(styleName) 
=======
                           where u.Style_Name.Equals(styleName)
>>>>>>> 2CC
                           select u).FirstOrDefault();
            return booking;
        }


<<<<<<< HEAD
        public List<Booking> BookingList(int userIDget,int bookingID)
        {
            var booking = (from u in db.Bookings
                           where u.Id.Equals(userIDget)&& u.BookingId.Equals(bookingID)
=======
        public List<Booking> BookingList(int userIDget, int bookingID)
        {
            var booking = (from u in db.Bookings
                           where u.Id.Equals(userIDget) && u.BookingId.Equals(bookingID)
>>>>>>> 2CC
                           select u);
            List<Booking> reports = new List<Booking>();

            foreach (Booking book in booking)
            {
                reports.Add(book);
            }
            return reports;
        }

        [HttpGet]
        public int updateAppoint(DateTime date, TimeSpan time, string service, int id)
        {

            var getAppoint = (from u in db.Bookings
                              where u.BookingId.Equals(id)
                              select u).FirstOrDefault();

            //If user does not exist
            if (getAppoint == null)
                return -1;


            getAppoint.Date = date;
            getAppoint.Time = time;
            getAppoint.Service = service;


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

<<<<<<< HEAD
        

        [HttpGet]
        public List<Booking> getBookingList(int userIDget) 
=======


        [HttpGet]
        public List<Booking> getBookingList(int userIDget)
>>>>>>> 2CC
        {
            var booking = (from u in db.Bookings
                           where u.Id.Equals(userIDget)
                           select u);
            List<Booking> reports = new List<Booking>();

<<<<<<< HEAD
            foreach(Booking book in booking)
=======
            foreach (Booking book in booking)
>>>>>>> 2CC
            {
                reports.Add(book);
            }
            return reports;
        }

        [HttpGet]
<<<<<<< HEAD
        public Booking getBookings(int userId,string name)
=======
        public Booking getBookings(int userId, string name)
>>>>>>> 2CC
        {
            var booking = (from u in db.Bookings
                           where u.Id.Equals(userId) && u.Service.Equals(name)
                           select u).FirstOrDefault();
            //List<Booking> reports = new List<Booking>();


            return booking;
        }



        [HttpGet]
        public Item getStyle(string itemName)
        {
            var Hairstyle = (from b in db.Items
<<<<<<< HEAD
                                    where b.Name.Equals(itemName)
                                    select b).FirstOrDefault();
=======
                             where b.Name.Equals(itemName)
                             select b).FirstOrDefault();
>>>>>>> 2CC

            return Hairstyle;
        }

        //[HttpGet]
        //public Stylist get




        [HttpGet]
        public int bookAppointment(string style, DateTime date, TimeSpan time, string status, int userId)
        {
            var checkAppointment = (from b in db.Bookings
                                    where b.Date.Equals(date) && b.Time.Equals(time)
                                    select b).FirstOrDefault();

            if (checkAppointment == null)
            {
                Booking appointment = new Booking
                {
<<<<<<< HEAD
                    Service=style,
=======
                    Service = style,
>>>>>>> 2CC
                    Date = date,
                    Time = time,
                    Status = status,
                    Id = userId,

<<<<<<< HEAD
                   
=======

>>>>>>> 2CC
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
