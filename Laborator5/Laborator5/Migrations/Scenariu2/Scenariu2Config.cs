namespace Laborator5.Migrations.Scenariu2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Scenariu2Config : DbMigrationsConfiguration<Laborator5.Scenariu2>
    {
        public Scenariu2Config()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Scenariu2";
        }

        protected override void Seed(Laborator5.Scenariu2 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
