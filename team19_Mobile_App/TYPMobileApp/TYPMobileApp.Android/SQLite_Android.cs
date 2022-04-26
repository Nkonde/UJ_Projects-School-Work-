using SQLite;
using System;
using System.IO;
using TYPMobileApp.Models;
using Xamarin.Forms;

[assembly:Dependency(typeof(TYPMobileApp.Droid.SQLite_Android))]
namespace TYPMobileApp.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}