﻿namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Username");
        }
    }
}
