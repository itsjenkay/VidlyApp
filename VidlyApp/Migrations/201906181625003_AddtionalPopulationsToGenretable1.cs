namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtionalPopulationsToGenretable1 : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");

        }
        
        public override void Down()
        {
        }
    }
}
