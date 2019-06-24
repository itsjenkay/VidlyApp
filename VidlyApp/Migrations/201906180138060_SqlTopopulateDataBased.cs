namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SqlTopopulateDataBased : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationsInMonth,DIscountRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationsInMonth,DIscountRate) VALUES(2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationsInMonth,DIscountRate) VALUES(3,90,3,15)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationsInMonth,DIscountRate) VALUES(4,300,3,15)");

        }

        public override void Down()
        {
        }
    }
}
