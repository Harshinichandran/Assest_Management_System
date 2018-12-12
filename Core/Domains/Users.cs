using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domains
{
    
    public class Users : BaseEntity
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public Boolean UserEnabled { get; set; }
        public virtual string FacilityName { get; set; }
        public virtual string RoleName { get; set; }
        public virtual ICollection<Association> UserAssociation { get; set; }
        public virtual Role Roles { get; set; }
        public virtual Facility Facility { get; set; }
      
    }
}
