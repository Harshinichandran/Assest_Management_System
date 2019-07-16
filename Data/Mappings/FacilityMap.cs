
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Core.Domains;

namespace Data.Mappings
{
    class FacilityMap : EntityTypeConfiguration<Facility>
    {
        public FacilityMap()
        {
            // Table 
            ToTable("Facility", "dbo");
            // Primary Key
            HasKey(u => u.Id);

            // validations
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Landmark)
             .IsRequired();

            Property(c => c.Address)
                .IsRequired();

            //HasOptional(x => x.Users)
            // .WithMany(x => x.Facilities)
            // .HasForeignKey(x => x.Id)
            // .WillCascadeOnDelete(false);


          //  HasOptional(x => x.Users)
          //.WithMany(x => x.Facilities)
          // .HasForeignKey(x => x.UserId)
          //.WillCascadeOnDelete(false);

            // HasRequired(x => x.Users)
            // .WithMany(x => x.FacilityPeru)
            //.HasForeignKey(x => x.Users_Id)
            // .WillCascadeOnDelete(false);



        }
    }
}
