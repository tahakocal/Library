namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixsomething : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorName", c => c.String());
            AddColumn("dbo.Authors", "AuthorSurname", c => c.String());
            AddColumn("dbo.Authors", "AuthorDescription", c => c.String());
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            AddColumn("dbo.Roles", "RoleName", c => c.String());
            DropColumn("dbo.Authors", "Name");
            DropColumn("dbo.Authors", "Surname");
            DropColumn("dbo.Authors", "Description");
            DropColumn("dbo.Categories", "Name");
            DropColumn("dbo.Roles", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "Name", c => c.String());
            AddColumn("dbo.Categories", "Name", c => c.String());
            AddColumn("dbo.Authors", "Description", c => c.String());
            AddColumn("dbo.Authors", "Surname", c => c.String());
            AddColumn("dbo.Authors", "Name", c => c.String());
            DropColumn("dbo.Roles", "RoleName");
            DropColumn("dbo.Categories", "CategoryName");
            DropColumn("dbo.Authors", "AuthorDescription");
            DropColumn("dbo.Authors", "AuthorSurname");
            DropColumn("dbo.Authors", "AuthorName");
        }
    }
}
