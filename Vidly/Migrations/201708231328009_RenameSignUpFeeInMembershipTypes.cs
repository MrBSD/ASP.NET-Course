namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSignUpFeeInMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            Sql("UPDATE MembershipTypes SET SignUpFee=SingUpFee");
            DropColumn("dbo.MembershipTypes", "SingUpFee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SingUpFee", c => c.Short(nullable: false));
            Sql("UPDATE MembershipTypes SET SingUpFee=SignUpFee");
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
