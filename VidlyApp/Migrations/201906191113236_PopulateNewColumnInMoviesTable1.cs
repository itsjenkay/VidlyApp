namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNewColumnInMoviesTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded='2012-10-1' WHERE Id=2 ");
            Sql("UPDATE Movies SET DateAdded='2014-12-10' WHERE Id=3 ");
            Sql("UPDATE Movies SET DateAdded='2015-8-23' WHERE Id=4 ");
            Sql("UPDATE Movies SET DateAdded='2016-6-17' WHERE Id=5 ");

        }

        public override void Down()
        {
        }
    }
}
