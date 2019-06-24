namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDateReleasedDateColumn2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleasedDate='2017-September-1' WHERE Id=1");
            
        }

        public override void Down()
        {
        }
    }
}
