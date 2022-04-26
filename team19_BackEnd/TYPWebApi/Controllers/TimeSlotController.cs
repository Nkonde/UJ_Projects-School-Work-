using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class TimeSlotController : ApiController
    {

        DataClassesDataContext db = new DataClassesDataContext();

        [HttpGet]
        public List<TimeSlot> Molo()
        {
            var times = (from t in db.TimeSlots
                         select t);

            List<TimeSlot> timeSlots = new List<TimeSlot>();

            foreach (TimeSlot ts in times)
            {
                timeSlots.Add(ts);
            }
            return timeSlots;
        }
    }
}
