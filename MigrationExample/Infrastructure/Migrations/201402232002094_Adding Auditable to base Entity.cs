namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAuditabletobaseEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusinessEntities", "Created", c => c.DateTime());
            AddColumn("dbo.BusinessEntities", "CreatedBy", c => c.String());
            AddColumn("dbo.BusinessEntities", "Modified", c => c.DateTime());
            AddColumn("dbo.BusinessEntities", "ModifiedBy", c => c.String());
            AddColumn("dbo.UltimateParents", "Created", c => c.DateTime());
            AddColumn("dbo.UltimateParents", "CreatedBy", c => c.String());
            AddColumn("dbo.UltimateParents", "Modified", c => c.DateTime());
            AddColumn("dbo.UltimateParents", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BusinessEntities", "ModifiedBy");
            DropColumn("dbo.BusinessEntities", "Modified");
            DropColumn("dbo.BusinessEntities", "CreatedBy");
            DropColumn("dbo.BusinessEntities", "Created");
            DropColumn("dbo.UltimateParents", "ModifiedBy");
            DropColumn("dbo.UltimateParents", "Modified");
            DropColumn("dbo.UltimateParents", "CreatedBy");
            DropColumn("dbo.UltimateParents", "Created");
            
        }
    }
}
