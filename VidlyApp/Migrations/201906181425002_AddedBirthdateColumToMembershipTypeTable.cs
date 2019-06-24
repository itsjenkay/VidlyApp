namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdateColumToMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Birthdate", c => c.DateTime());

        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Birthdate");
        }
    }
}
