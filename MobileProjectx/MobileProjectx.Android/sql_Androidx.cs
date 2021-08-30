using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using MobileProjectx.Droid;
using Xamarin.Forms;
[assembly: Dependency(typeof(sql_Androidx))]

namespace MobileProjectx.Droid
{
    class sql_Androidx: sqlliteınterfacex
    {
        public SQLiteConnection GetConnection()
        {
            var DB_Name = "My_Db.sql";
            var DB_Path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var Full_Path = System.IO.Path.Combine(DB_Path, DB_Name);
            var Conn = new SQLiteConnection(Full_Path);
            return Conn;
        }
    }
}