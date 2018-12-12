using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Domains;

namespace Data.Mappings
{
    class ResourcesMap : EntityTypeConfiguration<Resources>
    {
        public ResourcesMap()
        {
            // Table 
            ToTable("Resources", "dbo");
            // Primary Key
            HasKey(u => u.Id);

            // validations
            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

            Property(c => c.Description)
            .HasMaxLength(100);

            Property(c => c.CategoryId)
                .IsRequired()
                .HasMaxLength(100);
            Property(c => c.FacilityId)
                .IsRequired();
            Property(c => c.SubCategoryId)
                .IsOptional()
                .HasMaxLength(100);
            Property(c => c.Quantity)
                .IsRequired();
            Property(c => c.OldQuantity)
                .IsOptional();
            Property(c => c.IsActive)
                .IsRequired();

            Property(c => c.Comments)
               .IsOptional();
        }
  }
 }
