using AuthApp.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AuthApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Teachers.AddOrUpdate(
              t => t.Name,
              new Teacher { Name = "Andrew Peters", PhoneNo = "8726842384" },
              new Teacher { Name = "Brice Lambson", PhoneNo = "234563234" },
              new Teacher { Name = "Rowan Miller", PhoneNo = "0908343294" }
            );

            //Adding initial Teacher Demo data
            //context.Teachers.Add
            //(
            //      new Teacher { ID = 1, Name = "Daw Moe", PhoneNo = "098374934834" }
            //  );

            context.SaveChanges();

            base.Seed(context);
        }
    }
}