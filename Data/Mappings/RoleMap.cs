using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Core.Domains;
using System.Threading.Tasks;

namespace Data.Mappings
{
    class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap ()
            {
            ToTable("Role", "dbo");
            // Primary Key
            HasKey(u => u.Id);
            Property(c => c.RoleName)
                .IsRequired();
                        
        }
    }
}
