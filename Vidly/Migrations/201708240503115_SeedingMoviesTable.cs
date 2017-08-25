namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdd, InStock) VALUES ('Hangover', 4, '10.12.2015', '01.31.2016', 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdd, InStock) VALUES ('Die Hard', 2, '03.10.2005', '07.25.2005', 3)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdd, InStock) VALUES ('The Terminator', 2, '10.03.1987', '01.03.1990', 10)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdd, InStock) VALUES ('Titanic', 1, '04.26.1999', '07.08.2000', 1)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdd, InStock) VALUES ('Toy Story', 3, '01.05.2004', '07.08.2004', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
