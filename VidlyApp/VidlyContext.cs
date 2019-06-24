using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VidlyApp.Models;

namespace VidlyApp
{
    public class VidlyContext:DbContext
    {
        public VidlyContext()
            :base("name=VidlyContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }

    
}