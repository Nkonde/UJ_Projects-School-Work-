using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TYPMobileApp.Models;
using TYPMobileApp.Repositories;
using TYPMobileApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(UserService))]
namespace TYPMobileApp.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient client = new HttpClient();
        
        public async Task<bool> IsUserExists(string email)
        {
            var user  = JsonConvert.DeserializeObject<User>(
                                    await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Users?email={email}"));

            return user != null; 
        }

        public async Task<bool> RegisterUser(string name, string surname, string email, string password, string phonenumber, string address, string gender)
        {
            if(await IsUserExists(email) == false)
            {
                var user = JsonConvert.DeserializeObject<int>(
                                       await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Users?name={name}&surname={surname}&email={email}&password={password}&phonenumber={phonenumber}&address={address}&gender={gender}&usertype=Client"));

                if (user == 1)
                    return true;
            }
            return false; 
        }

        public async Task<bool> LoginUser(string email, string password)
        { 
            var user = JsonConvert.DeserializeObject<int>(
                                   await client.GetStringAsync($"https://typapi.azurewebsites.net/api/Users?email={email}&password={password}"));

            if (user == -1)
                return false;
            else
                return true; 
        }
    }
}
