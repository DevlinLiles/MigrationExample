namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAuditabletobaseEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessEntities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Created = c.DateTime(),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(),
                        ModifiedBy = c.String(),
                        Parent_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UltimateParents", t => t.Parent_Id, cascadeDelete: true)
                .Index(t => t.Parent_Id);
            
            AddColumn("dbo.UltimateParents", "Created", c => c.DateTime());
            AddColumn("dbo.UltimateParents", "CreatedBy", c => c.String());
            AddColumn("dbo.UltimateParents", "Modified", c => c.DateTime());
            AddColumn("dbo.UltimateParents", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusinessEntities", "Parent_Id", "dbo.UltimateParents");
            DropIndex("dbo.BusinessEntities", new[] { "Parent_Id" });
            DropColumn("dbo.UltimateParents", "ModifiedBy");
            DropColumn("dbo.UltimateParents", "Modified");
            DropColumn("dbo.UltimateParents", "CreatedBy");
            DropColumn("dbo.UltimateParents", "Created");
            DropTable("dbo.BusinessEntities");
        }
    }
}
