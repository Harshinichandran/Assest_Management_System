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
    public class AssociationService : IAssociationService
    {
        #region Properties
        private readonly IRepository<Association> _associationRepo;
        #endregion
        #region Constructor
        public AssociationService()
        {
            _associationRepo = new Repository<Association>();
        }
        public AssociationService(IRepository<Association> associationRepo)
        {
            _associationRepo = associationRepo;
        }
        #endregion
        #region Methods
        public IQueryable<Association> GetAll()
        {
            return _associationRepo.Table;
        }
        public void Delete(Association association)
        {
            _associationRepo.Delete(association);
        }
        public Association GetById(int id)
        {
            return _associationRepo.GetById(id);
        }
        public void InsertOrUpdate(Association association)
        {
            if (association.Id == 0)
            {
                _associationRepo.Insert(association);
            }
            else
            {
                _associationRepo.Update(association);
            }
        }
        public IEnumerable<Association> GetAllDataTable(string sortOrder, string search, bool? activeFilter = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}