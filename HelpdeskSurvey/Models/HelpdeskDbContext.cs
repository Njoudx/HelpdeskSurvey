using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelpdeskSurvey.Models
{
    public class HelpdeskDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public HelpdeskDbContext() : base("name=DefaultConnection")
        {

        }

        public static HelpdeskDbContext Create()
        {
            return new HelpdeskDbContext();
        }
    }
}