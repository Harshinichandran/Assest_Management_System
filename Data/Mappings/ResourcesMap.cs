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

        }
  }
 }
