namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExampleOfSqlBasedMigration : DbMigration
    {
        public override void Up()
        {
            Sql(this.Resources.GetString("ExampleMigration"));
        }
        
        public override void Down()
        {
            Sql(this.Resources.GetString("ExampleMigration"));
        }
    }
}
