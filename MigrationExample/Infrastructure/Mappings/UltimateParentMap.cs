using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure
{
    public class UltimateParentMap : EntityTypeConfiguration<UltimateParent>
    {
        public UltimateParentMap()
        {
            this.ToTable("UltimateParents");
            this.Property(x => x.Created).IsOptional();
            this.Property(x => x.CreatedBy).IsOptional();
            this.Property(x => x.Modified).IsOptional();
        }
    }
}