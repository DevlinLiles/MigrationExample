namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnWithData : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UltimateParents", "ModifiedBy");
            DropColumn("dbo.BusinessEntities", "ModifiedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusinessEntities", "ModifiedBy", c => c.String());
            AddColumn("dbo.UltimateParents", "ModifiedBy", c => c.String());
        }
    }
}
