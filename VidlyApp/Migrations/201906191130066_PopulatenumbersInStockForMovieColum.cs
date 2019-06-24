namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatenumbersInStockForMovieColum : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumbersInStock=2 WHERE Id=1");
            Sql("UPDATE Movies SET NumbersInStock=17 WHERE Id=2");
            Sql("UPDATE Movies SET NumbersInStock=10 WHERE Id=3");
            Sql("UPDATE Movies SET NumbersInStock=7 WHERE Id=4");
            Sql("UPDATE Movies SET NumbersInStock=4 WHERE Id=5");

        }

        public override void Down()
        {
        }
    }
}
