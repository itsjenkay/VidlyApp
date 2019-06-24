namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Genres", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
