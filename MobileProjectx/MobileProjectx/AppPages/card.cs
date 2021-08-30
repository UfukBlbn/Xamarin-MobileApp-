using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileProjectx.AppPages
{
    public class card
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string CardNo { get; set; }
        public string OwnerName { get; set; }
    }
}
