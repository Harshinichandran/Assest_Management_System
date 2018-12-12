using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Domains;

namespace Data.Mappings
{
       class UsersMap : EntityTypeConfiguration<Users>
       
    {
          public UsersMap()
        {
                // Table 
                ToTable("Users", "dbo");
                // Primary Key
                HasKey(u => u.Id);

                // validations
                Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                Property(c => c.Address)
                    .IsRequired()
                    .HasMaxLength(200);
               
                Property(c => c.Email)
                  .IsRequired();

              //    HasRequired(x => x.Roles)
              //    .WithMany(x => x.UsersInfo)
              //     .HasForeignKey(x => x.RoleId)
              //    .WillCascadeOnDelete(false);

              //  HasRequired(x => x.Facility)
              //.WithMany(x => x.UserCollection)
              // .HasForeignKey(x => x.SelectedFacility)
              //.WillCascadeOnDelete(false);


            }
    }
  
}

