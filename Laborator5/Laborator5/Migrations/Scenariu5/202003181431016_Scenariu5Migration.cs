namespace Laborator5.Migrations.Scenariu5
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Scenariu5Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                {
                    EmployeeId = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Salary = c.Decimal(precision: 18, scale: 2),
                    Wage = c.Decimal(precision: 18, scale: 2),
                    EmployeeType = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.EmployeeId);

        }

        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
