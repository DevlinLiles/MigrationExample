using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure
{
    public class UltimateParentMap : EntityTypeConfiguration<UltimateParent>
    {
        public UltimateParentMap()
        {
            this.ToTable("UltimateParents");
        }
    }
}