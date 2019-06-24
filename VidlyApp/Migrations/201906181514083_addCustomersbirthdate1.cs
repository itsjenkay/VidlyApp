namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomersbirthdate1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate= 1995-09-27 WHERE Id=1 ");
           
        }

        public override void Down()
        {
        }
    }
}
