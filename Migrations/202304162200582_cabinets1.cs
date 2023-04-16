namespace LibraryAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cabinets1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "CabinetId", "dbo.Cabinets");
            DropForeignKey("dbo.Books", "HallId", "dbo.Halls");
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Books", "ShelveId", "dbo.Shelves");
            DropIndex("dbo.Books", new[] { "ShelveId" });
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropIndex("dbo.Books", new[] { "HallId" });
            DropIndex("dbo.Books", new[] { "CabinetId" });
            AlterColumn("dbo.Books", "ShelveId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "PublisherId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "HallId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "CabinetId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "ShelveId");
            CreateIndex("dbo.Books", "PublisherId");
            CreateIndex("dbo.Books", "HallId");
            CreateIndex("dbo.Books", "CabinetId");
            AddForeignKey("dbo.Books", "CabinetId", "dbo.Cabinets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "HallId", "dbo.Halls", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "PublisherId", "dbo.Publishers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "ShelveId", "dbo.Shelves", "Id", cascadeDelete: true);
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
            AlterColumn("dbo.Books", "CabinetId", c => c.Int());
            AlterColumn("dbo.Books", "HallId", c => c.Int());
            AlterColumn("dbo.Books", "PublisherId", c => c.Int());
            AlterColumn("dbo.Books", "ShelveId", c => c.Int());
            CreateIndex("dbo.Books", "CabinetId");
            CreateIndex("dbo.Books", "HallId");
            CreateIndex("dbo.Books", "PublisherId");
            CreateIndex("dbo.Books", "ShelveId");
            AddForeignKey("dbo.Books", "ShelveId", "dbo.Shelves", "Id");
            AddForeignKey("dbo.Books", "PublisherId", "dbo.Publishers", "Id");
            AddForeignKey("dbo.Books", "HallId", "dbo.Halls", "Id");
            AddForeignKey("dbo.Books", "CabinetId", "dbo.Cabinets", "Id");
        }
    }
}
