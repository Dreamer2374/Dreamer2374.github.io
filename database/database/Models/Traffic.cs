using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace database.Models
{
    public class Traffic
    {
        public int ID { get; set; }
        public string FirmName { get; set; }
        public DateTime EventDate { get; set; }
        public string DriverName { get; set; }
        public string Route { get; set; }
        public int Amount { get; set; }

    }
}