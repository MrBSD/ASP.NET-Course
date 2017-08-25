namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerWithId2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Customers ON INSERT INTO Customers (Id, Name, IsSubscribedForNewsleters, MembershipTypeId) VALUES (2, 'Shon Connor', 0, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
