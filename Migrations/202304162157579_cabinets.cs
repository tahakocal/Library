namespace LibraryAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cabinets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cabinets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CabinetNo = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "ShelveId", c => c.Int());
            AddColumn("dbo.Books", "PublisherId", c => c.Int());
            AddColumn("dbo.Books", "HallId", c => c.Int());
            AddColumn("dbo.Books", "CabinetId", c => c.Int());
            CreateIndex("dbo.Books", "ShelveId");
            CreateIndex("dbo.Books", "PublisherId");
            CreateIndex("dbo.Books", "HallId");
            CreateIndex("dbo.Books", "CabinetId");
            AddForeignKey("dbo.Books", "CabinetId", "dbo.Cabinets", "Id");
            AddForeignKey("dbo.Books", "HallId", "dbo.Halls", "Id");
            AddForeignKey("dbo.Books", "PublisherId", "dbo.Publishers", "Id");
            AddForeignKey("dbo.Books", "ShelveId", "dbo.Shelves", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "ShelveId", "dbo.Shelves");
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Books", "HallId", "dbo.Halls");
            DropForeignKey("dbo.Books", "CabinetId", "dbo.Cabinets");
            DropIndex("dbo.Books", new[] { "CabinetId" });
            DropIndex("dbo.Books", new[] { "HallId" });
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropIndex("dbo.Books", new[] { "ShelveId" });
            DropColumn("dbo.Books", "CabinetId");
            DropColumn("dbo.Books", "HallId");
            DropColumn("dbo.Books", "PublisherId");
            DropColumn("dbo.Books", "ShelveId");
            DropTable("dbo.Cabinets");
        }
    }
}
