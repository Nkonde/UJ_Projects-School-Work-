using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class AssignController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();


        [HttpGet]
        public int Assign(int userID, int  styleID,int state)
        {
<<<<<<< HEAD
            var assigned = (from u in db.assignStylists
                            where u.Stylee.Equals(styleID) && u.UserID.Equals(userID)
                            select u).FirstOrDefault();

            if (assigned == null)
            {
                assignStylist hair = new assignStylist
                {

                    UserID = userID,
                    Stylee = styleID,
                    status = state,

                };

                if (hair == null) return -1;

                db.assignStylists.InsertOnSubmit(hair);

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

            } else
            {
                return -3;
            }
=======

            assignStylist hair = new assignStylist
            {

                UserID = userID,
                Stylee= styleID,
                status=state,

            };

            if (hair == null) return -1;

            db.assignStylists.InsertOnSubmit(hair);

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
<<<<<<< HEAD
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
=======
>>>>>>> 6263ec9328a27db99197f94e8f2713ae6dff5e0a
>>>>>>> 2CC
        }

        [HttpGet]
        public List<assignStylist> assignMembers()
        {

            var allitems = (from U in db.assignStylists select U);
            List<assignStylist> reports = new List<assignStylist>();

            foreach (assignStylist item in allitems)
            {
                reports.Add(item);
            }
            return reports;
        }



        [HttpGet]
        public ItemStyle getstylistInfo(string styleName)
        {
            var user = (from u in db.ItemStyles
                        where u.hairstyleName.Equals(styleName)
                        select u).FirstOrDefault();

            return user;
        }

        [HttpGet]
        public assignStylist getSyle(int id,int ecx)
        {
            var user = (from u in db.assignStylists
                        where u.UserID.Equals(id)
                        select u).FirstOrDefault();

            return user;
        }

     

    }
}