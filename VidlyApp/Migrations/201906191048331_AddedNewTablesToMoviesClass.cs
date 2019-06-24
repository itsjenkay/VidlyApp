namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewTablesToMoviesClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleasedData", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumbersInStock", c => c.Byte(nullable: false));

          


        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumbersInStock");
            DropColumn("dbo.Movies", "ReleasedData");
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
