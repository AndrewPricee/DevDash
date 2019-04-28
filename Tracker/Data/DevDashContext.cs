using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Models;

namespace Tracker.Data
{
    public class DevDashContext: DbContext
    {
        public DevDashContext() : base("name=DevDash")
        {
            Database.SetInitializer<DevDashContext>(new CreateDatabaseIfNotExists<DevDashContext>());
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<UserInfo> Users { get; set; }

    }
}
