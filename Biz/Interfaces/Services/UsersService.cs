using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biz.Interfaces;
using Core.Domains;
using Data;

namespace Biz.Services
{
    public class UsersService : IUsersService
    {
        #region Properties
        private readonly IRepository<Users> _usersRepo;
      
        #endregion

        #region Constructor

        public UsersService()
        {
            _usersRepo = new Repository<Users>();
           
        }

        public UsersService(IRepository<Users> usersRepo)
        {
            _usersRepo = usersRepo;
        }
        #endregion

        #region Methods
        public IQueryable<Users> GetAll()
        {
            return _usersRepo.Table;
        }

        public void Delete(Users users)
        {
            _usersRepo.Delete(users);
        }
        public Users GetById(int id)
        {
            return _usersRepo.GetById(id);
        }

        public IEnumerable<Users> GetAllDataTable(string sortOrder, string search, bool? activeFilter = null)
        {
            var queryTable = _usersRepo.Table;

            if (!string.IsNullOrWhiteSpace(search))
            {
                var searchValue = search.ToLower();

                queryTable = queryTable.Where(x => x.Name.ToLower().Contains(searchValue) || x.Address.ToLower().Contains(searchValue));
            }
            switch (sortOrder)
            {
                case "Name":
                    return queryTable.OrderBy(x => x.Name);

            }
            return queryTable;


        }

        public void InsertOrUpdate(Users users)
        {
            if (users.Id == 0)
            {
                _usersRepo.Insert(users);
            }
            else
            {
                _usersRepo.Update(users);
            }
        }
        #endregion

    }
}


