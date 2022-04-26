using System;
using TYPMobileApp.Models;
using Xamarin.Forms;

namespace TYPMobileApp.Helpers
{
    public class CreateCartTable
    {
        public bool CreateTable()
        {
            try
            {
                var cn = DependencyService.Get<ISQLite>().GetConnection();
                cn.CreateTable<CartItem>();
                cn.Close();
                return true; 
            }
            catch(Exception ex)
            {
                return false; 
            }
        }
    }
}
