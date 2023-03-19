namespace Library.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 32),
                    Surname = c.String(nullable: false, maxLength: 32),
                    Description = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 128),
                    AuthorId = c.Long(nullable: false),
                    CategoryId = c.Long(nullable: false),
                    Description = c.String(),
                    Rented = c.Boolean(nullable: false),
                    CoverURL = c.String(),
                    ResizedCoverURL = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.BookRatings",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    ISBN = c.String(),
                    UserId = c.String(maxLength: 256),
                    Rate = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    Book_Id = c.Long(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.UserId)
                .Index(t => t.Book_Id);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 256),
                    Name = c.String(nullable: false),
                    Surname = c.String(nullable: false),
                    Email = c.String(nullable: false, maxLength: 64),
                    Password = c.String(nullable: false, maxLength: 64),
                    RoleId = c.Long(nullable: false),
                    ProfileAvatar = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.RentBooks",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    BookId = c.Long(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 256),
                    From = c.DateTime(nullable: false),
                    To = c.DateTime(nullable: false),
                    State = c.Int(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 32),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 64),
                    CreatedDate = c.DateTime(nullable: false),
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
                "dbo.UserSubscriptions",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    SubscriptionId = c.Int(nullable: false),
                    UserId = c.String(maxLength: 256),
                    StartDate = c.DateTime(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                    Subscription_Id = c.Long(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscriptions", t => t.Subscription_Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.Subscription_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.UserSubscriptions", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserSubscriptions", "Subscription_Id", "dbo.Subscriptions");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BookRatings", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookRatings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RentBooks", "UserId", "dbo.Users");
            DropForeignKey("dbo.RentBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.UserSubscriptions", new[] { "Subscription_Id" });
            DropIndex("dbo.UserSubscriptions", new[] { "UserId" });
            DropIndex("dbo.RentBooks", new[] { "UserId" });
            DropIndex("dbo.RentBooks", new[] { "BookId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.BookRatings", new[] { "Book_Id" });
            DropIndex("dbo.BookRatings", new[] { "UserId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.UserSubscriptions");
            DropTable("dbo.Subscriptions");
            DropTable("dbo.Categories");
            DropTable("dbo.Roles");
            DropTable("dbo.RentBooks");
            DropTable("dbo.Users");
            DropTable("dbo.BookRatings");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
