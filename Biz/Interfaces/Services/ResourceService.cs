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
    public class ResourcesService : IResourceService
    { 
        #region Properties
        private readonly IRepository<Resources> _resourcesRepo;

        #endregion

        #region Constructor

        public ResourcesService()
        {
            _resourcesRepo = new Repository<Resources>();

        }

        public ResourcesService(IRepository<Resources> resourcesRepo)
        {
            _resourcesRepo = resourcesRepo;
        }
        #endregion

        #region Methods
        public IQueryable<Resources> GetAll()
        {
            return _resourcesRepo.Table;
        }

        public void Delete(Resources resources)
        {
            _resourcesRepo.Delete(resources);
        }
        public Resources GetById(int id)
        {
            return _resourcesRepo.GetById(id);
        }

        public IEnumerable<Resources> GetAllDataTable(string sortOrder, string search, bool? activeFilter = null)
        {
            var queryTable = _resourcesRepo.Table;

            if (!string.IsNullOrWhiteSpace(search))
            {
                var searchValue = search.ToLower();

                queryTable = queryTable.Where(x => x.Name.ToLower().Contains(searchValue));
            }
            switch (sortOrder)
            {
                case "Name":
                    return queryTable.OrderBy(x => x.Name);
            }
            return queryTable;


        }

        public void InsertOrUpdate(Resources resources)
        {
            if (resources.Id == 0)
            {
                _resourcesRepo.Insert(resources);
            }
            else
            {
                _resourcesRepo.Update(resources);
            }
        }
               
        #endregion

    }
}
