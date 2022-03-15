namespace ExampMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sales", "customer_id", "dbo.Customers");
            DropForeignKey("dbo.Sales", "product_id", "dbo.Products");
            DropIndex("dbo.Sales", new[] { "customer_id" });
            DropIndex("dbo.Sales", new[] { "product_id" });
            AlterColumn("dbo.Sales", "customer_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "product_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Sales", "product_id");
            CreateIndex("dbo.Sales", "customer_id");
            AddForeignKey("dbo.Sales", "customer_id", "dbo.Customers", "id", cascadeDelete: true);
            AddForeignKey("dbo.Sales", "product_id", "dbo.Products", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "product_id", "dbo.Products");
            DropForeignKey("dbo.Sales", "customer_id", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "customer_id" });
            DropIndex("dbo.Sales", new[] { "product_id" });
            AlterColumn("dbo.Sales", "product_id", c => c.Int());
            AlterColumn("dbo.Sales", "customer_id", c => c.Int());
            CreateIndex("dbo.Sales", "product_id");
            CreateIndex("dbo.Sales", "customer_id");
            AddForeignKey("dbo.Sales", "product_id", "dbo.Products", "id");
            AddForeignKey("dbo.Sales", "customer_id", "dbo.Customers", "id");
        }
    }
}
