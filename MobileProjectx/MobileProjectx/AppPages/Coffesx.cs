using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileProjectx
{
    public class Coffesx
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Money { get; set; }
    }
}
