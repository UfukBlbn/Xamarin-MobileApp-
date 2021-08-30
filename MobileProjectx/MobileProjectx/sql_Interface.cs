using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MobileProjectx
{
   public interface sql_Interface
    {
        SQLiteConnection GetConnection();
    }
}
