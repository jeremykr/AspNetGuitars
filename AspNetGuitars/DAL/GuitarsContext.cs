using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetGuitars.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AspNetGuitars.DAL {
    public class GuitarsContext : DbContext {

        private static string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=aspnet-AspNetGuitars;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Guitars.mdf";

        public GuitarsContext() : base(connectionString) {
            Database.SetInitializer(new GuitarsInitializer());
        }

        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}