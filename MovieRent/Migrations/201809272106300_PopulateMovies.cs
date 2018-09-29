namespace MovieRent.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, GenreId, NumberInStock) VALUES ('Hangover', 2/2/2012, 3/4/2012, 4, 20) ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, GenreId, NumberInStock) VALUES ('Die Hard', 2/2/2011, 3/4/2011, 1, 40) ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, GenreId, NumberInStock) VALUES ('The Terminator', 2/2/2010, 3/4/2010, 1, 50 ) ");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, GenreId, NumberInStock) VALUES ('Toy Story', 2/2/2010, 3/4/2010, 3, 25) ");
        }
        
        public override void Down()
        {
        }
    }
}
