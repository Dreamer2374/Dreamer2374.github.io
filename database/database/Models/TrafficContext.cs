using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using database.Models;

namespace database.Models
{
    public class TrafficContext : DbContext
    {

        public TrafficContext() : base("TrafficContext")
        {
        }




        public DbSet<Traffic> Traffics { get; set; }

    }

    public class DbInitializer: DropCreateDatabaseAlways<TrafficContext>
    {
        protected override void Seed(TrafficContext db)
        {
            db.Traffics.Add(new Traffic { FirmName = "Поле", EventDate = new DateTime(2018,04,25), DriverName="Лудик", Amount=2450 });
            db.Traffics.Add(new Traffic { FirmName = "Доле", EventDate = new DateTime(2017, 04,24), DriverName = "Лудик", Amount = 120 });
            base.Seed(db);
}



    }
}