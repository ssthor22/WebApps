using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApptTracker.Models;

namespace ApptTracker.Data
{
    public class ApptTrackerContext : DbContext
    {
        public ApptTrackerContext (DbContextOptions<ApptTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<ApptTracker.Models.CreateAppt> CreateAppt { get; set; }

        public DbSet<ApptTracker.Models.Patient> Patient { get; set; }

        public DbSet<ApptTracker.Models.Provider> Provider { get; set; }
    }
}
