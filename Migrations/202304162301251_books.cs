namespace LibraryAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class books : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Halls", "HallName");
            DropColumn("dbo.Shelves", "ShelveName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shelves", "ShelveName", c => c.String());
            AddColumn("dbo.Halls", "HallName", c => c.String());
        }
    }
}
