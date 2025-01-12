using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace officemanagment.DAL
{
    public class userContext : DbContext
    {
        public userContext() : base() 
        { 
            Database.SetInitializer(new CustomDBInitializer());
        }
        public DbSet<userContext> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}