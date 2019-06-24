namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDateReleasedDateColumn1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleasedDate='2017-September-1' WHERE Id=1");
            Sql("UPDATE Movies SET ReleasedDate='2016-2-1' WHERE Id=2");
            Sql("UPDATE Movies SET ReleasedDate='2019-4-10' WHERE Id=3");
            Sql("UPDATE Movies SET ReleasedDate='2020-1-10' WHERE Id=4");
            Sql("UPDATE Movies SET ReleasedDate='2015-8-10' WHERE Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
