using System.Data.Entity.ModelConfiguration;
using Core.Domains;
using System.Linq;

namespace Data.Mappings
{
    class AssociationMap : EntityTypeConfiguration<Association>
    {
        public AssociationMap()
        {
            // Table 
            ToTable("Association", "dbo");
            // Primary Key
            // HasRequired(x => x.Users)
            HasRequired(x => x.Users)
            .WithMany(x => x.UserAssociation)
           .HasForeignKey(x => x.UserId)
           .WillCascadeOnDelete(true);

            HasRequired(x => x.Facility)
        .WithMany(x => x.FacilityAssociation)
       .HasForeignKey(x => x.FacilityId)
       .WillCascadeOnDelete(true);
        }
    }
}
