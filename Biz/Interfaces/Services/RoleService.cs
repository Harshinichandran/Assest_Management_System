using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biz.Interfaces;
using Core.Domains;
using Data;

namespace Biz.Interfaces.Services
{
    public class RoleService : IRoleService
    {
        #region Properties
        private readonly IRepository<Role> _roleRepo;

        #endregion

        #region Constructor

        public RoleService()
        {
            _roleRepo = new Repository<Role>();

        }

        public RoleService(IRepository<Role> roleRepo)
        {
            _roleRepo = roleRepo;
        }
        #endregion

        #region Methods
        public IQueryable<Role> GetAll()
        {
            return _roleRepo.Table;
        }
        public Role GetById(int id)
        {
            return _roleRepo.GetById(id);
        }
        public void Insert(Role role)
        {
            if (role.Id == 0)
            {
                _roleRepo.Insert(role);
            }
            else
            {
                _roleRepo.Update(role);
            }
        }
        #endregion
    }
}