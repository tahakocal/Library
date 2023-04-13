namespace WindowsFormsApp1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    AuthorName = c.String(),
                    AuthorSurname = c.String(),
                    AuthorDescription = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    AuthorId = c.Int(nullable: false),
                    CategoryId = c.Int(nullable: false),
                    Description = c.String(),
                    Rented = c.Boolean(nullable: false),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.CategoryId);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CategoryName = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Employees",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                    SectionId = c.Int(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .Index(t => t.SectionId);

            CreateTable(
                "dbo.Sections",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SectionName = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

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
                "dbo.Members",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                    Email = c.String(),
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
                "dbo.RentBooks",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    BookId = c.Int(nullable: false),
                    UserId = c.Int(nullable: false),
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
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                    Username = c.String(),
                    Email = c.String(),
                    Password = c.String(),
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
            DropForeignKey("dbo.RentBooks", "UserId", "dbo.Users");
            DropForeignKey("dbo.RentBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.Employees", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.RentBooks", new[] { "UserId" });
            DropIndex("dbo.RentBooks", new[] { "BookId" });
            DropIndex("dbo.Employees", new[] { "SectionId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Shelves");
            DropTable("dbo.Users");
            DropTable("dbo.RentBooks");
            DropTable("dbo.Publishers");
            DropTable("dbo.Members");
            DropTable("dbo.Halls");
            DropTable("dbo.Sections");
            DropTable("dbo.Employees");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
