namespace MovieRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropColumn("dbo.Movies", "GenreId");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "NumberOfStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumberOfStock", c => c.Byte(nullable: false));
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
        }
    }
}
