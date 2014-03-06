using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Infrastructure
{
    public class BusinessEntityMap : EntityTypeConfiguration<BusinessEntity>
    {
        public BusinessEntityMap()
        {
            this.ToTable("BusinessEntities");
            this.HasRequired(x => x.Parent).WithMany();
            this.Property(x => x.Created).IsOptional();
            this.Property(x => x.CreatedBy).IsOptional();
            this.Property(x => x.Modified).IsOptional();
        } 
    }
}