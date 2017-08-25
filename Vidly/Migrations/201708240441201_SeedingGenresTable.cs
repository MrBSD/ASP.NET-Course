namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name, Description) VALUES ('Romance', '16+')");
            Sql("INSERT INTO Genres (Name, Description) VALUES ('Action', '16+')");
            Sql("INSERT INTO Genres (Name, Description) VALUES ('Family', 'May be watched with children')");
            Sql("INSERT INTO Genres (Name, Description) VALUES ('Comedy', 'Funny')");
        }
        
        public override void Down()
        {
        }
    }
}
