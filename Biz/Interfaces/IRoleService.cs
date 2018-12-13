using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domains;

namespace Biz.Interfaces
{
     public interface IRoleService
    {
        IQueryable<Role> GetAll();

        void Insert(Role role);
        Role GetById(int id);
    }
}
