namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUltimateParentsDataLoad : DbMigration
    {
        public override void Up()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Sql(string.Format(@"INSERT INTO [dbo].[UltimateParents]
           ([Created]
           ,[CreatedBy]
           ,[Modified]
           ,[ModifiedBy])
     VALUES
           ('{0}','{1}','{2}','{3}')", DateTime.Now, "devlibn", DateTime.Now, "Devlin"));
            }
            
        }
        
        public override void Down()
        {
        }
    }
}
