using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYPWebApi.Controllers
{
    public class UsersController : ApiController
    {
        DataClassesDataContext db = new DataClassesDataContext();
        
        [HttpGet]
        public int updateInfo(int userId, string name, string surname, string email, string password, string phonenumber, string address, string gender, string usertype = "Client")
        {
            var user = getUser(userId);

            if(user != null)
            {
                user.Name = name;
                user.Surname = surname;
                user.Email = email;
                user.Password = password;
                user.UserType = usertype;
                user.Gender = gender;
                user.Phonenumber = phonenumber;
                user.Address = address;

                try
                {
                    db.SubmitChanges();
                    return 1;
                }
                catch(IndexOutOfRangeException ex)
                {
                    ex.GetBaseException();
                    return -1;
                }
            }
            else
            {
                return -2;
            }
        }

        [HttpGet]
        public int registerClient(string name, string surname, string email, string password, string phonenumber, string address, string gender, string usertype = "Client")
        {
            var checkUser = (from u in db.Users
                             where u.Email.Equals(email)
                             select u).FirstOrDefault();

            if (checkUser == null)
            {
                User newUser = new User
                {
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Password = password,
                    UserType = usertype,
                    Gender = gender,
                    Phonenumber = phonenumber,
                    Address = address
                };
                db.Users.InsertOnSubmit(newUser);

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

        [HttpGet]
        public int login(string email, string password)
        {
            var user = (from u in db.Users
                        where u.Email.Equals(email) & u.Password.Equals(password)
                        select u).FirstOrDefault();

            if (user == null)
                return -1;


            return user.Id;
        }

        [HttpGet]
        public User getUser(string email)
        {
            var user = (from u in db.Users
                        where u.Email.Equals(email)
                        select u).FirstOrDefault();

            return user;
        }

        [HttpGet]

        public User getUser(int userId)
        {
            var user = (from u in db.Users
                        where u.Id.Equals(userId)
                        select u).FirstOrDefault();

            return user;
        }

        [HttpGet]
        public List<User> getListUser(int listId)
        {
            var users = (from u in db.Users
                        where u.Id.Equals(listId)
                        select u);

            List<User> listUsers = new List<User>();

            foreach (User user in users)
            {
                listUsers.Add(user);
            }

            return listUsers;
        }


        [HttpGet]
        public int editUser(int userID, String email, String Status)
        {
            User user = (from u in db.Users
                         where u.Id.Equals(userID)
                         select u).FirstOrDefault();

            if (user == null) return -1;

            user.Email = string.IsNullOrEmpty(email) ? user.Email : email;
            user.status = string.IsNullOrEmpty(Status) ? user.status : Status;

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
        public List<User> getUsers()
        {

            var allitems = (from U in db.Users select U);
            List<User> reports = new List<User>();

            foreach (User user in allitems)
            {
                reports.Add(user);
            }
            return reports;
        }
       
        
        [HttpGet]
<<<<<<< HEAD
        public int Register(String name, String surname, String email, String password, String phone, String adress, string usert, string Status,string gender)
=======
        public int Register(String name, String surname, String email, String password, String phonenumber, String gender, String address, string usertype, string Status)
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
        {

            User user = new User
            {
                Name = name,
                Surname = surname,
<<<<<<< HEAD
                Password = password,
                Email = email,
                Phonenumber = phone,
                Address = adress,
                UserType = usert,
                status = Status,
                Gender=gender,
=======
                Email = email,
                Password = password,
                UserType = usertype,
                Gender = gender, 
                Phonenumber = phonenumber,
                Address = address,
                status = Status
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
            };

            if (user == null) return -1;


            db.Users.InsertOnSubmit(user);

            try
            {
                db.SubmitChanges();
<<<<<<< HEAD
=======
                return user.Id;
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
<<<<<<< HEAD
            return user.Id;


        }

      

=======
        }
<<<<<<< HEAD
>>>>>>> e9b0c8fdf7cca20754c77377c377adbe34aa3ac5
=======

        //------------------------

>>>>>>> 2CC
    }
}
