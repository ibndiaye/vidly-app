namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddGenre1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Genres", "MyProperty");
        }

        public override void Down()
        {
            AddColumn("dbo.Genres", "MyProperty", c => c.String());
        }
    }
}