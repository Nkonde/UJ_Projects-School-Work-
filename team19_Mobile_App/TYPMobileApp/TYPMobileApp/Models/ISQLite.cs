using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TYPMobileApp.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
