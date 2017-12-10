namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDOBToCustomerClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
          Sql("Update dbo.Customers Set BirthDate = '07/06/1983' WHERE Id = 1");
          Sql("Update dbo.Customers Set BirthDate = '01/12/1983' WHERE Id = 2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
