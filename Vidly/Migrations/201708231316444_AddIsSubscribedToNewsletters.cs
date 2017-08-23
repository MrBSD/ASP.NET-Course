namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToNewsletters : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedForNewsleters", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedForNewsleters");
        }
    }
}
