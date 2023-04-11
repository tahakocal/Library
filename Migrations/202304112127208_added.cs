namespace Library.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserSubscriptions", "Subscription_Id", "dbo.Subscriptions");
            DropForeignKey("dbo.UserSubscriptions", "User_Id", "dbo.Users");
            DropIndex("dbo.UserSubscriptions", new[] { "Subscription_Id" });
            DropIndex("dbo.UserSubscriptions", new[] { "User_Id" });
            CreateTable(
                "dbo.Halls",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    HallName = c.String(),
                    HallNo = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Publishers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    PublisherName = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Shelves",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ShelveNo = c.Int(nullable: false),
                    ShelveName = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            CreateTable(
                "dbo.UserSubscriptions",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    SubscriptionId = c.Int(nullable: false),
                    UserId = c.String(),
                    StartDate = c.DateTime(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    Subscription_Id = c.Long(),
                    User_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Subscriptions",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(),
                    Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Seconds = c.Double(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    RoleName = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            DropTable("dbo.Shelves");
            DropTable("dbo.Publishers");
            DropTable("dbo.Halls");
            CreateIndex("dbo.UserSubscriptions", "User_Id");
            CreateIndex("dbo.UserSubscriptions", "Subscription_Id");
            AddForeignKey("dbo.UserSubscriptions", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.UserSubscriptions", "Subscription_Id", "dbo.Subscriptions", "Id");
        }
    }
}
