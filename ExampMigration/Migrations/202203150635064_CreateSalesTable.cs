namespace ExampMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSalesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantity = c.Int(nullable: false),
                        unit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        customer_id = c.Int(),
                        product_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.customer_id)
                .ForeignKey("dbo.Products", t => t.product_id)
                .Index(t => t.customer_id)
                .Index(t => t.product_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "product_id", "dbo.Products");
            DropForeignKey("dbo.Sales", "customer_id", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "product_id" });
            DropIndex("dbo.Sales", new[] { "customer_id" });
            DropTable("dbo.Sales");
        }
    }
}
