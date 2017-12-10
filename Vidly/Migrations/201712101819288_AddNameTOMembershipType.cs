using System.Data.Entity.Core.Metadata.Edm;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameTOMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
      Sql("UPDATE dbo.MembershipTypes Set Name = 'Pay As You Go' WHERE Id = 1");
      Sql("UPDATE dbo.MembershipTypes Set Name = 'Monthly' WHERE Id = 2");
      Sql("UPDATE dbo.MembershipTypes Set Name = 'Quaterly' WHERE Id = 3");
      Sql("UPDATE dbo.MembershipTypes Set Name = 'Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
