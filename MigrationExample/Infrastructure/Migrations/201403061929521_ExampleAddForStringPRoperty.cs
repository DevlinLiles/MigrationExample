namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExampleAddForStringPRoperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessEntities", "ExampleChange", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessEntities", "ExampleChange");
        }
    }
}
