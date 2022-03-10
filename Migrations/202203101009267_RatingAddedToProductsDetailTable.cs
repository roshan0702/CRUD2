namespace CRUD2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RatingAddedToProductsDetailTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductDetails", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductDetails", "Rating");
        }
    }
}
