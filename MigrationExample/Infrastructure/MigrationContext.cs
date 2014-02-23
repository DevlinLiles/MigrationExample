using System.Configuration;
using Highway.Data;

namespace Infrastructure
{
    public class MigrationContext : DataContext
    {
        public MigrationContext() : base("Data Source=.;Initial Catalog=MigrationExample;Integrated Security=True", new ExampleMappings())
        {
            
        }
    }
}