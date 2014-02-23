namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUltimateParent : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.UltimateParents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UltimateParents");
        }
    }
}
