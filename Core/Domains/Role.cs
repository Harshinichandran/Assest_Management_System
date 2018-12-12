
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domains
{
    public class Role : BaseEntity
    {
       // public int RoleId { get; set; }
        public string RoleName { get; set; }
        //public string StandardUser { get; set; }
     public virtual ICollection<Users> UsersInfo { get; set; }


    }
}
