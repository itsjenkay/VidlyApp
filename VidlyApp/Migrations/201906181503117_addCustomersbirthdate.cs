namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomersbirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.MembershipTypes", "Birthdate");
            Sql("UPDATE Customers SET Birthdate=1/1/2019 WHERE Id=1 ");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
