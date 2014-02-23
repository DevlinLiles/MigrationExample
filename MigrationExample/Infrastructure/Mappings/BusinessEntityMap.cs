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
        } 
    }
}