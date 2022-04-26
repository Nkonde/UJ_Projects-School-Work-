using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class BookingController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();

<<<<<<< HEAD
<<<<<<< HEAD
        [HttpGet]
        public List<TimeSlot> getAppHistory(int allTime)
        {
            var booking = (from b in db.TimeSlots
                           select b);

            List<TimeSlot> listBooking = new List<TimeSlot>();

            foreach (TimeSlot customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }



=======
=======
>>>>>>> 2CC

>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
        [HttpGet]
        public List<Booking> getAppHistory(int zoo, int zaa, int bookingId)
        {
            var booking = (from b in db.Bookings
                           where b.Id.Equals(bookingId) && b.Status.Equals("Completed")
                           select b);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }

        [HttpGet]
        public int updateAppointment(DateTime date, TimeSpan time, string service, int id)
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

        [HttpGet]
        public bool removeAppointment(int appointmentID)
        {
            var bookExists = (from book in db.Bookings
                              where book.BookingId.Equals(appointmentID)
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

        [HttpGet]
        public int countBooking(string status)
        {
            var countBooking = (from c in db.Bookings
                                where c.Status.Equals(status)
                                select c).Select(c => c.Status).Count();

            return countBooking;
        }

=======
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5

        [HttpGet]
        public List<Booking> getAppHistory(int zoo, int zaa, int bookingId)
        {
            var booking = (from b in db.Bookings
                           where b.Id.Equals(bookingId) && b.Status.Equals("Completed")
                           select b);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }


<<<<<<< HEAD

=======
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
        [HttpGet]
        public int countWaitingApp(int employeeID)
        {
            var countBooking = (from c in db.Bookings
                                where c.Status.Equals("Waiting") && c.StylistID.Equals(employeeID)
                                select c).Select(c => c.BookingId).Count();

            return countBooking;
        }

<<<<<<< HEAD


        [HttpGet]
        public List<Booking> getMyBookings(int bookingId, int ClientBooking)
        {
            var booking = (from b in db.Bookings
                           where b.Id.Equals(bookingId) && b.Status.Equals("Waiting")
                           select b);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }


=======
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
        [HttpGet]
        public int checkAppTime(TimeSpan time)
        {
<<<<<<< HEAD
            var booking = (from b in db.Bookings
                           where b.StylistID.Equals(bookingId) && b.Status.Equals("Waiting")
                           select b);
=======
            //String format = "AM";
            if (time >= new TimeSpan(08, 00, 00) && time <= new TimeSpan(16, 30, 00))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5


           [HttpGet]
            public int updateAppointment(DateTime date, TimeSpan time, string service, int id)
            {

                var getAppoint = (from u in db.Bookings
                                  where u.BookingId.Equals(id)
                                  select u).FirstOrDefault();

                //If user does not exist
                if (getAppoint == null)
                    return -1;

            if (checkDay(date) == 6)
            {
                return 8;
            }
            else if (checkAppTime(time) == 10)
            {
                return 11;
            }
            else { 

                    getAppoint.Date = date;
                    getAppoint.Time = time;
                    getAppoint.Service = service;

<<<<<<< HEAD

        [HttpGet]
        public Booking getStylistBookings(int bookingId,TimeSpan time,DateTime date, int robet)
        {
            var booking = (from b in db.Bookings
                           where b.StylistID.Equals(bookingId) && b.Time.Equals(time) && b.Date.Equals(date)
                           select b).FirstOrDefault();
            if (booking == null)
                return null;

            return booking;
        }


        [HttpGet]
        public List<Booking> getBook()
        {
            var bookings = (from b in db.Bookings
                            where !b.Status.Equals("Completed") && !b.Status.Equals("Cancelled")
                            select b);
=======
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5

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
            foreach (Booking booking in bookings)
=======
            }

            [HttpGet]
            public bool removeAppointment(int appointmentID)
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
            {
                var bookExists = (from book in db.Bookings
                                  where book.BookingId.Equals(appointmentID)
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

            [HttpGet]
            public int countBooking(string status)
            {
                var countBooking = (from c in db.Bookings
                                    where c.Status.Equals(status)
                                    select c).Select(c => c.Status).Count();

<<<<<<< HEAD

        [HttpGet]
        public int checkDay(DateTime date)
        {
            DayOfWeek value = date.DayOfWeek;

            if (value == DayOfWeek.Sunday || value == DayOfWeek.Saturday)
            {

                return 6;
            }
            else
            {
                return 7;
            }
        }

        [HttpGet]
        public int checkAppTime(TimeSpan time)
        {
            //String format = "AM";
            if (time >= new TimeSpan(08, 00, 00) && time <= new TimeSpan(16, 30, 00))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }


        [HttpGet]
        public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId,int stylistID)
=======
                return countBooking;
            }

<<<<<<< HEAD

        [HttpGet]
        public List<TimeSlot> getAppHistory(int allTime)
        {
            var booking = (from b in db.TimeSlots
                           select b);

            List<TimeSlot> listBooking = new List<TimeSlot>();

            foreach (TimeSlot customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }




        [HttpGet]
<<<<<<< HEAD
        public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId, int s)
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
=======
        public List<Booking> getAppHistory(int zoo, int zaa, int bookingId)
        {
            var booking = (from b in db.Bookings
                           where b.Id.Equals(bookingId) && b.Status.Equals("Completed")
                           select b);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }

        [HttpGet]
        public int updateAppointment(DateTime date, TimeSpan time, string service, int id)
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

        [HttpGet]
        public bool removeAppointment(int appointmentID)
        {
            var bookExists = (from book in db.Bookings
                              where book.BookingId.Equals(appointmentID)
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

        [HttpGet]
        public List<Booking> getMyBookings(int bookingId, int ClientBooking)
        {
            var booking = (from b in db.Bookings
                           where b.Id.Equals(bookingId) && b.Status.Equals("Waiting")
                           select b);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }


        [HttpGet]
        public Booking getStylistBookings(int bookingId,TimeSpan time,DateTime date, int robet)
        {
            var booking = (from b in db.Bookings
                           where b.StylistID.Equals(bookingId) && b.Time.Equals(time) && b.Date.Equals(date)
                           select b).FirstOrDefault();
            if (booking == null)
                return null;

            return booking;
        }


        [HttpGet]
        public int checkDay(DateTime date)
        {
            DayOfWeek value = date.DayOfWeek;

            if (value == DayOfWeek.Sunday || value == DayOfWeek.Saturday)
            {

                return 6;
            }
            else
            {
                return 7;
            }
        }

        [HttpGet]
        public int checkAppTime(TimeSpan time)
        {
            //String format = "AM";
            if (time >= new TimeSpan(08, 00, 00) && time <= new TimeSpan(16, 30, 00))
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }


=======
<<<<<<< HEAD
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
        [HttpGet]
        public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId,int stylistID)
>>>>>>> 2CC
        {
            var checkAppointment = (from b in db.Bookings
                                    where b.Date.Equals(date) && b.Time.Equals(time)
                                    select b).FirstOrDefault();
=======
>>>>>>> 376d0bbe6a0ede1b84ca03da818317e6b21a1baa

<<<<<<< HEAD
            if (checkDay(date) == 6)
            {
                return 8;
            }
<<<<<<< HEAD
=======
            else if (checkAppTime(time) == 10)
            {
                return 11;
            }else {

>>>>>>> 2CC
                if (checkAppointment == null)
=======
            [HttpGet]
            public int editStatus(string status, int bookingId)
            {
<<<<<<< HEAD
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
=======
                var user = (from b in db.Bookings
                            where b.BookingId.Equals(bookingId)
                            select b).FirstOrDefault();
>>>>>>> 376d0bbe6a0ede1b84ca03da818317e6b21a1baa

                user.Status = status;
                try
<<<<<<< HEAD
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
=======
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
>>>>>>> 2CC
                {
                    Booking appointment = new Booking
                    {
                        Service = service,
                        Date = date,
                        Time = time,
                        Status = status,//
                        Id = userId,
                        StylistID=stylistID
                     
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
<<<<<<< HEAD
                else
=======
                catch (IndexOutOfRangeException ex)
<<<<<<< HEAD
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
=======
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
>>>>>>> 2CC
                {
                    return 0;
                }
            
        }
        /// <summary>
        /// //
        /// </summary>
        /// <param name="complete"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Booking> GETcOMPLTE(string complete)
        {
            var booking = (from c in db.Bookings
                                where c.Status.Equals(complete)
                                select c);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }
<<<<<<< HEAD
        }
        /// <summary>
        /// //
        /// </summary>
        /// <param name="complete"></param>
        /// <returns></returns>
        

        [HttpGet]
        public List<Booking> getActiveitems(int x, int y ,int thanabi)
        {

            var allitems = (from U in db.Bookings select U);
            List<Booking> reports = new List<Booking>();

            foreach (Booking item in allitems)
            {
                reports.Add(item);
            }
            return reports;
        }

=======

<<<<<<< HEAD
            return listBooking;
        }

        [HttpGet]
        public List<Booking> GETBookings(int AllBookings,int userID)
        {
            var booking = (from c in db.Bookings
                           where c.StylistID.Equals(userID)
                           select c);

            List<Booking> listBooking = new List<Booking>();

            foreach (Booking customers in booking)
            {
                listBooking.Add(customers);
            }

            return listBooking;
        }

        [HttpGet]
        public int countBookings(int power, int tent,int userID)
        {
            var countBooking = (from c in db.Bookings
                                where c.Status.Equals("Completed") && c.StylistID.Equals(userID)
                                select c).Select(c => c.BookingId).Count();

            return countBooking;
        }

        //[HttpGet]
        //public int countBooking(string status)
        //{
        //    var countBooking = (from c in db.Bookings
        //                        where c.Status.Equals(status)
        //                        select c).Select(c => c.Status).Count();

        //    return countBooking;
        //}


        //[HttpGet]
        //public int editStatus(string status, int bookingId)
        //{
        //    var user = (from b in db.Bookings
        //                where b.BookingId.Equals(bookingId)
        //                select b).FirstOrDefault();

        //    user.Status = status;
        //    try
        //    {
        //        db.SubmitChanges();
        //        return 1;
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        ex.GetBaseException();
        //        return -1;
        //    }
        //}

        //[HttpGet]
        //public int countBookings(int count, int countt)
        //{
        //    var countBooking = (from c in db.Bookings
        //                        select c).Select(c => c.BookingId).Count();

        //    return countBooking;
        //}


        //[HttpGet]
        //public List<Booking> getBookings(int bookingId)
        //{
        //    var booking = (from b in db.Bookings
        //                   where b.Id.Equals(bookingId)
        //                   select b);

        //    List<Booking> listBooking = new List<Booking>();

        //    foreach (Booking customers in booking)
        //    {
        //        listBooking.Add(customers);
        //    }

        //    return listBooking;
        //}

        //[HttpGet]
        //public List<Booking> getBook()
        //{
        //    var bookings = (from b in db.Bookings
        //                    where !b.Status.Equals("Completed") && !b.Status.Equals("Cancelled")
        //                    select b);

        //    List<Booking> listBookings = new List<Booking>();

        //    foreach(Booking booking in bookings)
        //    {
        //        listBookings.Add(booking);
        //    }

        //    return listBookings;
        //}

        //[HttpGet]
        //public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId)
        //{
        //    var checkAppointment = (from b in db.Bookings
        //                            where b.Date.Equals(date) && b.Time.Equals(time)
        //                            select b).FirstOrDefault();

        //    if (checkAppointment == null)
        //    {
        //        Booking appointment = new Booking
        //        {
        //            Service = service,
        //            Date = date, 
        //            Time = time, 
        //            Status = status,//
        //            Id = userId
        //        };
        //        db.Bookings.InsertOnSubmit(appointment);

        //        try
        //        {
        //            db.SubmitChanges();
        //            return 1;
        //        }
        //        catch (Exception ex)
        //        {
        //            ex.GetBaseException();
        //            return -1;
        //        }
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        [HttpGet]
        public List<Booking> getActiveitems(int x, int y ,int thanabi)
        {

            var allitems = (from U in db.Bookings select U);
            List<Booking> reports = new List<Booking>();

            foreach (Booking item in allitems)
            {
                reports.Add(item);
            }
            return reports;
=======
            [HttpGet]
            public int countBookings(int count, int countt)
            {
                var countBooking = (from c in db.Bookings
                                    select c).Select(c => c.BookingId).Count();

                return countBooking;
            }


            [HttpGet]
            public List<Booking> getBookings(int bookingId)
            {
                var booking = (from b in db.Bookings
                               where b.Id.Equals(bookingId) && b.Status.Equals("Waiting")
                               select b);

                List<Booking> listBooking = new List<Booking>();

                foreach (Booking customers in booking)
                {
                    listBooking.Add(customers);
                }

                return listBooking;
            }


            [HttpGet]
            public List<Booking> getBook()
            {
                var bookings = (from b in db.Bookings
                                where !b.Status.Equals("Completed") && !b.Status.Equals("Cancelled")
                                select b);

                List<Booking> listBookings = new List<Booking>();

                foreach (Booking booking in bookings)
                {
                    listBookings.Add(booking);
                }

                return listBookings;
            }


            [HttpGet]
            public int checkDay(DateTime date)
            {
                DayOfWeek value = date.DayOfWeek;

                if (value == DayOfWeek.Sunday || value == DayOfWeek.Saturday)
                {

                    return 6;
                }
                else
                {
                    return 7;
                }
            }


            [HttpGet]
            public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId, int stylistID)
            {
                var checkAppointment = (from b in db.Bookings
                                        where b.Date.Equals(date) && b.Time.Equals(time)
                                        select b).FirstOrDefault();

                if (checkDay(date) == 6 )
                {
                    return 8;
                }
                else
                {

                    if (checkAppointment == null)
                    {
                        Booking appointment = new Booking
                        {
                            Service = service,
                            Date = date,
                            Time = time,
                            Status = status,//
                            Id = userId,
                            StylistID = stylistID

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
            /// <summary>
            /// //
            /// </summary>
            /// <param name="complete"></param>
            /// <returns></returns>
            [HttpGet]
            public List<Booking> GETcOMPLTE(string complete)
            {
                var booking = (from c in db.Bookings
                               where c.Status.Equals(complete)
                               select c);

                List<Booking> listBooking = new List<Booking>();

                foreach (Booking customers in booking)
                {
                    listBooking.Add(customers);
                }

                return listBooking;
            }

            //[HttpGet]
            //public int countBooking(string status)
            //{
            //    var countBooking = (from c in db.Bookings
            //                        where c.Status.Equals(status)
            //                        select c).Select(c => c.Status).Count();

            //    return countBooking;
            //}


            //[HttpGet]
            //public int editStatus(string status, int bookingId)
            //{
            //    var user = (from b in db.Bookings
            //                where b.BookingId.Equals(bookingId)
            //                select b).FirstOrDefault();

            //    user.Status = status;
            //    try
            //    {
            //        db.SubmitChanges();
            //        return 1;
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        ex.GetBaseException();
            //        return -1;
            //    }
            //}

            //[HttpGet]
            //public int countBookings(int count, int countt)
            //{
            //    var countBooking = (from c in db.Bookings
            //                        select c).Select(c => c.BookingId).Count();

            //    return countBooking;
            //}


            //[HttpGet]
            //public List<Booking> getBookings(int bookingId)
            //{
            //    var booking = (from b in db.Bookings
            //                   where b.Id.Equals(bookingId)
            //                   select b);

            //    List<Booking> listBooking = new List<Booking>();

            //    foreach (Booking customers in booking)
            //    {
            //        listBooking.Add(customers);
            //    }

            //    return listBooking;
            //}

            //[HttpGet]
            //public List<Booking> getBook()
            //{
            //    var bookings = (from b in db.Bookings
            //                    where !b.Status.Equals("Completed") && !b.Status.Equals("Cancelled")
            //                    select b);

            //    List<Booking> listBookings = new List<Booking>();

            //    foreach(Booking booking in bookings)
            //    {
            //        listBookings.Add(booking);
            //    }

            //    return listBookings;
            //}

            //[HttpGet]
            //public int bookAppointment(string service, DateTime date, TimeSpan time, string status, int userId)
            //{
            //    var checkAppointment = (from b in db.Bookings
            //                            where b.Date.Equals(date) && b.Time.Equals(time)
            //                            select b).FirstOrDefault();

            //    if (checkAppointment == null)
            //    {
            //        Booking appointment = new Booking
            //        {
            //            Service = service,
            //            Date = date, 
            //            Time = time, 
            //            Status = status,//
            //            Id = userId
            //        };
            //        db.Bookings.InsertOnSubmit(appointment);

            //        try
            //        {
            //            db.SubmitChanges();
            //            return 1;
            //        }
            //        catch (Exception ex)
            //        {
            //            ex.GetBaseException();
            //            return -1;
            //        }
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //}


>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
        }
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
    }

