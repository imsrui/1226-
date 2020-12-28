namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagory",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        UpdateTime = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        Detail = c.String(nullable: false, unicode: false, storeType: "text"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Counts = c.Int(nullable: false),
                        Cid = c.Guid(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
            DropTable("dbo.Catagory");
        }
    }
}
