using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ActivityStudentProject.Models
{
    public class ActivityEventContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Rules> Rules { get; set; }
        public DbSet<Event> Event { get; set; }
    }
}