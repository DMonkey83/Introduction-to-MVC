namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {

      Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Armageddon', 1)");
      Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Ragnarok', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
