namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatenumbersInStockForMovieColum1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false));
            Sql("UPDATE Movies SET ReleasedData= ReleasedDate");
            DropColumn("dbo.Movies", "ReleasedData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ReleasedData", c => c.DateTime(nullable: false));
            Sql("UPDATE Movies SET  ReleasedDate=ReleasedData");

            DropColumn("dbo.Movies", "ReleasedDate");
        }
    }
}
