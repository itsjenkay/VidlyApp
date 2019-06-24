namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNewColumnInMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded='2012-10-1' WHERE Id=1 ");
      
        }
        
        public override void Down()
        {
        }
    }
}
