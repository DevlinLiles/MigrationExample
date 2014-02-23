namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBusinessEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessEntities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Parent_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UltimateParents", t => t.Parent_Id, cascadeDelete: true)
                .Index(t => t.Parent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusinessEntities", "Parent_Id", "dbo.UltimateParents");
            DropIndex("dbo.BusinessEntities", new[] { "Parent_Id" });
            DropTable("dbo.BusinessEntities");
        }
    }
}
