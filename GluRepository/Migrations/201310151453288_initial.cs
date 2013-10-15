namespace GluRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DbFoodProducts",
                c => new
                    {
                        DbFoodProductId = c.Int(nullable: false, identity: true),
                        FoodProductName = c.String(maxLength: 100),
                        Calories = c.Int(nullable: false),
                        FoodCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DbFoodProductId)
                .ForeignKey("dbo.DbFoodCategories", t => t.FoodCategoryId, cascadeDelete: true)
                .Index(t => t.FoodCategoryId);
            
            CreateTable(
                "dbo.DbFoodCategories",
                c => new
                    {
                        DbFoodCategoryId = c.Int(nullable: false, identity: true),
                        FoodCategoryName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.DbFoodCategoryId);
            
            CreateTable(
                "dbo.DbUsers",
                c => new
                    {
                        DbUserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 25),
                        Password = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DbUserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.DbFoodProducts", new[] { "FoodCategoryId" });
            DropForeignKey("dbo.DbFoodProducts", "FoodCategoryId", "dbo.DbFoodCategories");
            DropTable("dbo.DbUsers");
            DropTable("dbo.DbFoodCategories");
            DropTable("dbo.DbFoodProducts");
        }
    }
}
