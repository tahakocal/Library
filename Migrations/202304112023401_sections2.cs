namespace Library.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class sections2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "Section_Id" });
            DropColumn("dbo.Employees", "SectionId");
            RenameColumn(table: "dbo.Employees", name: "Section_Id", newName: "SectionId");
            AlterColumn("dbo.Employees", "SectionId", c => c.Int());
            CreateIndex("dbo.Employees", "SectionId");
        }

        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "SectionId" });
            AlterColumn("dbo.Employees", "SectionId", c => c.String());
            RenameColumn(table: "dbo.Employees", name: "SectionId", newName: "Section_Id");
            AddColumn("dbo.Employees", "SectionId", c => c.String());
            CreateIndex("dbo.Employees", "Section_Id");
        }
    }
}
