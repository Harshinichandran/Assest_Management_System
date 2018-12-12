using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domains
{
        public class Resources : BaseEntity
    {
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public string SubCategoryId { get; set; }
        public int FacilityId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Quantity { get; set; }
        public int OldQuantity { get; set; }
        public string Comments { get; set; }
        public virtual string FacilityName { get; set; }

        public virtual Facility Facilities { get; set; }
    }
}
