using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MobileProjectx
{
    public class person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string Name { get; set; }
        
    }
}
