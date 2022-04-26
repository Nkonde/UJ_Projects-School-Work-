using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TYPMobileApp.Repositories
{
    public interface IUserService
    {
        Task<bool> IsUserExists(string email);
        Task<bool> RegisterUser(string name, string surname, string email, string password, string phonenumber, string address, string gender);
        Task<bool> LoginUser(string email, string password);
    }
}
