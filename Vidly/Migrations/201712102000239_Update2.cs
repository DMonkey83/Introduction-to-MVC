namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
      Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Armageddon', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
