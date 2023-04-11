namespace Library.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class sections : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SectionName = c.String(),
                    CreatedDate = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Employees", "SectionId", c => c.String());
            AddColumn("dbo.Employees", "Section_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Section_Id");
            AddForeignKey("dbo.Employees", "Section_Id", "dbo.Sections", "Id");
            DropColumn("dbo.Employees", "Section");
        }

        public override void Down()
        {
            AddColumn("dbo.Employees", "Section", c => c.String());
            DropForeignKey("dbo.Employees", "Section_Id", "dbo.Sections");
            DropIndex("dbo.Employees", new[] { "Section_Id" });
            DropColumn("dbo.Employees", "Section_Id");
            DropColumn("dbo.Employees", "SectionId");
            DropTable("dbo.Sections");
        }
    }
}
