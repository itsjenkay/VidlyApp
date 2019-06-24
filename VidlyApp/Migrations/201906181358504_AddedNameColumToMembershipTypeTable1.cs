namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameColumToMembershipTypeTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Quarterly' WHERE Id=3 ");
            Sql("UPDATE MembershipTypes SET Name= 'Annual' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
