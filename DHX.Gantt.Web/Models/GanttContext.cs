using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DHX.Gantt.Web.Models
{
    public class GanttContext : DbContext
    {
        public GanttContext() : base("GanttContext") { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Link> Links { get; set; }
    }
}