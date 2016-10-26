namespace S00156762Week6.Migration.ClubsMigrations
{
    using Models.ClubsModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<S00156762Week6.Models.ClubsModel.ClubsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\ClubsMigrations";
        }

        protected override void Seed(S00156762Week6.Models.ClubsModel.ClubsContext context)
        {
            context.Clubs.AddOrUpdate(c => c.ClubName,
                new Club
                {
                    ClubName = "Tiddly Winks Club",
                    CreationDate = DateTime.Now
                });
            context.Clubs.AddOrUpdate(c => c.ClubName,
                new Club
                {
                    ClubName = "The Chess Club",
                    CreationDate = DateTime.Now
                });
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
        }
    }
}
