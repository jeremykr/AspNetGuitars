using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetGuitars.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AspNetGuitars.DAL {
    public class GuitarsInitializer : DropCreateDatabaseAlways<GuitarsContext> {
        protected override void Seed(GuitarsContext context) {
            var makes = new List<Make> {
                new Models.Make { Name="Fender" },
                new Models.Make { Name="Gibson" }
            };

            makes.ForEach(m => context.Makes.Add(m));
            context.SaveChanges();

            var models = new List<Model> {
                new Models.Model { Name="Stratocaster", Make=makes[0] },
                new Models.Model { Name="Telecaster", Make=makes[0] },
                new Models.Model { Name="Les Paul", Make=makes[1] },
                new Models.Model { Name="SG", Make=makes[1] }
            };

            models.ForEach(m => context.Models.Add(m));
            context.SaveChanges();

            var guitars = new List<Guitar> {
                new Models.Guitar { Description="Fiesta Red", Model=models[0] },
                new Models.Guitar { Description="Paisley", Model=models[1] },
                new Models.Guitar { Description="Iced Tea Burst", Model=models[2] }
            };

            guitars.ForEach(g => context.Guitars.Add(g));
            context.SaveChanges();
        }
    }
}