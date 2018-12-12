using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domains
{

    public class Association : BaseEntity
    {
        public int UserId { get; set; }
        public int FacilityId { get; set; }
        //public int BlogForeignKey { get; set; }

        public virtual Users Users { get; set; }
        public virtual Facility Facility { get; set; }

    }
}
