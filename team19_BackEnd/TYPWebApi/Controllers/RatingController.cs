using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class RatingController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();


        [HttpGet]
<<<<<<< HEAD
<<<<<<< HEAD
        public double? countAverageRating(int count, int countt,int stylistID)
=======
        public double? countAverageRating(int count, int countt, int stylistID)
>>>>>>> 2CC
=======
        public int countAverageRating(int count, int countt,int stylistID)
        {
            var countBooking = (from c in db.Ratings
                                where c.userId.Equals(stylistID)
                                select c).Select(c => c.NumberOfStar).Count();


            return countBooking;
        }

        [HttpGet]
        public int insertRating(int numberOfStart, string feedback, int UserId)
<<<<<<< HEAD
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
        {
            var countBooking = (from c in db.Ratings
                                where c.stylistID.Equals(stylistID)
                                select c).Select(c => c.NumberOfStar).Average();
=======
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
        {
            var countBooking = (from c in db.Ratings
                                where c.stylistID.Equals(stylistID)
                                select c).Select(c => c.NumberOfStar).Average();


            return countBooking;
        }

        [HttpGet]
        public int insertRating(int numberOfStart, string feedback, int UserId, int stylistID)
        {


            Rating newRating = new Rating
            {
                NumberOfStar = numberOfStart,
                Feedback = feedback,
                userId = UserId,
                stylistID = stylistID

            };
            db.Ratings.InsertOnSubmit(newRating);
>>>>>>> 2CC


            return countBooking ;
        }

        [HttpGet]
        public int insertRating(int numberOfStart, string feedback, int UserId,int stylistID)
        {

            
                Rating newRating = new Rating
                {
                    NumberOfStar = numberOfStart,
                    Feedback = feedback,
                    userId = UserId,
                    stylistID= stylistID

                };
                db.Ratings.InsertOnSubmit(newRating);

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
        [HttpGet]
        public List<Rating> getSock()
        {

            var allitems = (from U in db.Ratings select U);
            List<Rating> rate = new List<Rating>();

            foreach (Rating item in allitems)
            {
                rate.Add(item);
            }
            return rate;
        }
        [HttpGet]
        public List<Rating> getSock()
        {

            var allitems = (from U in db.Ratings select U);
            List<Rating> rate = new List<Rating>();

            foreach (Rating item in allitems)
            {
                rate.Add(item);
            }
            return rate;
        }
    }

}
