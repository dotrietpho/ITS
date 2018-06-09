using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITS.Model.Models;

namespace ITS.Data
{
    public class ITSDbContext : DbContext
    {
        public ITSDbContext() : base("ITSConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { set; get; }
        public DbSet<Plan> Plans { set; get; }
        public DbSet<PlanDetail> PlanDetails { set; get; }

        public DbSet<Trip> Trips { set; get; }
        public DbSet<StopPoint> StopPoints { set; get; }

        public DbSet<Location> Locations { set; get; }
        public DbSet<LocationCategory> LocationCategorys { set; get; }
        public DbSet<LocationTag> LocationTags { set; get; }

        public DbSet<Tag> Tag { set; get; }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<CityCategory> CityCategorys { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
