namespace ProjectA.Migrations.MediaFolder
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectA.Data.MediaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\MediaFolder";
        }

        protected override void Seed(ProjectA.Data.MediaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(
                t => t.MovieName, DataClass.getMovies().ToArray());
            context.SaveChanges();


            context.Actors.AddOrUpdate(
                a => new { a.FirstName, a.LastName }, DataClass.getActors(context).ToArray());

        }
    }
}
