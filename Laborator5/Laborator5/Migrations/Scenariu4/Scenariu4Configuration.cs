namespace Laborator5.Migrations.Scenariu4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Scenariu4Configuration : DbMigrationsConfiguration<Laborator5.Scenariu4>
    {
        public Scenariu4Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations/Scenariu4";
        }

        protected override void Seed(Laborator5.Scenariu4 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
