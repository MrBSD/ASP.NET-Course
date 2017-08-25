namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateAddInStockInMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateAdd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "InStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "InStock");
            DropColumn("dbo.Movies", "DateAdd");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
