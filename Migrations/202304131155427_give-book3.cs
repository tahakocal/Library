namespace LibraryAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class givebook3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RentBooks", "UserId", "dbo.Users");
            DropIndex("dbo.RentBooks", new[] { "UserId" });
            AddColumn("dbo.RentBooks", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.RentBooks", "MemberId");
            AddForeignKey("dbo.RentBooks", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
            DropColumn("dbo.RentBooks", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RentBooks", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.RentBooks", "MemberId", "dbo.Members");
            DropIndex("dbo.RentBooks", new[] { "MemberId" });
            DropColumn("dbo.RentBooks", "MemberId");
            CreateIndex("dbo.RentBooks", "UserId");
            AddForeignKey("dbo.RentBooks", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
