namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name) VALUES ('The Die Hrd')");
            Sql("INSERT INTO Movies (Name) VALUES ('The family')");
            Sql("INSERT INTO Movies (Name) VALUES ('The rise of nation')");
            Sql("INSERT INTO Movies (Name) VALUES ('Toy Story')");

        }

        public override void Down()
        {
        }
    }
}
