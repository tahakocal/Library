namespace LibraryAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class givebook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "BookId", c => c.Int());
            CreateIndex("dbo.Members", "BookId");
            AddForeignKey("dbo.Members", "BookId", "dbo.Books", "Id");
        }
        public override void Down()
        {
            DropForeignKey("dbo.Members", "BookId", "dbo.Books");
            DropIndex("dbo.Members", new[] { "BookId" });
            DropColumn("dbo.Members", "BookId");
        }
    }
}
