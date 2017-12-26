using ProjectA.Models.Entertainment;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectA.Data
{
    public class MediaContext : DbContext
    {
        public MediaContext() : base("DefaultConnection")
        { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
