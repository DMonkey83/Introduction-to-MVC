namespace Vidly.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class PopulateGenres : DbMigration
  {
    public override void Up()
    {
      AddColumn("dbo.Genres", "GenreName", c => c.String(nullable: false, maxLength: 255));
      DropColumn("dbo.Genres", "Name");

      Sql("INSERT INTO Genres (GenreName) VALUES ('Action')");
      Sql("INSERT INTO Genres (GenreName) VALUES ('Comedy')");
      Sql("INSERT INTO Genres (GenreName) VALUES ('Horror')");
      Sql("INSERT INTO Genres (GenreName) VALUES ('Family')");
      Sql("INSERT INTO Genres (GenreName) VALUES ('Drama')");
      Sql("INSERT INTO Genres (GenreName) VALUES ('Anime')");
      Sql("INSERT INTO Genres (GenreName) VALUES ('Thriller')");
    }

    public override void Down()
    {
      AddColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
      DropColumn("dbo.Genres", "GenreName");
    }
  }
}
