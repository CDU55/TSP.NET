namespace Laborator5.Migrations.Scenariu3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Scenariu3Configuration : DbMigrationsConfiguration<Laborator5.Scenariu3>
    {
        public Scenariu3Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations/Scenariu3";
        }

        protected override void Seed(Laborator5.Scenariu3 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
