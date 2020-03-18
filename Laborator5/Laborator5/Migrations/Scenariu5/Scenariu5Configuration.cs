using System.Data.Entity.Migrations;

namespace Laborator5.Migrations.Scenariu5
{
    internal sealed class Scenariu5Configuration : DbMigrationsConfiguration<Laborator5.Scenariu5>
    {
        public Scenariu5Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations/Scenariu5";
        }

        protected override void Seed(Laborator5.Scenariu5 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
