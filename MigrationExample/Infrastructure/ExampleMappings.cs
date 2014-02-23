using System.Data.Entity;
using Domain;
using Highway.Data;

namespace Infrastructure
{
    public class ExampleMappings : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UltimateParentMap());
            modelBuilder.Configurations.Add(new BusinessEntityMap());
        }
    }
}