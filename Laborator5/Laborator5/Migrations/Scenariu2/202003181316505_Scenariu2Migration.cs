namespace Laborator5.Migrations.Scenariu2
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Scenariu2Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BazaDeDate.Product",
                c => new
                    {
                        SKU = c.Int(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SKU);
            
            CreateTable(
                "BazaDeDate.ProductWebInfo",
                c => new
                    {
                        SKU = c.Int(nullable: false),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.SKU)
                .ForeignKey("BazaDeDate.Product", t => t.SKU)
                .Index(t => t.SKU);
            
        }
        
        public override void Down()
        {
            DropForeignKey("BazaDeDate.ProductWebInfo", "SKU", "BazaDeDate.Product");
            DropIndex("BazaDeDate.ProductWebInfo", new[] { "SKU" });
            DropTable("BazaDeDate.ProductWebInfo");
            DropTable("BazaDeDate.Product");
        }
    }
}
